#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Compact Agent Session
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CompactAgentSessionResponseBody> CompactAgentSessionAsync(
            string sessionId,

            global::Phoenix.CompactAgentSessionRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compact Agent Session
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.CompactAgentSessionResponseBody>> CompactAgentSessionAsResponseAsync(
            string sessionId,

            global::Phoenix.CompactAgentSessionRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compact Agent Session
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="model">
        /// The model the client believes the session is set to. As on the chat route this is a precondition: the summary is generated with the session's persisted selection, and a mismatch is rejected with HTTP 409 and code ``agent_session_model_stale``.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CompactAgentSessionResponseBody> CompactAgentSessionAsync(
            string sessionId,
            global::Phoenix.AgentModelSelection model,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}