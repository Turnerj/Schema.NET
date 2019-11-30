namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    public partial interface IProduct : IThing
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        OneOrMany<string> Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        Values<PhysicalActivityCategory?, string, IThing> Category { get; set; }

        /// <summary>
        /// The color of the product.
        /// </summary>
        OneOrMany<string> Color { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Depth { get; set; }

        /// <summary>
        /// A Global Trade Item Number (&lt;a href="https://www.gs1.org/standards/id-keys/gtin"&gt;GTIN&lt;/a&gt;). GTINs identify trade items, including products and services, using numeric identification codes. The &lt;a class="localLink" href="http://schema.org/gtin"&gt;gtin&lt;/a&gt; property generalizes the earlier &lt;a class="localLink" href="http://schema.org/gtin8"&gt;gtin8&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/gtin12"&gt;gtin12&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/gtin13"&gt;gtin13&lt;/a&gt;, and &lt;a class="localLink" href="http://schema.org/gtin14"&gt;gtin14&lt;/a&gt; properties. The GS1 &lt;a href="https://www.gs1.org/standards/Digital-Link/"&gt;digital link specifications&lt;/a&gt; express GTINs as URLs. A correct &lt;a class="localLink" href="http://schema.org/gtin"&gt;gtin&lt;/a&gt; value should be a valid GTIN, which means that it should be an all-numeric string of either 8, 12, 13 or 14 digits, or a "GS1 Digital Link" URL based on such a string. The numeric component should also have a &lt;a href="https://www.gs1.org/services/check-digit-calculator"&gt;valid GS1 check digit&lt;/a&gt; and meet the other rules for valid GTINs. See also &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1's GTIN Summary&lt;/a&gt; and &lt;a href="https://en.wikipedia.org/wiki/Global_Trade_Item_Number"&gt;Wikipedia&lt;/a&gt; for more details. Left-padding of the gtin values is not required or encouraged.
        /// </summary>
        OneOrMany<string> Gtin { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        OneOrMany<string> Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        OneOrMany<string> Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        OneOrMany<string> Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        OneOrMany<string> Gtin8 { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        OneOrMany<IProduct> IsAccessoryOrSparePartFor { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        OneOrMany<IProduct> IsConsumableFor { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        Values<IProduct, IService> IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        Values<IProduct, IService> IsSimilarTo { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        Values<IProduct, string, Uri> Material { get; set; }

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        Values<IProductModel, string> Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// Indicates the &lt;a href="https://en.wikipedia.org/wiki/NATO_Stock_Number"&gt;NATO stock number&lt;/a&gt; (nsn) of a &lt;a class="localLink" href="http://schema.org/Product"&gt;Product&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> Nsn { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        OneOrMany<IOffer> Offers { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
        /// </summary>
        OneOrMany<string> ProductID { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        Values<int?, DateTime?> ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        Values<int?, DateTime?> PurchaseDate { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        Values<int?, DateTime?> ReleaseDate { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        OneOrMany<string> Sku { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Width { get; set; }
    }

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// </summary>
    public partial class Product : Thing, IProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Product";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [JsonPropertyName("additionalProperty")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPropertyValue> AdditionalProperty { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [JsonPropertyName("aggregateRating")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [JsonPropertyName("audience")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [JsonPropertyName("award")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [JsonPropertyName("brand")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [JsonPropertyName("category")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PhysicalActivityCategory?, string, IThing> Category { get; set; }

        /// <summary>
        /// The color of the product.
        /// </summary>
        [JsonPropertyName("color")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Color { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [JsonPropertyName("depth")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Depth { get; set; }

        /// <summary>
        /// A Global Trade Item Number (&lt;a href="https://www.gs1.org/standards/id-keys/gtin"&gt;GTIN&lt;/a&gt;). GTINs identify trade items, including products and services, using numeric identification codes. The &lt;a class="localLink" href="http://schema.org/gtin"&gt;gtin&lt;/a&gt; property generalizes the earlier &lt;a class="localLink" href="http://schema.org/gtin8"&gt;gtin8&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/gtin12"&gt;gtin12&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/gtin13"&gt;gtin13&lt;/a&gt;, and &lt;a class="localLink" href="http://schema.org/gtin14"&gt;gtin14&lt;/a&gt; properties. The GS1 &lt;a href="https://www.gs1.org/standards/Digital-Link/"&gt;digital link specifications&lt;/a&gt; express GTINs as URLs. A correct &lt;a class="localLink" href="http://schema.org/gtin"&gt;gtin&lt;/a&gt; value should be a valid GTIN, which means that it should be an all-numeric string of either 8, 12, 13 or 14 digits, or a "GS1 Digital Link" URL based on such a string. The numeric component should also have a &lt;a href="https://www.gs1.org/services/check-digit-calculator"&gt;valid GS1 check digit&lt;/a&gt; and meet the other rules for valid GTINs. See also &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1's GTIN Summary&lt;/a&gt; and &lt;a href="https://en.wikipedia.org/wiki/Global_Trade_Item_Number"&gt;Wikipedia&lt;/a&gt; for more details. Left-padding of the gtin values is not required or encouraged.
        /// </summary>
        [JsonPropertyName("gtin")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin { get; set; }

        /// <summary>
        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [JsonPropertyName("gtin12")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin12 { get; set; }

        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [JsonPropertyName("gtin13")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin13 { get; set; }

        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [JsonPropertyName("gtin14")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin14 { get; set; }

        /// <summary>
        /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
        /// </summary>
        [JsonPropertyName("gtin8")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Gtin8 { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [JsonPropertyName("height")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        [JsonPropertyName("isAccessoryOrSparePartFor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProduct> IsAccessoryOrSparePartFor { get; set; }

        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is a consumable.
        /// </summary>
        [JsonPropertyName("isConsumableFor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProduct> IsConsumableFor { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [JsonPropertyName("isRelatedTo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService> IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [JsonPropertyName("isSimilarTo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService> IsSimilarTo { get; set; }

        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        [JsonPropertyName("itemCondition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<OfferItemCondition?> ItemCondition { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [JsonPropertyName("logo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [JsonPropertyName("material")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, string, Uri> Material { get; set; }

        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        [JsonPropertyName("model")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProductModel, string> Model { get; set; }

        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        [JsonPropertyName("mpn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Mpn { get; set; }

        /// <summary>
        /// Indicates the &lt;a href="https://en.wikipedia.org/wiki/NATO_Stock_Number"&gt;NATO stock number&lt;/a&gt; (nsn) of a &lt;a class="localLink" href="http://schema.org/Product"&gt;Product&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("nsn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Nsn { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [JsonPropertyName("offers")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> Offers { get; set; }

        /// <summary>
        /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
        /// </summary>
        [JsonPropertyName("productID")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProductID { get; set; }

        /// <summary>
        /// The date of production of the item, e.g. vehicle.
        /// </summary>
        [JsonPropertyName("productionDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public virtual Values<int?, DateTime?> ProductionDate { get; set; }

        /// <summary>
        /// The date the item e.g. vehicle was purchased by the current owner.
        /// </summary>
        [JsonPropertyName("purchaseDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public virtual Values<int?, DateTime?> PurchaseDate { get; set; }

        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        [JsonPropertyName("releaseDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> ReleaseDate { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [JsonPropertyName("review")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        [JsonPropertyName("sku")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Sku { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [JsonPropertyName("slogan")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [JsonPropertyName("weight")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [JsonPropertyName("width")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Width { get; set; }
    }
}
