#nullable enable

namespace Phoenix
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Create a session note<br/>
        /// Add a note annotation to a session. Notes are special annotations that allow multiple entries per session (unlike regular annotations which are unique by name and identifier). Each note gets a unique UUIDv4 identifier.
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
        /// Add a note annotation to a session. Notes are special annotations that allow multiple entries per session (unlike regular annotations which are unique by name and identifier). Each note gets a unique UUIDv4 identifier.
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