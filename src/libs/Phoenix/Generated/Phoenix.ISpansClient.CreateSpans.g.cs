#nullable enable

namespace Phoenix
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Create spans<br/>
        /// Submit spans to be inserted into a project. If any spans are invalid or duplicates, no spans will be inserted.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateSpansResponseBody> CreateSpansAsync(
            string projectIdentifier,

            global::Phoenix.CreateSpansRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create spans<br/>
        /// Submit spans to be inserted into a project. If any spans are invalid or duplicates, no spans will be inserted.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateSpansResponseBody> CreateSpansAsync(
            string projectIdentifier,
            global::System.Collections.Generic.IList<global::Phoenix.Span> data,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}