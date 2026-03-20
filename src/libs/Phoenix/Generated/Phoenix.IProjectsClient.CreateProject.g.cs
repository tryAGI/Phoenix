#nullable enable

namespace Phoenix
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a new project<br/>
        /// Create a new project with the specified configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateProjectResponseBody> CreateProjectAsync(

            global::Phoenix.CreateProjectRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new project<br/>
        /// Create a new project with the specified configuration.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateProjectResponseBody> CreateProjectAsync(
            string name,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}