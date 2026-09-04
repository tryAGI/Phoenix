#nullable enable

namespace Phoenix
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// List traces for a project
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="startTime">
        /// Inclusive lower bound on trace start time (ISO 8601)
        /// </param>
        /// <param name="endTime">
        /// Exclusive upper bound on trace start time (ISO 8601)
        /// </param>
        /// <param name="sort">
        /// Sort field<br/>
        /// Default Value: start_time
        /// </param>
        /// <param name="order">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit">
        /// Maximum number of traces to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor returned by a previous request
        /// </param>
        /// <param name="includeSpans">
        /// If true, include full span details for each trace. This significantly increases response size and query latency, especially with large page sizes. Prefer fetching spans lazily for individual traces when possible.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sessionIdentifier">
        /// List of session identifiers to filter traces by. Each value can be either a session_id string or a session GlobalID. Only traces belonging to the specified sessions will be returned.
        /// </param>
        /// <param name="error">
        /// Filter by trace error status. If true, only return traces that contain at least one span with `status_code == ERROR`. If false, only return traces with no errored spans. If omitted, traces are not filtered by error status. Matches the error indicator shown in the UI.
        /// </param>
        /// <param name="minLatencyMs">
        /// Inclusive lower bound on trace latency in milliseconds.
        /// </param>
        /// <param name="maxLatencyMs">
        /// Inclusive upper bound on trace latency in milliseconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetTracesResponseBody> ListProjectTracesAsync(
            string projectIdentifier,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Phoenix.ListProjectTracesSort? sort = default,
            global::Phoenix.ListProjectTracesOrder? order = default,
            int? limit = default,
            string? cursor = default,
            bool? includeSpans = default,
            global::System.Collections.Generic.IList<string>? sessionIdentifier = default,
            bool? error = default,
            double? minLatencyMs = default,
            double? maxLatencyMs = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List traces for a project
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="startTime">
        /// Inclusive lower bound on trace start time (ISO 8601)
        /// </param>
        /// <param name="endTime">
        /// Exclusive upper bound on trace start time (ISO 8601)
        /// </param>
        /// <param name="sort">
        /// Sort field<br/>
        /// Default Value: start_time
        /// </param>
        /// <param name="order">
        /// Sort direction<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="limit">
        /// Maximum number of traces to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor returned by a previous request
        /// </param>
        /// <param name="includeSpans">
        /// If true, include full span details for each trace. This significantly increases response size and query latency, especially with large page sizes. Prefer fetching spans lazily for individual traces when possible.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sessionIdentifier">
        /// List of session identifiers to filter traces by. Each value can be either a session_id string or a session GlobalID. Only traces belonging to the specified sessions will be returned.
        /// </param>
        /// <param name="error">
        /// Filter by trace error status. If true, only return traces that contain at least one span with `status_code == ERROR`. If false, only return traces with no errored spans. If omitted, traces are not filtered by error status. Matches the error indicator shown in the UI.
        /// </param>
        /// <param name="minLatencyMs">
        /// Inclusive lower bound on trace latency in milliseconds.
        /// </param>
        /// <param name="maxLatencyMs">
        /// Inclusive upper bound on trace latency in milliseconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetTracesResponseBody>> ListProjectTracesAsResponseAsync(
            string projectIdentifier,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Phoenix.ListProjectTracesSort? sort = default,
            global::Phoenix.ListProjectTracesOrder? order = default,
            int? limit = default,
            string? cursor = default,
            bool? includeSpans = default,
            global::System.Collections.Generic.IList<string>? sessionIdentifier = default,
            bool? error = default,
            double? minLatencyMs = default,
            double? maxLatencyMs = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}