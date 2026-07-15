#nullable enable

namespace Phoenix
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create an API key for the authenticated user<br/>
        /// Create a personal API key for the currently authenticated user. The key inherits the user's role, so it grants no more access than the user already has. Creation requires an access-token session; API keys cannot mint replacement keys. The response contains the key itself, which is shown only once and cannot be retrieved afterwards.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateApiKeyResponseBody> CreateUserApiKeyAsync(

            global::Phoenix.CreateApiKeyRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an API key for the authenticated user<br/>
        /// Create a personal API key for the currently authenticated user. The key inherits the user's role, so it grants no more access than the user already has. Creation requires an access-token session; API keys cannot mint replacement keys. The response contains the key itself, which is shown only once and cannot be retrieved afterwards.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.CreateApiKeyResponseBody>> CreateUserApiKeyAsResponseAsync(

            global::Phoenix.CreateApiKeyRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an API key for the authenticated user<br/>
        /// Create a personal API key for the currently authenticated user. The key inherits the user's role, so it grants no more access than the user already has. Creation requires an access-token session; API keys cannot mint replacement keys. The response contains the key itself, which is shown only once and cannot be retrieved afterwards.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateApiKeyResponseBody> CreateUserApiKeyAsync(
            global::Phoenix.ApiKeyData data,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}