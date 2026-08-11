#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// List Session Messages<br/>
        /// Page through an owned session's persisted transcript, oldest first.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cursor">
        /// Opaque pagination cursor.
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ListAgentSessionMessagesResponseBody> ListAgentSessionMessagesAsync(
            string sessionId,
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Session Messages<br/>
        /// Page through an owned session's persisted transcript, oldest first.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cursor">
        /// Opaque pagination cursor.
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.ListAgentSessionMessagesResponseBody>> ListAgentSessionMessagesAsResponseAsync(
            string sessionId,
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}