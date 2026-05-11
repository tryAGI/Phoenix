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
        /// <param name="providerType"></param>
        /// <param name="modelName"></param>
        /// <param name="providerId"></param>
        /// <param name="provider"></param>
        /// <param name="openaiApiType">
        /// Default Value: responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SummarizeResponse> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync(
            string agentId,
            string sessionId,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType providerType,
            string modelName,

            global::Phoenix.SummarizeRequest request,
            string? providerId = default,
            global::Phoenix.ModelProvider? provider = default,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? openaiApiType = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize Endpoint
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="providerType"></param>
        /// <param name="modelName"></param>
        /// <param name="providerId"></param>
        /// <param name="provider"></param>
        /// <param name="openaiApiType">
        /// Default Value: responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SummarizeResponse>> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsResponseAsync(
            string agentId,
            string sessionId,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType providerType,
            string modelName,

            global::Phoenix.SummarizeRequest request,
            string? providerId = default,
            global::Phoenix.ModelProvider? provider = default,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? openaiApiType = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize Endpoint
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="providerType"></param>
        /// <param name="modelName"></param>
        /// <param name="providerId"></param>
        /// <param name="provider"></param>
        /// <param name="openaiApiType">
        /// Default Value: responses
        /// </param>
        /// <param name="ingestTraces">
        /// Default Value: false
        /// </param>
        /// <param name="exportRemoteTraces">
        /// Default Value: false
        /// </param>
        /// <param name="messages"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SummarizeResponse> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync(
            string agentId,
            string sessionId,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType providerType,
            string modelName,
            global::System.Collections.Generic.IList<global::Phoenix.UIMessage> messages,
            string? providerId = default,
            global::Phoenix.ModelProvider? provider = default,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? openaiApiType = default,
            bool? ingestTraces = default,
            bool? exportRemoteTraces = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}