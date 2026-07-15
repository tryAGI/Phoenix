#nullable enable

namespace Phoenix
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete a system API key<br/>
        /// Permanently revoke a system API key. The key stops working immediately. Restricted to admins.
        /// </summary>
        /// <param name="apiKeyId">
        /// The GlobalID of the system API key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSystemApiKeyAsync(
            string apiKeyId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a system API key<br/>
        /// Permanently revoke a system API key. The key stops working immediately. Restricted to admins.
        /// </summary>
        /// <param name="apiKeyId">
        /// The GlobalID of the system API key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteSystemApiKeyAsResponseAsync(
            string apiKeyId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}