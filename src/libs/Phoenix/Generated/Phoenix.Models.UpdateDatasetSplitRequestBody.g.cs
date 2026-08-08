
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDatasetSplitRequestBody
    {
        /// <summary>
        /// A new unique name for the split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A new description, or null to clear it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A new hex color for the split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// New JSON metadata that replaces the existing metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Dataset example IDs (GlobalIDs) to add to the split. Each example must belong to this dataset. Adding an example already in the split is a no-op.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_example_ids")]
        public global::System.Collections.Generic.IList<string>? AddExampleIds { get; set; }

        /// <summary>
        /// Dataset example IDs (GlobalIDs) to remove from the split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_example_ids")]
        public global::System.Collections.Generic.IList<string>? RemoveExampleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDatasetSplitRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// A new unique name for the split.
        /// </param>
        /// <param name="description">
        /// A new description, or null to clear it.
        /// </param>
        /// <param name="color">
        /// A new hex color for the split.
        /// </param>
        /// <param name="metadata">
        /// New JSON metadata that replaces the existing metadata.
        /// </param>
        /// <param name="addExampleIds">
        /// Dataset example IDs (GlobalIDs) to add to the split. Each example must belong to this dataset. Adding an example already in the split is a no-op.
        /// </param>
        /// <param name="removeExampleIds">
        /// Dataset example IDs (GlobalIDs) to remove from the split.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDatasetSplitRequestBody(
            string? name,
            string? description,
            string? color,
            object? metadata,
            global::System.Collections.Generic.IList<string>? addExampleIds,
            global::System.Collections.Generic.IList<string>? removeExampleIds)
        {
            this.Name = name;
            this.Description = description;
            this.Color = color;
            this.Metadata = metadata;
            this.AddExampleIds = addExampleIds;
            this.RemoveExampleIds = removeExampleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDatasetSplitRequestBody" /> class.
        /// </summary>
        public UpdateDatasetSplitRequestBody()
        {
        }

    }
}