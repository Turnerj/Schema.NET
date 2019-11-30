namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// </summary>
    public partial interface IBarcode : IImageObject
    {
    }

    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// </summary>
    public partial class Barcode : ImageObject, IBarcode
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Barcode";
    }
}
