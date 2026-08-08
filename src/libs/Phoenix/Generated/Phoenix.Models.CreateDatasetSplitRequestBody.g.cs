
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetSplitRequestBody
    {
        /// <summary>
        /// A unique name for the split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional description of the split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An optional hex color for the split (e.g. #33c5e8). Omit for a default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Arbitrary JSON metadata for the split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Optional dataset example IDs (GlobalIDs) to seed the split with. Each example must belong to this dataset. Omit to create an empty split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_ids")]
        public global::System.Collections.Generic.IList<string>? ExampleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetSplitRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// A unique name for the split.
        /// </param>
        /// <param name="description">
        /// An optional description of the split.
        /// </param>
        /// <param name="color">
        /// An optional hex color for the split (e.g. #33c5e8). Omit for a default.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata for the split.
        /// </param>
        /// <param name="exampleIds">
        /// Optional dataset example IDs (GlobalIDs) to seed the split with. Each example must belong to this dataset. Omit to create an empty split.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetSplitRequestBody(
            string name,
            string? description,
            string? color,
            object? metadata,
            global::System.Collections.Generic.IList<string>? exampleIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Color = color;
            this.Metadata = metadata;
            this.ExampleIds = exampleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetSplitRequestBody" /> class.
        /// </summary>
        public CreateDatasetSplitRequestBody()
        {
        }

    }
}