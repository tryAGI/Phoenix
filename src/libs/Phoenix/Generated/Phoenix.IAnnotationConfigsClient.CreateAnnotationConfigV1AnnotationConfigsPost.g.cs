#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationConfigsClient
    {

        /// <summary>
        /// Create an annotation configuration
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateAnnotationConfigResponseBody> CreateAnnotationConfigV1AnnotationConfigsPostAsync(

            global::Phoenix.CreateAnnotationConfigData request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an annotation configuration
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateAnnotationConfigResponseBody> CreateAnnotationConfigV1AnnotationConfigsPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}