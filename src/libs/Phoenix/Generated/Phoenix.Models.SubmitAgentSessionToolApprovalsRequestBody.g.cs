
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Persist answered tool approvals without continuing the turn.
    /// </summary>
    public sealed partial class SubmitAgentSessionToolApprovalsRequestBody
    {
        /// <summary>
        /// Answers to tool calls awaiting approval on the trailing assistant message, matched by ``toolCallId``. Resending a persisted answer is a no-op; an answer that reverses one, or that matches no call awaiting approval, is rejected with HTTP 409 and code ``agent_session_tool_approvals_conflict``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolApprovals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Phoenix.ToolApproval> ToolApprovals { get; set; }

        /// <summary>
        /// The trailing assistant message's id. On mismatch the submission is rejected with HTTP 409 and code ``agent_session_messages_stale``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastMessageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastMessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAgentSessionToolApprovalsRequestBody" /> class.
        /// </summary>
        /// <param name="toolApprovals">
        /// Answers to tool calls awaiting approval on the trailing assistant message, matched by ``toolCallId``. Resending a persisted answer is a no-op; an answer that reverses one, or that matches no call awaiting approval, is rejected with HTTP 409 and code ``agent_session_tool_approvals_conflict``.
        /// </param>
        /// <param name="lastMessageId">
        /// The trailing assistant message's id. On mismatch the submission is rejected with HTTP 409 and code ``agent_session_messages_stale``.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitAgentSessionToolApprovalsRequestBody(
            global::System.Collections.Generic.IList<global::Phoenix.ToolApproval> toolApprovals,
            string lastMessageId)
        {
            this.ToolApprovals = toolApprovals ?? throw new global::System.ArgumentNullException(nameof(toolApprovals));
            this.LastMessageId = lastMessageId ?? throw new global::System.ArgumentNullException(nameof(lastMessageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAgentSessionToolApprovalsRequestBody" /> class.
        /// </summary>
        public SubmitAgentSessionToolApprovalsRequestBody()
        {
        }

    }
}