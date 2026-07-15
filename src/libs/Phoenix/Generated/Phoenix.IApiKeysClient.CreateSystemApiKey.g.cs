#nullable enable

namespace Phoenix
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create a system API key<br/>
        /// Create a system API key. System keys belong to the system user rather than to any human, so this endpoint is restricted to admins. Creation requires an admin access-token session or the configured admin secret; API keys cannot mint keys. The response contains the key itself, which is shown only once and cannot be retrieved afterwards.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateApiKeyResponseBody> CreateSystemApiKeyAsync(

            global::Phoenix.CreateApiKeyRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a system API key<br/>
        /// Create a system API key. System keys belong to the system user rather than to any human, so this endpoint is restricted to admins. Creation requires an admin access-token session or the configured admin secret; API keys cannot mint keys. The response contains the key itself, which is shown only once and cannot be retrieved afterwards.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.CreateApiKeyResponseBody>> CreateSystemApiKeyAsResponseAsync(

            global::Phoenix.CreateApiKeyRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a system API key<br/>
        /// Create a system API key. System keys belong to the system user rather than to any human, so this endpoint is restricted to admins. Creation requires an admin access-token session or the configured admin secret; API keys cannot mint keys. The response contains the key itself, which is shown only once and cannot be retrieved afterwards.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateApiKeyResponseBody> CreateSystemApiKeyAsync(
            global::Phoenix.ApiKeyData data,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}