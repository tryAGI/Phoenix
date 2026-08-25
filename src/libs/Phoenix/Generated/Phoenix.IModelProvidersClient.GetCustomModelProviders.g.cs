#nullable enable

namespace Phoenix
{
    public partial interface IModelProvidersClient
    {
        /// <summary>
        /// List custom model providers<br/>
        /// Retrieve a paginated list of user-defined custom model providers. Encrypted provider credentials are never returned. Built-in provider families are listed separately by `GET /v1/model_providers`.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (custom provider ID)
        /// </param>
        /// <param name="limit">
        /// The max number of custom providers to return at a time (at most 1000).<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetCustomModelProvidersResponseBody> GetCustomModelProvidersAsync(
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List custom model providers<br/>
        /// Retrieve a paginated list of user-defined custom model providers. Encrypted provider credentials are never returned. Built-in provider families are listed separately by `GET /v1/model_providers`.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (custom provider ID)
        /// </param>
        /// <param name="limit">
        /// The max number of custom providers to return at a time (at most 1000).<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetCustomModelProvidersResponseBody>> GetCustomModelProvidersAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}