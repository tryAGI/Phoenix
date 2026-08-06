
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Fields to update on a prompt. Omit a field to leave it unchanged.
    /// </summary>
    public sealed partial class PatchPromptRequestBody
    {
        /// <summary>
        /// New description for the prompt (null clears the description)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// New metadata object for the prompt (replaces the existing metadata as a whole)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPromptRequestBody" /> class.
        /// </summary>
        /// <param name="description">
        /// New description for the prompt (null clears the description)
        /// </param>
        /// <param name="metadata">
        /// New metadata object for the prompt (replaces the existing metadata as a whole)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchPromptRequestBody(
            string? description,
            object? metadata)
        {
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchPromptRequestBody" /> class.
        /// </summary>
        public PatchPromptRequestBody()
        {
        }

    }
}