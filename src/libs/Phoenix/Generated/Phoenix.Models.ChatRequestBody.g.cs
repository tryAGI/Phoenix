
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Assistant chat submit request payload.
    /// </summary>
    public sealed partial class ChatRequestBody
    {
        /// <summary>
        /// Whether a headless client (terminal or scripted) is driving the turn, as opposed to the browser assistant. Selects the agent configuration the turn runs on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headless")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Headless { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        public global::System.Collections.Generic.IList<global::Phoenix.ChatContext>? Contexts { get; set; }

        /// <summary>
        /// Default Value: manual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editPermission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ChatRequestBodyEditPermissionJsonConverter))]
        public global::Phoenix.ChatRequestBodyEditPermission? EditPermission { get; set; }

        /// <summary>
        /// Skills the user explicitly requested via the prompt's slash-command affordance. The server force-loads each available skill by injecting a synthetic load_skill tool call/result at the tail of the message history. Unknown or context-unavailable names are ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedSkills")]
        public global::System.Collections.Generic.IList<string>? RequestedSkills { get; set; }

        /// <summary>
        /// The model the client believes the session is set to. This is a precondition, not an instruction: the turn always runs on the session's persisted selection, and a mismatch is rejected with HTTP 409 and code ``agent_session_model_stale`` rather than silently running on — or switching to — an unexpected model. Change the session's model with ``PATCH .../agent_sessions/{session_id}``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.AgentModelSelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.AgentModelSelection Model { get; set; }

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
        /// The turn's new user message to append. May be omitted for client-tool continuation, where ``toolOutputs`` resolve the trailing assistant message's pending tool calls instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::Phoenix.PhoenixUIMessage? Message { get; set; }

        /// <summary>
        /// Client-executed tool results for pending tool calls on the transcript's trailing assistant message, matched by ``toolCallId``. Submitted alone they continue the assistant turn; submitted with ``message`` they resolve dangling tool calls before the new user turn runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolOutputs")]
        public global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputErrorPart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputErrorPart>>? ToolOutputs { get; set; }

        /// <summary>
        /// The id of the last transcript message the client has rendered, used for optimistic concurrency. Omit when the session has no messages; required (and validated against the persisted transcript) once it does. On mismatch the server rejects the send with HTTP 409 and code ``agent_session_messages_stale`` — the client should refetch the session before retrying.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastMessageId")]
        public string? LastMessageId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordLocalTraces")]
        public bool? RecordLocalTraces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportRemoteTraces")]
        public bool? ExportRemoteTraces { get; set; }

        /// <summary>
        /// When true and the request is authenticated as a PhoenixUser, attaches the user's email as the OpenInference ``user.id`` span attribute on all traced work for this request.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrumentUserId")]
        public bool? InstrumentUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBody" /> class.
        /// </summary>
        /// <param name="headless">
        /// Whether a headless client (terminal or scripted) is driving the turn, as opposed to the browser assistant. Selects the agent configuration the turn runs on.
        /// </param>
        /// <param name="model">
        /// The model the client believes the session is set to. This is a precondition, not an instruction: the turn always runs on the session's persisted selection, and a mismatch is rejected with HTTP 409 and code ``agent_session_model_stale`` rather than silently running on — or switching to — an unexpected model. Change the session's model with ``PATCH .../agent_sessions/{session_id}``.
        /// </param>
        /// <param name="id"></param>
        /// <param name="contexts"></param>
        /// <param name="editPermission">
        /// Default Value: manual
        /// </param>
        /// <param name="requestedSkills">
        /// Skills the user explicitly requested via the prompt's slash-command affordance. The server force-loads each available skill by injecting a synthetic load_skill tool call/result at the tail of the message history. Unknown or context-unavailable names are ignored.
        /// </param>
        /// <param name="trigger">
        /// Default Value: submit-message
        /// </param>
        /// <param name="message">
        /// The turn's new user message to append. May be omitted for client-tool continuation, where ``toolOutputs`` resolve the trailing assistant message's pending tool calls instead.
        /// </param>
        /// <param name="toolOutputs">
        /// Client-executed tool results for pending tool calls on the transcript's trailing assistant message, matched by ``toolCallId``. Submitted alone they continue the assistant turn; submitted with ``message`` they resolve dangling tool calls before the new user turn runs.
        /// </param>
        /// <param name="lastMessageId">
        /// The id of the last transcript message the client has rendered, used for optimistic concurrency. Omit when the session has no messages; required (and validated against the persisted transcript) once it does. On mismatch the server rejects the send with HTTP 409 and code ``agent_session_messages_stale`` — the client should refetch the session before retrying.
        /// </param>
        /// <param name="recordLocalTraces">
        /// Default Value: false
        /// </param>
        /// <param name="exportRemoteTraces">
        /// Default Value: false
        /// </param>
        /// <param name="instrumentUserId">
        /// When true and the request is authenticated as a PhoenixUser, attaches the user's email as the OpenInference ``user.id`` span attribute on all traced work for this request.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestBody(
            bool headless,
            global::Phoenix.AgentModelSelection model,
            string id,
            global::System.Collections.Generic.IList<global::Phoenix.ChatContext>? contexts,
            global::Phoenix.ChatRequestBodyEditPermission? editPermission,
            global::System.Collections.Generic.IList<string>? requestedSkills,
            string? trigger,
            global::Phoenix.PhoenixUIMessage? message,
            global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputErrorPart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputErrorPart>>? toolOutputs,
            string? lastMessageId,
            bool? recordLocalTraces,
            bool? exportRemoteTraces,
            bool? instrumentUserId)
        {
            this.Headless = headless;
            this.Contexts = contexts;
            this.EditPermission = editPermission;
            this.RequestedSkills = requestedSkills;
            this.Model = model;
            this.Trigger = trigger;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Message = message;
            this.ToolOutputs = toolOutputs;
            this.LastMessageId = lastMessageId;
            this.RecordLocalTraces = recordLocalTraces;
            this.ExportRemoteTraces = exportRemoteTraces;
            this.InstrumentUserId = instrumentUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBody" /> class.
        /// </summary>
        public ChatRequestBody()
        {
        }

    }
}