#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Delete span annotations in a project that match the supplied filter.<br/>
        /// Hard-delete span annotations within the named project that match the<br/>
        /// supplied filter.<br/>
        /// - The request must either supply both `start_time` AND `end_time`<br/>
        ///   to bound the delete to a `[start_time, end_time)` time window,<br/>
        ///   OR set `delete_all=true` to acknowledge an unbounded sweep. A request<br/>
        ///   that satisfies neither is rejected with 422.<br/>
        /// - `name`, `identifier`, and `annotator_kind` are optional narrowing<br/>
        ///   filters; on their own they do NOT authorize the request — they only<br/>
        ///   narrow within an already-authorized request (bounded time range or<br/>
        ///   `delete_all=true`).<br/>
        /// - All supplied filters are combined with AND. `name` and `identifier`,<br/>
        ///   when present, must be non-empty.<br/>
        /// - `start_time` is inclusive (`&gt;=`); `end_time` is exclusive<br/>
        ///   (`&lt;`). When both are supplied, `start_time` must be strictly earlier<br/>
        ///   than `end_time` (else 422). A half-bounded range (only one of<br/>
        ///   the two) does NOT satisfy the gate and is rejected unless<br/>
        ///   `delete_all=true` is also set. Naive datetimes are interpreted as UTC.<br/>
        /// - The endpoint is idempotent: a request that matches no rows still<br/>
        ///   returns 204.<br/>
        /// - When authentication is enabled, non-admin callers can only delete rows<br/>
        ///   they own (`user_id == current_user.id`); admins delete all matching<br/>
        ///   rows.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="name">
        /// Optional annotation name. When provided, must be non-empty and narrows the delete to annotations of that name.
        /// </param>
        /// <param name="identifier">
        /// Optional annotation identifier. When provided, must be non-empty and narrows the delete to annotations with that identifier.
        /// </param>
        /// <param name="annotatorKind">
        /// Optional annotator kind. When provided, narrows the delete to annotations produced by this annotator kind.
        /// </param>
        /// <param name="startTime">
        /// Optional inclusive lower bound on `created_at` (&gt;=). Naive datetimes are interpreted as UTC.
        /// </param>
        /// <param name="endTime">
        /// Optional exclusive upper bound on `created_at` (&lt;). Naive datetimes are interpreted as UTC.
        /// </param>
        /// <param name="deleteAll">
        /// Opt-in flag that authorizes the request without a bounded `[start_time, end_time)` time window. When `false` (default) or absent, the request must supply both `start_time` AND `end_time` to bound the delete. When `true`, the time-range bound is waived and any other filters (`name`, `identifier`, `annotator_kind`) still narrow the delete within the project — e.g. `delete_all=true&amp;name=X` deletes all annotations named X regardless of time.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpanAnnotationsAsync(
            string projectIdentifier,
            string? name = default,
            string? identifier = default,
            global::Phoenix.DeleteSpanAnnotationsAnnotatorKind2? annotatorKind = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            bool? deleteAll = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete span annotations in a project that match the supplied filter.<br/>
        /// Hard-delete span annotations within the named project that match the<br/>
        /// supplied filter.<br/>
        /// - The request must either supply both `start_time` AND `end_time`<br/>
        ///   to bound the delete to a `[start_time, end_time)` time window,<br/>
        ///   OR set `delete_all=true` to acknowledge an unbounded sweep. A request<br/>
        ///   that satisfies neither is rejected with 422.<br/>
        /// - `name`, `identifier`, and `annotator_kind` are optional narrowing<br/>
        ///   filters; on their own they do NOT authorize the request — they only<br/>
        ///   narrow within an already-authorized request (bounded time range or<br/>
        ///   `delete_all=true`).<br/>
        /// - All supplied filters are combined with AND. `name` and `identifier`,<br/>
        ///   when present, must be non-empty.<br/>
        /// - `start_time` is inclusive (`&gt;=`); `end_time` is exclusive<br/>
        ///   (`&lt;`). When both are supplied, `start_time` must be strictly earlier<br/>
        ///   than `end_time` (else 422). A half-bounded range (only one of<br/>
        ///   the two) does NOT satisfy the gate and is rejected unless<br/>
        ///   `delete_all=true` is also set. Naive datetimes are interpreted as UTC.<br/>
        /// - The endpoint is idempotent: a request that matches no rows still<br/>
        ///   returns 204.<br/>
        /// - When authentication is enabled, non-admin callers can only delete rows<br/>
        ///   they own (`user_id == current_user.id`); admins delete all matching<br/>
        ///   rows.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="name">
        /// Optional annotation name. When provided, must be non-empty and narrows the delete to annotations of that name.
        /// </param>
        /// <param name="identifier">
        /// Optional annotation identifier. When provided, must be non-empty and narrows the delete to annotations with that identifier.
        /// </param>
        /// <param name="annotatorKind">
        /// Optional annotator kind. When provided, narrows the delete to annotations produced by this annotator kind.
        /// </param>
        /// <param name="startTime">
        /// Optional inclusive lower bound on `created_at` (&gt;=). Naive datetimes are interpreted as UTC.
        /// </param>
        /// <param name="endTime">
        /// Optional exclusive upper bound on `created_at` (&lt;). Naive datetimes are interpreted as UTC.
        /// </param>
        /// <param name="deleteAll">
        /// Opt-in flag that authorizes the request without a bounded `[start_time, end_time)` time window. When `false` (default) or absent, the request must supply both `start_time` AND `end_time` to bound the delete. When `true`, the time-range bound is waived and any other filters (`name`, `identifier`, `annotator_kind`) still narrow the delete within the project — e.g. `delete_all=true&amp;name=X` deletes all annotations named X regardless of time.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteSpanAnnotationsAsResponseAsync(
            string projectIdentifier,
            string? name = default,
            string? identifier = default,
            global::Phoenix.DeleteSpanAnnotationsAnnotatorKind2? annotatorKind = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            bool? deleteAll = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}