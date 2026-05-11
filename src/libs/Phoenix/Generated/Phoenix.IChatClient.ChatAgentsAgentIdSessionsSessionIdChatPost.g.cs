#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Chat
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
        global::System.Threading.Tasks.Task<global::Phoenix.AssistantMessageMetadata> ChatAgentsAgentIdSessionsSessionIdChatPostAsync(
            string agentId,
            string sessionId,
            global::Phoenix.ChatAgentsAgentIdSessionsSessionIdChatPostProviderType providerType,
            string modelName,

            global::Phoenix.ChatRequest request,
            string? providerId = default,
            global::Phoenix.ModelProvider? provider = default,
            global::Phoenix.ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType? openaiApiType = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat
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
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.AssistantMessageMetadata>> ChatAgentsAgentIdSessionsSessionIdChatPostAsResponseAsync(
            string agentId,
            string sessionId,
            global::Phoenix.ChatAgentsAgentIdSessionsSessionIdChatPostProviderType providerType,
            string modelName,

            global::Phoenix.ChatRequest request,
            string? providerId = default,
            global::Phoenix.ModelProvider? provider = default,
            global::Phoenix.ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType? openaiApiType = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}