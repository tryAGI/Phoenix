#nullable enable

namespace Phoenix
{
    public partial interface IModelProvidersClient
    {
        /// <summary>
        /// List built-in model provider families<br/>
        /// Retrieve the built-in model provider families available to this deployment. Built-in families are a fixed enum rather than stored records, so this list is not paginated; it is narrowed by the PHOENIX_ALLOWED_PROVIDERS environment variable when that is set. User-defined providers are listed separately by `GET /v1/custom_model_providers`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetModelProvidersResponseBody> GetModelProvidersAsync(
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List built-in model provider families<br/>
        /// Retrieve the built-in model provider families available to this deployment. Built-in families are a fixed enum rather than stored records, so this list is not paginated; it is narrowed by the PHOENIX_ALLOWED_PROVIDERS environment variable when that is set. User-defined providers are listed separately by `GET /v1/custom_model_providers`.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetModelProvidersResponseBody>> GetModelProvidersAsResponseAsync(
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}