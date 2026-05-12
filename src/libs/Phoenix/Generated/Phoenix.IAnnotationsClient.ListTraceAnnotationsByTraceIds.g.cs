#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Get trace annotations filtered by trace_ids and/or identifier.<br/>
        /// Return trace annotations for a project, filtered by `trace_ids`, `identifier`, or both. At least one of `trace_ids` or `identifier` must be supplied. When both are supplied, results are the AND-intersection of the two filters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="traceIds">
        /// Optional list of trace ids to fetch annotations for. If omitted, `identifier` must be supplied.
        /// </param>
        /// <param name="identifier">
        /// Optional list of annotation identifiers to filter by. Each value must be non-empty. If omitted, `trace_ids` must be supplied. When combined with `trace_ids`, results are the AND-intersection of both filters.
        /// </param>
        /// <param name="includeAnnotationNames">
        /// Optional list of annotation names to include. If provided, only annotations with these names will be returned (allowlist). When omitted, the response includes every matching row regardless of name (no annotation names are excluded by default).
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
        global::System.Threading.Tasks.Task<global::Phoenix.TraceAnnotationsResponseBody> ListTraceAnnotationsByTraceIdsAsync(
            string projectIdentifier,
            global::System.Collections.Generic.IList<string>? traceIds = default,
            global::System.Collections.Generic.IList<string>? identifier = default,
            global::System.Collections.Generic.IList<string>? includeAnnotationNames = default,
            global::System.Collections.Generic.IList<string>? excludeAnnotationNames = default,
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get trace annotations filtered by trace_ids and/or identifier.<br/>
        /// Return trace annotations for a project, filtered by `trace_ids`, `identifier`, or both. At least one of `trace_ids` or `identifier` must be supplied. When both are supplied, results are the AND-intersection of the two filters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="traceIds">
        /// Optional list of trace ids to fetch annotations for. If omitted, `identifier` must be supplied.
        /// </param>
        /// <param name="identifier">
        /// Optional list of annotation identifiers to filter by. Each value must be non-empty. If omitted, `trace_ids` must be supplied. When combined with `trace_ids`, results are the AND-intersection of both filters.
        /// </param>
        /// <param name="includeAnnotationNames">
        /// Optional list of annotation names to include. If provided, only annotations with these names will be returned (allowlist). When omitted, the response includes every matching row regardless of name (no annotation names are excluded by default).
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
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.TraceAnnotationsResponseBody>> ListTraceAnnotationsByTraceIdsAsResponseAsync(
            string projectIdentifier,
            global::System.Collections.Generic.IList<string>? traceIds = default,
            global::System.Collections.Generic.IList<string>? identifier = default,
            global::System.Collections.Generic.IList<string>? includeAnnotationNames = default,
            global::System.Collections.Generic.IList<string>? excludeAnnotationNames = default,
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}