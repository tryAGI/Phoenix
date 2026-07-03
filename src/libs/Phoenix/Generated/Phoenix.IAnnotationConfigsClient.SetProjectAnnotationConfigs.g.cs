#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Replace the set of annotation configurations assigned to a project<br/>
        /// Replace the project's entire set of assigned annotation configurations with the provided set. The server diffs the desired set against the current set: configs in the body but not assigned are added, and configs assigned but not in the body are removed. An empty array clears all assignments.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SetProjectAnnotationConfigsResponseBody> SetProjectAnnotationConfigsAsync(
            string projectIdentifier,

            global::Phoenix.SetProjectAnnotationConfigsRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the set of annotation configurations assigned to a project<br/>
        /// Replace the project's entire set of assigned annotation configurations with the provided set. The server diffs the desired set against the current set: configs in the body but not assigned are added, and configs assigned but not in the body are removed. An empty array clears all assignments.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SetProjectAnnotationConfigsResponseBody>> SetProjectAnnotationConfigsAsResponseAsync(
            string projectIdentifier,

            global::Phoenix.SetProjectAnnotationConfigsRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the set of annotation configurations assigned to a project<br/>
        /// Replace the project's entire set of assigned annotation configurations with the provided set. The server diffs the desired set against the current set: configs in the body but not assigned are added, and configs assigned but not in the body are removed. An empty array clears all assignments.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="annotationConfigIds">
        /// The complete set of annotation configuration GlobalIDs that should be assigned to the project. Configs not in this list are unassigned; an empty list clears all assignments.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SetProjectAnnotationConfigsResponseBody> SetProjectAnnotationConfigsAsync(
            string projectIdentifier,
            global::System.Collections.Generic.IList<string> annotationConfigIds,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}