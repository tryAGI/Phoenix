#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Assign an annotation configuration to a project<br/>
        /// Assign an annotation configuration to a project. This operation is idempotent: re-assigning a config that is already assigned is a no-op that returns the config. Both the project and the config are identified by either ID or name.
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
        global::System.Threading.Tasks.Task<global::Phoenix.AssignAnnotationConfigToProjectResponseBody> AssignAnnotationConfigToProjectAsync(
            string projectIdentifier,
            string configIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign an annotation configuration to a project<br/>
        /// Assign an annotation configuration to a project. This operation is idempotent: re-assigning a config that is already assigned is a no-op that returns the config. Both the project and the config are identified by either ID or name.
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
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.AssignAnnotationConfigToProjectResponseBody>> AssignAnnotationConfigToProjectAsResponseAsync(
            string projectIdentifier,
            string configIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}