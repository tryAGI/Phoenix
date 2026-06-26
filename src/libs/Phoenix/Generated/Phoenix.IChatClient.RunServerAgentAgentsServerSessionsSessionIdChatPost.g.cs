#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Run Server Agent<br/>
        /// Stream a chat turn from the GraphQL server agent.<br/>
        /// This is the endpoint the PXI CLI talks to directly (no pre-configured<br/>
        /// agent record): it builds a fresh server agent per request from the<br/>
        /// caller-supplied model and contexts, then streams the reply back as<br/>
        /// Vercel-AI chunks.<br/>
        /// The request contexts gate capabilities — GraphQL mutations, web access,<br/>
        /// and subagents — and mutations are refused for viewer users. When trace<br/>
        /// recording is enabled (and permitted by system settings), the run is<br/>
        /// traced; locally ingested traces are persisted to the agent's project<br/>
        /// once the stream completes.<br/>
        /// Returns ``403`` if agents or the server agent are disabled, or if a<br/>
        /// viewer requests mutations.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RunServerAgentAgentsServerSessionsSessionIdChatPostAsync(
            string sessionId,

            global::Phoenix.ChatRequest request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Server Agent<br/>
        /// Stream a chat turn from the GraphQL server agent.<br/>
        /// This is the endpoint the PXI CLI talks to directly (no pre-configured<br/>
        /// agent record): it builds a fresh server agent per request from the<br/>
        /// caller-supplied model and contexts, then streams the reply back as<br/>
        /// Vercel-AI chunks.<br/>
        /// The request contexts gate capabilities — GraphQL mutations, web access,<br/>
        /// and subagents — and mutations are refused for viewer users. When trace<br/>
        /// recording is enabled (and permitted by system settings), the run is<br/>
        /// traced; locally ingested traces are persisted to the agent's project<br/>
        /// once the stream completes.<br/>
        /// Returns ``403`` if agents or the server agent are disabled, or if a<br/>
        /// viewer requests mutations.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<string>> RunServerAgentAgentsServerSessionsSessionIdChatPostAsResponseAsync(
            string sessionId,

            global::Phoenix.ChatRequest request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}