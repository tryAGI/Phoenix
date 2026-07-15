#nullable enable

namespace Phoenix
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// List system API keys<br/>
        /// Retrieve all system API keys. System keys belong to the system user rather than to any human, so this endpoint is restricted to admins. The keys themselves are not recoverable and are never included in the response.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetApiKeysResponseBody> GetSystemApiKeysAsync(
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List system API keys<br/>
        /// Retrieve all system API keys. System keys belong to the system user rather than to any human, so this endpoint is restricted to admins. The keys themselves are not recoverable and are never included in the response.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetApiKeysResponseBody>> GetSystemApiKeysAsResponseAsync(
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}