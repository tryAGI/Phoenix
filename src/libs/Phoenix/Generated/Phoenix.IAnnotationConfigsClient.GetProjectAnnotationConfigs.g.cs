#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// List annotation configurations assigned to a project<br/>
        /// Retrieve a paginated list of the annotation configurations assigned to a project, identified by either project ID or project name.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded annotation config ID)
        /// </param>
        /// <param name="limit">
        /// Maximum number of configs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetProjectAnnotationConfigsResponseBody> GetProjectAnnotationConfigsAsync(
            string projectIdentifier,
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List annotation configurations assigned to a project<br/>
        /// Retrieve a paginated list of the annotation configurations assigned to a project, identified by either project ID or project name.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded annotation config ID)
        /// </param>
        /// <param name="limit">
        /// Maximum number of configs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetProjectAnnotationConfigsResponseBody>> GetProjectAnnotationConfigsAsResponseAsync(
            string projectIdentifier,
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}