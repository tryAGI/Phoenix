
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptVersionRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptVersionData Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::Phoenix.PromptVersionTagData>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptVersionRequestBody" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePromptVersionRequestBody(
            global::Phoenix.PromptVersionData version,
            global::System.Collections.Generic.IList<global::Phoenix.PromptVersionTagData>? tags)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptVersionRequestBody" /> class.
        /// </summary>
        public CreatePromptVersionRequestBody()
        {
        }

    }
}