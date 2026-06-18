
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Prompt version the user is currently viewing.
    /// </summary>
    public sealed partial class PromptVersionContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"prompt_version"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "prompt_version";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersionNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersionNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionContext" /> class.
        /// </summary>
        /// <param name="promptNodeId"></param>
        /// <param name="promptVersionNodeId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionContext(
            string promptNodeId,
            string promptVersionNodeId,
            string type = "prompt_version")
        {
            this.Type = type;
            this.PromptNodeId = promptNodeId ?? throw new global::System.ArgumentNullException(nameof(promptNodeId));
            this.PromptVersionNodeId = promptVersionNodeId ?? throw new global::System.ArgumentNullException(nameof(promptVersionNodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionContext" /> class.
        /// </summary>
        public PromptVersionContext()
        {
        }

    }
}