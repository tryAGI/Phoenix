#nullable enable

namespace Phoenix
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// List all user API keys<br/>
        /// Retrieve API keys belonging to human users across the organization. System API keys are excluded. Restricted to admins.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (a UserApiKey GlobalID).
        /// </param>
        /// <param name="limit">
        /// The maximum number of API keys to return (at most 1000).<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetAllUserApiKeysResponseBody> GetAllUserApiKeysAsync(
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all user API keys<br/>
        /// Retrieve API keys belonging to human users across the organization. System API keys are excluded. Restricted to admins.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (a UserApiKey GlobalID).
        /// </param>
        /// <param name="limit">
        /// The maximum number of API keys to return (at most 1000).<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetAllUserApiKeysResponseBody>> GetAllUserApiKeysAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}