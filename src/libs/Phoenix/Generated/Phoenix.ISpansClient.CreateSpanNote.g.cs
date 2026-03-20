#nullable enable

namespace Phoenix
{
    public partial interface ISpansClient
    {

        /// <summary>
        /// Create a span note<br/>
        /// Add a note annotation to a span. Notes are special annotations that allow multiple entries per span (unlike regular annotations which are unique by name and identifier). Each note gets a unique timestamp-based identifier.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateSpanNoteResponseBody> CreateSpanNoteAsync(

            global::Phoenix.CreateSpanNoteRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a span note<br/>
        /// Add a note annotation to a span. Notes are special annotations that allow multiple entries per span (unlike regular annotations which are unique by name and identifier). Each note gets a unique timestamp-based identifier.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateSpanNoteResponseBody> CreateSpanNoteAsync(
            global::Phoenix.SpanNoteData data,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}