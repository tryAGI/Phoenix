#nullable enable

namespace Phoenix
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Create span annotations
        /// </summary>
        /// <param name="sync">
        /// If true, fulfill request synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AnnotateSpansResponseBody> AnnotateSpansAsync(

            global::Phoenix.AnnotateSpansRequestBody request,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create span annotations
        /// </summary>
        /// <param name="sync">
        /// If true, fulfill request synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AnnotateSpansResponseBody> AnnotateSpansAsync(
            global::System.Collections.Generic.IList<global::Phoenix.SpanAnnotationData> data,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}