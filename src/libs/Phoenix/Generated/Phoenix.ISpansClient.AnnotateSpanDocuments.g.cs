#nullable enable

namespace Phoenix
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Annotate Span Documents
        /// </summary>
        /// <param name="sync">
        /// If set to true, the annotations are inserted synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AnnotateSpanDocumentsResponseBody> AnnotateSpanDocumentsAsync(

            global::Phoenix.AnnotateSpanDocumentsRequestBody request,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotate Span Documents
        /// </summary>
        /// <param name="sync">
        /// If set to true, the annotations are inserted synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AnnotateSpanDocumentsResponseBody> AnnotateSpanDocumentsAsync(
            global::System.Collections.Generic.IList<global::Phoenix.SpanDocumentAnnotationData> data,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}