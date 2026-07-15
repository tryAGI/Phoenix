#nullable enable

namespace Phoenix
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// List the authenticated user's API keys<br/>
        /// Retrieve the API keys belonging to the currently authenticated user. The keys themselves are not recoverable and are never included in the response.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetApiKeysResponseBody> GetUserApiKeysAsync(
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the authenticated user's API keys<br/>
        /// Retrieve the API keys belonging to the currently authenticated user. The keys themselves are not recoverable and are never included in the response.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetApiKeysResponseBody>> GetUserApiKeysAsResponseAsync(
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}