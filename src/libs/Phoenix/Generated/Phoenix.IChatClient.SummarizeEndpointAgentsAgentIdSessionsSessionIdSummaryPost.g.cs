#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Summarize Endpoint
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SummarizeResponse> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync(
            string agentId,
            string sessionId,

            global::Phoenix.SummarizeRequest request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize Endpoint
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SummarizeResponse>> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsResponseAsync(
            string agentId,
            string sessionId,

            global::Phoenix.SummarizeRequest request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize Endpoint
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
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
        /// <param name="messages"></param>
        /// <param name="model"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SummarizeResponse> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync(
            string agentId,
            string sessionId,
            global::System.Collections.Generic.IList<global::Phoenix.UIMessage> messages,
            global::Phoenix.Model3 model,
            bool? ingestTraces = default,
            bool? exportRemoteTraces = default,
            bool? attachUserId = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}