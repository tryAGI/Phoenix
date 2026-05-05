#nullable enable

namespace Phoenix
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Create a session note<br/>
        /// Add a note annotation to a session. Each call appends a new note with an auto-generated UUIDv4 identifier, so multiple notes accumulate on the same session. Structured annotations, by contrast, are keyed by (name, session_id, identifier) — re-writing the same key overwrites the existing annotation, so to keep multiple structured annotations with the same name on a session you must supply distinct identifiers.
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
        /// Add a note annotation to a session. Each call appends a new note with an auto-generated UUIDv4 identifier, so multiple notes accumulate on the same session. Structured annotations, by contrast, are keyed by (name, session_id, identifier) — re-writing the same key overwrites the existing annotation, so to keep multiple structured annotations with the same name on a session you must supply distinct identifiers.
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
        /// Add a note annotation to a session. Each call appends a new note with an auto-generated UUIDv4 identifier, so multiple notes accumulate on the same session. Structured annotations, by contrast, are keyed by (name, session_id, identifier) — re-writing the same key overwrites the existing annotation, so to keep multiple structured annotations with the same name on a session you must supply distinct identifiers.
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