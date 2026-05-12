#nullable enable

namespace Phoenix
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Create a session note<br/>
        /// Add a note annotation to a session. By default each call appends a new note with an auto-generated UUIDv4 identifier, so multiple notes accumulate on the same session. Callers may supply a non-empty `identifier` to upsert on (session_id, name='note', identifier) — repeated calls with the same identifier overwrite the existing note, matching the semantics of structured annotations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateSessionNoteResponseBody> CreateSessionNoteAsync(

            global::Phoenix.CreateSessionNoteRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a session note<br/>
        /// Add a note annotation to a session. By default each call appends a new note with an auto-generated UUIDv4 identifier, so multiple notes accumulate on the same session. Callers may supply a non-empty `identifier` to upsert on (session_id, name='note', identifier) — repeated calls with the same identifier overwrite the existing note, matching the semantics of structured annotations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.CreateSessionNoteResponseBody>> CreateSessionNoteAsResponseAsync(

            global::Phoenix.CreateSessionNoteRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a session note<br/>
        /// Add a note annotation to a session. By default each call appends a new note with an auto-generated UUIDv4 identifier, so multiple notes accumulate on the same session. Callers may supply a non-empty `identifier` to upsert on (session_id, name='note', identifier) — repeated calls with the same identifier overwrite the existing note, matching the semantics of structured annotations.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateSessionNoteResponseBody> CreateSessionNoteAsync(
            global::Phoenix.SessionNoteData data,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}