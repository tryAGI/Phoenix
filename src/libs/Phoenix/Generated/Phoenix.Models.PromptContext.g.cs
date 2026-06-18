
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Prompt the user is currently viewing.
    /// </summary>
    public sealed partial class PromptContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"prompt"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "prompt";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptContext" /> class.
        /// </summary>
        /// <param name="promptNodeId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptContext(
            string promptNodeId,
            string type = "prompt")
        {
            this.Type = type;
            this.PromptNodeId = promptNodeId ?? throw new global::System.ArgumentNullException(nameof(promptNodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptContext" /> class.
        /// </summary>
        public PromptContext()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PromptContext"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PromptContext FromPromptNodeId(string promptNodeId)
        {
            return new PromptContext
            {
                PromptNodeId = promptNodeId,
            };
        }

    }
}