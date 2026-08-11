#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create Session<br/>
        /// Create a persisted agent session owned by the requesting user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateAgentSessionResponseBody> CreateAgentSessionAsync(

            global::Phoenix.CreateAgentSessionRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Session<br/>
        /// Create a persisted agent session owned by the requesting user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.CreateAgentSessionResponseBody>> CreateAgentSessionAsResponseAsync(

            global::Phoenix.CreateAgentSessionRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Session<br/>
        /// Create a persisted agent session owned by the requesting user.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="title">
        /// Optional initial title.
        /// </param>
        /// <param name="isEphemeral">
        /// Whether the session should expire after a period of inactivity.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateAgentSessionResponseBody> CreateAgentSessionAsync(
            global::Phoenix.AgentModelSelection model,
            string? title = default,
            bool? isEphemeral = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}