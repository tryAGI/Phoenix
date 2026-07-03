#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Unassign an annotation configuration from a project<br/>
        /// Unassign an annotation configuration from a project. This operation is idempotent: unassigning a config that is not currently assigned is a no-op. The underlying annotation config is not deleted. Both the project and the config are identified by either ID or name.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="configIdentifier">
        /// The annotation configuration identifier: either ID or name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task UnassignAnnotationConfigFromProjectAsync(
            string projectIdentifier,
            string configIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign an annotation configuration from a project<br/>
        /// Unassign an annotation configuration from a project. This operation is idempotent: unassigning a config that is not currently assigned is a no-op. The underlying annotation config is not deleted. Both the project and the config are identified by either ID or name.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="configIdentifier">
        /// The annotation configuration identifier: either ID or name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> UnassignAnnotationConfigFromProjectAsResponseAsync(
            string projectIdentifier,
            string configIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}