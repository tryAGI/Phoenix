
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The id of the last transcript message the client has rendered, used for optimistic concurrency. Omit when the session has no messages; required (and validated against the persisted transcript) once it does. On mismatch the server rejects the send with HTTP 409 and code ``agent_session_messages_stale`` — the client should refetch the session before retrying.
    /// </summary>
    public sealed partial class ChatRequestBodyLastMessageId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}