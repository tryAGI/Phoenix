
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Body of every HTTP 409 returned by the agent session routes.<br/>
    /// - ``agent_session_busy``: another turn holds the session's turn lock.<br/>
    /// - ``agent_session_model_stale``: the request asserted a model the session<br/>
    ///   is no longer set to; refetch the session before retrying.<br/>
    /// - ``agent_session_messages_stale``: the send's ``lastMessageId`` no longer<br/>
    ///   matches the persisted transcript — another client appended; refetch the<br/>
    ///   transcript and retry.<br/>
    /// - ``agent_session_tool_outputs_conflict``: the submitted ``toolOutputs`` do<br/>
    ///   not match the transcript's trailing assistant message (no trailing<br/>
    ///   assistant message to continue, an unknown ``toolCallId``, or a tool-name<br/>
    ///   mismatch). Unlike ``agent_session_messages_stale`` this is not a<br/>
    ///   concurrent-writer race but an inconsistent request; fix the client<br/>
    ///   rather than retrying.<br/>
    /// - ``agent_session_already_compact``: there are no complete turns to<br/>
    ///   compact — either nothing new has finished since the transcript's latest<br/>
    ///   checkpoint, or a concurrent request's checkpoint already covers them.<br/>
    ///   Not retryable; the conversation is as compact as it can get.<br/>
    /// - ``agent_session_compaction_conflict``: the conversation changed while it<br/>
    ///   was being compacted; retry.
    /// </summary>
    public sealed partial class AgentSessionConflictError
    {
        /// <summary>
        /// Machine-readable reason the request conflicted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.AgentSessionConflictErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.AgentSessionConflictErrorCode Code { get; set; }

        /// <summary>
        /// Optional human-readable elaboration on the conflict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConflictError" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable reason the request conflicted.
        /// </param>
        /// <param name="message">
        /// Optional human-readable elaboration on the conflict.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionConflictError(
            global::Phoenix.AgentSessionConflictErrorCode code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionConflictError" /> class.
        /// </summary>
        public AgentSessionConflictError()
        {
        }

    }
}