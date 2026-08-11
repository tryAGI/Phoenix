
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Request a model-generated checkpoint for a persisted conversation.
    /// </summary>
    public sealed partial class CompactAgentSessionRequestBody
    {
        /// <summary>
        /// The model the client believes the session is set to. As on the chat route this is a precondition: the summary is generated with the session's persisted selection, and a mismatch is rejected with HTTP 409 and code ``agent_session_model_stale``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.AgentModelSelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.AgentModelSelection Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactAgentSessionRequestBody" /> class.
        /// </summary>
        /// <param name="model">
        /// The model the client believes the session is set to. As on the chat route this is a precondition: the summary is generated with the session's persisted selection, and a mismatch is rejected with HTTP 409 and code ``agent_session_model_stale``.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactAgentSessionRequestBody(
            global::Phoenix.AgentModelSelection model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactAgentSessionRequestBody" /> class.
        /// </summary>
        public CompactAgentSessionRequestBody()
        {
        }

    }
}