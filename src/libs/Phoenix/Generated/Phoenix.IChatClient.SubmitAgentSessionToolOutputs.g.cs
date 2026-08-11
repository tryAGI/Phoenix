#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Submit Agent Session Tool Outputs<br/>
        /// Persist resolved client tool outputs for the session's open turn.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SubmitAgentSessionToolOutputsResponseBody> SubmitAgentSessionToolOutputsAsync(
            string sessionId,

            global::Phoenix.SubmitAgentSessionToolOutputsRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Agent Session Tool Outputs<br/>
        /// Persist resolved client tool outputs for the session's open turn.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SubmitAgentSessionToolOutputsResponseBody>> SubmitAgentSessionToolOutputsAsResponseAsync(
            string sessionId,

            global::Phoenix.SubmitAgentSessionToolOutputsRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Agent Session Tool Outputs<br/>
        /// Persist resolved client tool outputs for the session's open turn.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="toolOutputs">
        /// Client tool results for pending calls on the trailing assistant message, matched by ``toolCallId``. Resending a persisted output verbatim is a no-op; an output that differs from the persisted result or matches no call is rejected with HTTP 409 and code ``agent_session_tool_outputs_conflict``.
        /// </param>
        /// <param name="lastMessageId">
        /// The trailing assistant message's id. On mismatch the submission is rejected with HTTP 409 and code ``agent_session_messages_stale``.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SubmitAgentSessionToolOutputsResponseBody> SubmitAgentSessionToolOutputsAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputErrorPart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputErrorPart>> toolOutputs,
            string lastMessageId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}