#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Submit Agent Session Tool Approvals<br/>
        /// Persist answered tool approvals for the session's open turn.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SubmitAgentSessionToolApprovalsResponseBody> SubmitAgentSessionToolApprovalsAsync(
            string sessionId,

            global::Phoenix.SubmitAgentSessionToolApprovalsRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Agent Session Tool Approvals<br/>
        /// Persist answered tool approvals for the session's open turn.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SubmitAgentSessionToolApprovalsResponseBody>> SubmitAgentSessionToolApprovalsAsResponseAsync(
            string sessionId,

            global::Phoenix.SubmitAgentSessionToolApprovalsRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Agent Session Tool Approvals<br/>
        /// Persist answered tool approvals for the session's open turn.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="toolApprovals">
        /// Answers to tool calls awaiting approval on the trailing assistant message, matched by ``toolCallId``. Resending a persisted answer is a no-op; an answer that reverses one, or that matches no call awaiting approval, is rejected with HTTP 409 and code ``agent_session_tool_approvals_conflict``.
        /// </param>
        /// <param name="lastMessageId">
        /// The trailing assistant message's id. On mismatch the submission is rejected with HTTP 409 and code ``agent_session_messages_stale``.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SubmitAgentSessionToolApprovalsResponseBody> SubmitAgentSessionToolApprovalsAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::Phoenix.ToolApproval> toolApprovals,
            string lastMessageId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}