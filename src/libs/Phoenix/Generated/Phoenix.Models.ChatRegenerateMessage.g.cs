
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
        /// When true and the request is authenticated as a PhoenixUser, attaches the user's email as the OpenInference ``user.id`` span attribute on all traced work for this request.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachUserId")]
        public bool? AttachUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        public global::System.Collections.Generic.IList<global::Phoenix.ChatContext>? Contexts { get; set; }

        /// <summary>
        /// Default Value: manual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editPermission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageEditPermissionJsonConverter))]
        public global::Phoenix.ChatRegenerateMessageEditPermission? EditPermission { get; set; }

        /// <summary>
        /// Skills the user explicitly requested via the prompt's slash-command affordance. The server force-loads each available skill by injecting a synthetic load_skill tool call/result at the tail of the message history. Unknown or context-unavailable names are ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedSkills")]
        public global::System.Collections.Generic.IList<string>? RequestedSkills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.Model Model { get; set; }

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
        /// <param name="model"></param>
        /// <param name="messageId"></param>
        /// <param name="ingestTraces">
        /// Default Value: false
        /// </param>
        /// <param name="exportRemoteTraces">
        /// Default Value: false
        /// </param>
        /// <param name="attachUserId">
        /// When true and the request is authenticated as a PhoenixUser, attaches the user's email as the OpenInference ``user.id`` span attribute on all traced work for this request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="contexts"></param>
        /// <param name="editPermission">
        /// Default Value: manual
        /// </param>
        /// <param name="requestedSkills">
        /// Skills the user explicitly requested via the prompt's slash-command affordance. The server force-loads each available skill by injecting a synthetic load_skill tool call/result at the tail of the message history. Unknown or context-unavailable names are ignored.
        /// </param>
        /// <param name="trigger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRegenerateMessage(
            string id,
            global::System.Collections.Generic.IList<global::Phoenix.AssistantMetadataUIMessage> messages,
            global::Phoenix.Model model,
            string? messageId,
            bool? ingestTraces,
            bool? exportRemoteTraces,
            bool? attachUserId,
            global::System.Collections.Generic.IList<global::Phoenix.ChatContext>? contexts,
            global::Phoenix.ChatRegenerateMessageEditPermission? editPermission,
            global::System.Collections.Generic.IList<string>? requestedSkills,
            string trigger = "regenerate-message")
        {
            this.Trigger = trigger;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MessageId = messageId;
            this.IngestTraces = ingestTraces;
            this.ExportRemoteTraces = exportRemoteTraces;
            this.AttachUserId = attachUserId;
            this.Contexts = contexts;
            this.EditPermission = editPermission;
            this.RequestedSkills = requestedSkills;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRegenerateMessage" /> class.
        /// </summary>
        public ChatRegenerateMessage()
        {
        }

    }
}