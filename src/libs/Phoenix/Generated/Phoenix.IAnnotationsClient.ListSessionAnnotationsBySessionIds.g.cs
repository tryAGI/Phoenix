#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Get session annotations filtered by session_ids and/or identifier.<br/>
        /// Return session annotations for a project, filtered by `session_ids`, `identifier`, or both. At least one of `session_ids` or `identifier` must be supplied. When both are supplied, results are the AND-intersection of the two filters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="sessionIds">
        /// Optional list of session ids to fetch annotations for. If omitted, `identifier` must be supplied.
        /// </param>
        /// <param name="identifier">
        /// Optional list of annotation identifiers to filter by. Each value must be non-empty. If omitted, `session_ids` must be supplied. When combined with `session_ids`, results are the AND-intersection of both filters.
        /// </param>
        /// <param name="includeAnnotationNames">
        /// Optional list of annotation names to include. If provided, only annotations with these names will be returned. 'note' annotations are excluded by default unless explicitly included in this list.
        /// </param>
        /// <param name="excludeAnnotationNames">
        /// Optional list of annotation names to exclude from results.
        /// </param>
        /// <param name="cursor">
        /// A cursor for pagination
        /// </param>
        /// <param name="limit">
        /// The maximum number of annotations to return in a single request<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SessionAnnotationsResponseBody> ListSessionAnnotationsBySessionIdsAsync(
            string projectIdentifier,
            global::System.Collections.Generic.IList<string>? sessionIds = default,
            global::System.Collections.Generic.IList<string>? identifier = default,
            global::System.Collections.Generic.IList<string>? includeAnnotationNames = default,
            global::System.Collections.Generic.IList<string>? excludeAnnotationNames = default,
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get session annotations filtered by session_ids and/or identifier.<br/>
        /// Return session annotations for a project, filtered by `session_ids`, `identifier`, or both. At least one of `session_ids` or `identifier` must be supplied. When both are supplied, results are the AND-intersection of the two filters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="sessionIds">
        /// Optional list of session ids to fetch annotations for. If omitted, `identifier` must be supplied.
        /// </param>
        /// <param name="identifier">
        /// Optional list of annotation identifiers to filter by. Each value must be non-empty. If omitted, `session_ids` must be supplied. When combined with `session_ids`, results are the AND-intersection of both filters.
        /// </param>
        /// <param name="includeAnnotationNames">
        /// Optional list of annotation names to include. If provided, only annotations with these names will be returned. 'note' annotations are excluded by default unless explicitly included in this list.
        /// </param>
        /// <param name="excludeAnnotationNames">
        /// Optional list of annotation names to exclude from results.
        /// </param>
        /// <param name="cursor">
        /// A cursor for pagination
        /// </param>
        /// <param name="limit">
        /// The maximum number of annotations to return in a single request<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SessionAnnotationsResponseBody>> ListSessionAnnotationsBySessionIdsAsResponseAsync(
            string projectIdentifier,
            global::System.Collections.Generic.IList<string>? sessionIds = default,
            global::System.Collections.Generic.IList<string>? identifier = default,
            global::System.Collections.Generic.IList<string>? includeAnnotationNames = default,
            global::System.Collections.Generic.IList<string>? excludeAnnotationNames = default,
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}