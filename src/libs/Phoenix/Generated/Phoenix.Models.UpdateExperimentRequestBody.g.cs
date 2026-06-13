
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Fields to update on an experiment. Omit a field to leave it unchanged.
    /// </summary>
    public sealed partial class UpdateExperimentRequestBody
    {
        /// <summary>
        /// New name for the experiment (null is rejected; name is required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description for the experiment (null clears the description)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// New metadata object for the experiment (replaces the existing metadata as a whole; null is rejected)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExperimentRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the experiment (null is rejected; name is required)
        /// </param>
        /// <param name="description">
        /// New description for the experiment (null clears the description)
        /// </param>
        /// <param name="metadata">
        /// New metadata object for the experiment (replaces the existing metadata as a whole; null is rejected)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateExperimentRequestBody(
            string? name,
            string? description,
            object? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExperimentRequestBody" /> class.
        /// </summary>
        public UpdateExperimentRequestBody()
        {
        }

    }
}