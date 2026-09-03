#nullable enable

namespace Phoenix
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete traces from a project<br/>
        /// Delete traces from a project without deleting the project or its configuration. Only traces whose start time is within the required `[start_time, end_time)` interval are deleted. Associated spans are cascade deleted, and project sessions left with no remaining traces are also deleted. Naive datetimes are interpreted as UTC.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="startTime">
        /// Required inclusive lower bound on trace start time (ISO 8601).
        /// </param>
        /// <param name="endTime">
        /// Required exclusive upper bound on trace start time (ISO 8601).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteProjectTracesAsync(
            string projectIdentifier,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete traces from a project<br/>
        /// Delete traces from a project without deleting the project or its configuration. Only traces whose start time is within the required `[start_time, end_time)` interval are deleted. Associated spans are cascade deleted, and project sessions left with no remaining traces are also deleted. Naive datetimes are interpreted as UTC.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="startTime">
        /// Required inclusive lower bound on trace start time (ISO 8601).
        /// </param>
        /// <param name="endTime">
        /// Required exclusive upper bound on trace start time (ISO 8601).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteProjectTracesAsResponseAsync(
            string projectIdentifier,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}