
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Fields to update on a dataset label. Omit a field to leave it unchanged.
    /// </summary>
    public sealed partial class UpdateDatasetLabelRequestBody
    {
        /// <summary>
        /// New name for the label (null is rejected; name is required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New lowercase hex color code for the label (null is rejected)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// New description for the label (null clears the description)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDatasetLabelRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the label (null is rejected; name is required)
        /// </param>
        /// <param name="color">
        /// New lowercase hex color code for the label (null is rejected)
        /// </param>
        /// <param name="description">
        /// New description for the label (null clears the description)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDatasetLabelRequestBody(
            string? name,
            string? color,
            string? description)
        {
            this.Name = name;
            this.Color = color;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDatasetLabelRequestBody" /> class.
        /// </summary>
        public UpdateDatasetLabelRequestBody()
        {
        }

    }
}