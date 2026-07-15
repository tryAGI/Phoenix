#nullable enable

namespace Phoenix
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete a user API key<br/>
        /// Permanently revoke a user API key. Users can revoke their own keys, and admins can revoke keys belonging to other users. The key stops working immediately.
        /// </summary>
        /// <param name="apiKeyId">
        /// The GlobalID of the API key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteUserApiKeyAsync(
            string apiKeyId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a user API key<br/>
        /// Permanently revoke a user API key. Users can revoke their own keys, and admins can revoke keys belonging to other users. The key stops working immediately.
        /// </summary>
        /// <param name="apiKeyId">
        /// The GlobalID of the API key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteUserApiKeyAsResponseAsync(
            string apiKeyId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}