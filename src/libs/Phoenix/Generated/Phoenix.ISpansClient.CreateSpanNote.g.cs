#nullable enable

namespace Phoenix
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Create a span note<br/>
        /// Add a note annotation to a span. Each call appends a new note with an auto-generated UUIDv4 identifier, so multiple notes accumulate on the same span. Structured annotations, by contrast, are keyed by (name, span_id, identifier) — re-writing the same key overwrites the existing annotation, so to keep multiple structured annotations with the same name on a span you must supply distinct identifiers.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateSpanNoteResponseBody> CreateSpanNoteAsync(

            global::Phoenix.CreateSpanNoteRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a span note<br/>
        /// Add a note annotation to a span. Each call appends a new note with an auto-generated UUIDv4 identifier, so multiple notes accumulate on the same span. Structured annotations, by contrast, are keyed by (name, span_id, identifier) — re-writing the same key overwrites the existing annotation, so to keep multiple structured annotations with the same name on a span you must supply distinct identifiers.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateSpanNoteResponseBody> CreateSpanNoteAsync(
            global::Phoenix.SpanNoteData data,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}