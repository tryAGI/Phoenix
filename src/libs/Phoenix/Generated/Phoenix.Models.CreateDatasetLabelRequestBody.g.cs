
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetLabelRequestBody
    {
        /// <summary>
        /// The name of the dataset label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A lowercase hex color code (e.g. '#00cc88') used to display the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// An optional description of the dataset label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetLabelRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the dataset label
        /// </param>
        /// <param name="color">
        /// A lowercase hex color code (e.g. '#00cc88') used to display the label
        /// </param>
        /// <param name="description">
        /// An optional description of the dataset label
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetLabelRequestBody(
            string name,
            string color,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetLabelRequestBody" /> class.
        /// </summary>
        public CreateDatasetLabelRequestBody()
        {
        }

    }
}