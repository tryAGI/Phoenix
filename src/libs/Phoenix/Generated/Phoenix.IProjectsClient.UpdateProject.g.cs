#nullable enable

namespace Phoenix
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update a project by ID or name<br/>
        /// Update an existing project with new configuration. Project names cannot be changed. The project identifier is either project ID or project name. Note: When using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateProjectResponseBody> UpdateProjectAsync(
            string projectIdentifier,

            global::Phoenix.UpdateProjectRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project by ID or name<br/>
        /// Update an existing project with new configuration. Project names cannot be changed. The project identifier is either project ID or project name. Note: When using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateProjectResponseBody> UpdateProjectAsync(
            string projectIdentifier,
            string? description = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}