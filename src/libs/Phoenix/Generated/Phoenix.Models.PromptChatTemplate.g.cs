
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptChatTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"chat"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "chat";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Phoenix.PromptMessage> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptChatTemplate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="messages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptChatTemplate(
            global::System.Collections.Generic.IList<global::Phoenix.PromptMessage> messages,
            string type = "chat")
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptChatTemplate" /> class.
        /// </summary>
        public PromptChatTemplate()
        {
        }
    }
}