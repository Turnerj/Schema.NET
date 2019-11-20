namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Xml;

    /// <summary>
    /// Converts an <see cref="IValues"/> object to JSON. If the <see cref="IValues"/> contains a
    /// <see cref="TimeSpan"/>, converts it to ISO 8601 format first.
    /// </summary>
    /// <seealso cref="JsonConverter" />
    /// <seealso cref="ValuesJsonConverter" />
    public class TimeSpanToISO8601DurationValuesJsonConverter : ValuesJsonConverter
    {
        /// <inheritdoc />
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

            var valuesType = typeToConvert.GetUnderlyingTypeFromNullable();
            if (valuesType != null && valuesType.GenericTypeArguments.Length == 1)
            {
                var mainType = valuesType.GenericTypeArguments[0];
                var genericType = typeof(OneOrMany<TimeSpan>);
                if (mainType.IsNullable())
                {
                    mainType = Nullable.GetUnderlyingType(mainType);
                    genericType = typeof(OneOrMany<TimeSpan?>);
                }

                if (mainType == typeof(TimeSpan))
                {
                    var timeSpan = XmlConvert.ToTimeSpan(reader.GetString());
                    var instance = Activator.CreateInstance(genericType, timeSpan);
                    return instance as IValues;
                }
            }

            return base.Read(ref reader, typeToConvert, options);
        }

        /// <summary>
        /// Writes the object retrieved from <see cref="IValues"/> when one is found.
        /// </summary>
        /// <param name="writer">The JSON writer.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="options">The JSON serializer options.</param>
        public override void WriteObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
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

            if (value is TimeSpan duration)
            {
                writer.WriteStringValue(XmlConvert.ToString(duration));
            }
            else
            {
                base.WriteObject(writer, value, options);
            }
        }
    }
}
