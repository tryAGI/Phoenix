
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Regenerate message extended with Phoenix-specific fields.
    /// </summary>
    public sealed partial class ChatRegenerateMessage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"regenerate-message"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public string Trigger { get; set; } = "regenerate-message";

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
        public required global::System.Collections.Generic.IList<global::Phoenix.AssistantMetadataUIMessage> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        public string? MessageId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestTraces")]
        public bool? IngestTraces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportRemoteTraces")]
        public bool? ExportRemoteTraces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        public global::System.Collections.Generic.IList<global::Phoenix.ChatContext>? Contexts { get; set; }

        /// <summary>
        /// Runtime capability state sent by the browser for a chat turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Phoenix.AgentCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRegenerateMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="messages"></param>
        /// <param name="messageId"></param>
        /// <param name="ingestTraces">
        /// Default Value: false
        /// </param>
        /// <param name="exportRemoteTraces">
        /// Default Value: false
        /// </param>
        /// <param name="contexts"></param>
        /// <param name="capabilities">
        /// Runtime capability state sent by the browser for a chat turn.
        /// </param>
        /// <param name="trigger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRegenerateMessage(
            string id,
            global::System.Collections.Generic.IList<global::Phoenix.AssistantMetadataUIMessage> messages,
            string? messageId,
            bool? ingestTraces,
            bool? exportRemoteTraces,
            global::System.Collections.Generic.IList<global::Phoenix.ChatContext>? contexts,
            global::Phoenix.AgentCapabilities? capabilities,
            string trigger = "regenerate-message")
        {
            this.Trigger = trigger;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MessageId = messageId;
            this.IngestTraces = ingestTraces;
            this.ExportRemoteTraces = exportRemoteTraces;
            this.Contexts = contexts;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRegenerateMessage" /> class.
        /// </summary>
        public ChatRegenerateMessage()
        {
        }

    }
}