
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Submit message extended with Phoenix-specific fields.
    /// </summary>
    public sealed partial class SubmitMessage
    {
        /// <summary>
        /// Default Value: submit-message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public string? Trigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Phoenix.UIMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        public global::System.Collections.Generic.IList<global::Phoenix.ContextsItem2>? Contexts { get; set; }

        /// <summary>
        /// Runtime capability state sent by the browser for a chat turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Phoenix.AgentCapabilities? Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="messages"></param>
        /// <param name="sessionId"></param>
        /// <param name="trigger">
        /// Default Value: submit-message
        /// </param>
        /// <param name="contexts"></param>
        /// <param name="capabilities">
        /// Runtime capability state sent by the browser for a chat turn.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitMessage(
            string id,
            global::System.Collections.Generic.IList<global::Phoenix.UIMessage> messages,
            string sessionId,
            string? trigger,
            global::System.Collections.Generic.IList<global::Phoenix.ContextsItem2>? contexts,
            global::Phoenix.AgentCapabilities? capabilities)
        {
            this.Trigger = trigger;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Contexts = contexts;
            this.Capabilities = capabilities;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitMessage" /> class.
        /// </summary>
        public SubmitMessage()
        {
        }
    }
}