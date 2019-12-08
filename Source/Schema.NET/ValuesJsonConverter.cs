namespace Schema.NET
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="IValues"/> object to and from JSON.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    public class ValuesJsonConverter : JsonConverter<IValues>
    {
        private const string NamespacePrefix = "Schema.NET.";

        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert) => typeof(IValues).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The serializer options.</param>
        /// <returns>The object value.</returns>
        public override IValues Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert is null)
            {
                throw new ArgumentNullException(nameof(typeToConvert));
            }

            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var mainType = typeToConvert.GetUnderlyingTypeFromNullable();

            object argument = null;

            var tokenType = reader.TokenType;

            var token = JsonDocument.ParseValue(ref reader).RootElement;

#pragma warning disable CA1062 // Validate arguments of public methods
            if (mainType.GenericTypeArguments.Length == 1)
#pragma warning restore CA1062 // Validate arguments of public methods
            {
                var type = mainType.GenericTypeArguments[0];
                if (tokenType == JsonTokenType.StartArray)
                {
                    var unwrappedType = type.GetUnderlyingTypeFromNullable();
                    argument = ReadJsonArray(token, unwrappedType, null, options);
                }
                else
                {
                    argument = ParseTokenArguments(token, tokenType, type, options);
                }
            }
            else
            {
                if (tokenType == JsonTokenType.StartArray)
                {
                    var count = token.GetArrayLength();
                    var total = 0;
                    var items = new List<object>();
                    for (var i = mainType.GenericTypeArguments.Length - 1; i >= 0; i--)
                    {
                        var type = mainType.GenericTypeArguments[i];
                        var unwrappedType = type.GetUnderlyingTypeFromNullable();
                        // only read as many items as there are tokens left
                        var args = ReadJsonArray(token, unwrappedType, count - total, options);

                        if (args != null && args.Count > 0)
                        {
                            var genericType = typeof(OneOrMany<>).MakeGenericType(type);
                            var item = (IValues)Activator.CreateInstance(genericType, args);
                            items.Add(item);

                            total += args.Count;

                            if (total >= count)
                            {
                                // if we have deserialized enough items as there are tokens, break
                                break;
                            }
                        }
                    }

                    argument = items;
                }
                else
                {
                    for (var i = mainType.GenericTypeArguments.Length - 1; i >= 0; i--)
                    {
                        var type = mainType.GenericTypeArguments[i];

                        try
                        {
                            var args = ParseTokenArguments(token, tokenType, type, options);

                            if (args != null)
                            {
                                var genericType = typeof(OneOrMany<>).MakeGenericType(type);
                                argument = Activator.CreateInstance(genericType, args);
                            }
                        }
#pragma warning disable CA1031 // Do not catch general exception types
                        catch (Exception e)
                        {
                            // Nasty, but we're trying brute force as a last resort, to
                            // see which type has the right constructor for this value
                            Debug.WriteLine(e);
                        }
#pragma warning restore CA1031 // Do not catch general exception types

                        if (argument != null)
                        {
                            // return first valid argument, going from right to left in generic type arguments
                            break;
                        }
                    }
                }
            }

            object instance = null;
            try
            {
                instance = Activator.CreateInstance(mainType, argument);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
#pragma warning restore CA1031 // Do not catch general exception types

            return (IValues)instance;
        }

        /// <summary>
        /// Writes the specified <see cref="IValues"/> object using the JSON writer.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The <see cref="IValues"/> object.</param>
        /// <param name="options">The JSON serializer options.</param>
        public override void Write(Utf8JsonWriter writer, IValues value, JsonSerializerOptions options)
        {
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            var values = (IValues)value;
            if (values.Count == 0)
            {
                writer.WriteNullValue();
            }
            else if (values.Count == 1)
            {
                var enumerator = values.GetEnumerator();
                enumerator.MoveNext();
                this.WriteObject(writer, enumerator.Current, options);
            }
            else
            {
                writer.WriteStartArray();
                foreach (var item in values)
                {
                    this.WriteObject(writer, item, options);
                }

                writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Writes the object retrieved from <see cref="IValues"/> when one is found.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="options">The JSON serializer options.</param>
        public virtual void WriteObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            if (writer is null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            JsonSerializer.Serialize(writer, value, value?.GetType(), options);
        }

        private static object ParseTokenArguments(JsonElement token, JsonTokenType tokenType, Type type, JsonSerializerOptions options)
        {
            const string SCHEMA_ORG = "http://schema.org/";
            const int SCHEMA_ORG_LENGTH = 18; // equivalent to "http://schema.org/".Length
            const string SCHEMA_ORG_HTTPS = "https://schema.org/";
            const int SCHEMA_ORG_HTTPS_LENGTH = 19; // equivalent to "https://schema.org/".Length
            object args;
            var unwrappedType = type.GetUnderlyingTypeFromNullable();
            if (unwrappedType.GetTypeInfo().IsEnum)
            {
                var en = token.ToString();
                var enumString = en.Contains(SCHEMA_ORG) ? en.Substring(SCHEMA_ORG_LENGTH) :
                    en.Contains(SCHEMA_ORG_HTTPS) ? en.Substring(SCHEMA_ORG_HTTPS_LENGTH) : en;
                args = Enum.Parse(unwrappedType, enumString);
            }
            else
            {
                if (tokenType == JsonTokenType.StartObject)
                {
                    args = ParseTokenObjectArguments(token, type, unwrappedType, options);
                }
                else
                {
                    args = ParseTokenValueArguments(token, tokenType, type, unwrappedType, options);
                }
            }

            return args;
        }

        private static object ParseTokenObjectArguments(JsonElement token, Type type, Type unwrappedType, JsonSerializerOptions options)
        {
            object args = null;
            var typeName = GetTypeNameFromToken(token);
            if (string.IsNullOrEmpty(typeName))
            {
                args = token.ToObject(unwrappedType, options);
            }
            else if (typeName == type.Name)
            {
                args = token.ToObject(type, options);
            }
            else
            {
                var builtType = Type.GetType($"{NamespacePrefix}{typeName}");
                if (builtType != null && type.GetTypeInfo().IsAssignableFrom(builtType.GetTypeInfo()))
                {
                    args = token.ToObject(builtType, options);
                }
            }

            return args;
        }

        private static object ParseTokenValueArguments(JsonElement token, JsonTokenType tokenType, Type type, Type unwrappedType, JsonSerializerOptions options)
        {
            object args = null;
            if (unwrappedType.IsPrimitiveType())
            {
                if (tokenType == JsonTokenType.String)
                {
                    var value = token.GetString();
                    if (unwrappedType == typeof(string))
                    {
                        args = value;
                    }
                    else if (unwrappedType == typeof(int))
                    {
                        if (int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var i))
                        {
                            args = i;
                        }
                    }
                    else if (unwrappedType == typeof(long))
                    {
                        if (long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var i))
                        {
                            args = i;
                        }
                    }
                    else if (unwrappedType == typeof(float))
                    {
                        if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var i))
                        {
                            args = i;
                        }
                    }
                    else if (unwrappedType == typeof(double))
                    {
                        if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var i))
                        {
                            args = i;
                        }
                    }
                    else if (unwrappedType == typeof(bool))
                    {
                        if (bool.TryParse(value, out var i))
                        {
                            args = i;
                        }
                    }
                }
                else if (tokenType == JsonTokenType.Number)
                {
                    // Can safely convert between numeric types
                    if (unwrappedType == typeof(short) || unwrappedType == typeof(int) || unwrappedType == typeof(long) || unwrappedType == typeof(float) || unwrappedType == typeof(double))
                    {
                        var value = token.GetDecimal();
                        args = Convert.ChangeType(value, unwrappedType, CultureInfo.InvariantCulture);
                    }
                }
                else if (tokenType == JsonTokenType.True || tokenType == JsonTokenType.False)
                {
                    if (unwrappedType == typeof(bool))
                    {
                        args = token.GetBoolean();
                    }
                }

                // else if (value is DateTime || value is DateTimeOffset)
                // {
                //    // NO-OP: can't put a date into a primitive type
                // }
                else
                {
                    args = token.ToObject(typeof(object), options);
                }
            }
            else if (unwrappedType == typeof(decimal))
            {
                if (tokenType == JsonTokenType.String)
                {
                    if (decimal.TryParse(token.GetString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var i))
                    {
                        args = i;
                    }
                }
                else if (tokenType == JsonTokenType.Number)
                {
                    if (token.TryGetDecimal(out var i))
                    {
                        args = i;
                    }
                }
            }
            else if (unwrappedType == typeof(DateTime))
            {
                if (tokenType == JsonTokenType.String)
                {
                    if (DateTime.TryParse(token.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out var i))
                    {
                        args = i;
                    }
                }

                // else if (value is DateTime)
                // {
                //    args = value;
                // }
                // else if (value is DateTimeOffset)
                // {
                //    args = ((DateTimeOffset)value).DateTime;
                // }
                // else if (value is short || value is int || value is long || value is float || value is double)
                // {
                //    // NO-OP: can't put a primitive type into a date
                // }
                // else
                // {
                //    args = Convert.ToDateTime(value, CultureInfo.InvariantCulture);
                // }
            }
            else if (unwrappedType == typeof(DateTimeOffset))
            {
                if (tokenType == JsonTokenType.String)
                {
                    if (DateTimeOffset.TryParse(token.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.None, out var i))
                    {
                        args = i;
                    }
                }

                // else if (value is DateTime)
                // {
                //    args = new DateTimeOffset((DateTime)value);
                // }
                // else if (value is DateTimeOffset)
                // {
                //    args = value;
                // }
                // else
                // {
                //    args = Convert.ToDateTime(value, CultureInfo.InvariantCulture);
                // }
            }
            else
            {
                var classType = ToClass(type);
                if (tokenType == JsonTokenType.String)
                {
                    if (classType == typeof(Uri))
                    {
                        // REVIEW: Avoid invalid URIs being assigned as URI (Should we only allow absolute URIs?)
                        if (Uri.TryCreate(token.GetString(), UriKind.Absolute, out var i))
                        {
                            args = i;
                        }
                    }
                }

                // REVIEW: If argument still not assigned, only use ToObject if not casting primitive to interface or class
                if (args is null)
                {
                    if (!type.GetTypeInfo().IsInterface && !type.GetTypeInfo().IsClass)
                    {
                        args = token.ToObject(classType, options); // This is expected to throw on some case
                    }
                }
            }

            return args;
        }

        /// <summary>
        /// Gets the class type definition.
        /// </summary>
        /// <param name="type">The type under consideration.</param>
        /// <returns>
        /// The implementing class for <paramref name="type" /> or <paramref name="type" /> if it is already a class.
        /// </returns>
        private static Type ToClass(Type type)
        {
            if (type.GetTypeInfo().IsInterface)
            {
                return Type.GetType($"{type.Namespace}.{type.Name.Substring(1)}");
            }

            return type;
        }

        private static IList ReadJsonArray(JsonElement token, Type type, int? count, JsonSerializerOptions options)
        {
            var classType = ToClass(type);
            var listType = typeof(List<>).MakeGenericType(type); // always read into list of interfaces
            var list = Activator.CreateInstance(listType);
            var i = 0;

            if (count is null)
            {
                // if maximum item count not assigned, set to count of child tokens
                count = token.GetArrayLength();
            }

            foreach (var childToken in token.EnumerateArray())
            {
                var typeName = GetTypeNameFromToken(childToken);
                if (string.IsNullOrEmpty(typeName))
                {
                    var child = childToken.ToObject(classType, options);
                    var method = listType.GetRuntimeMethod(nameof(List<object>.Add), new[] { classType });

                    if (method != null)
                    {
                        method.Invoke(list, new object[] { child });

                        i++;
                    }
                }
                else
                {
                    var builtType = Type.GetType($"{NamespacePrefix}{typeName}");
                    if (builtType != null && type.GetTypeInfo().IsAssignableFrom(builtType.GetTypeInfo()))
                    {
                        var child = (Thing)childToken.ToObject(builtType, options);
                        var method = listType.GetRuntimeMethod(nameof(List<object>.Add), new[] { classType });

                        if (method != null)
                        {
                            method.Invoke(list, new object[] { child });

                            i++;
                        }
                    }
                }

                if (i == count)
                {
                    break;
                }
            }

            return (IList)list;
        }

        private static string GetTypeNameFromToken(JsonElement token)
        {
            if (token.ValueKind == JsonValueKind.Object && token.TryGetProperty("@type", out var typeElement))
            {
                return typeElement.GetString();
            }

            return null;
        }
    }
}
