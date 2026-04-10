#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Delete an annotation configuration
        /// </summary>
        /// <param name="configId">
        /// ID of the annotation configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.DeleteAnnotationConfigResponseBody> DeleteAnnotationConfigV1AnnotationConfigsConfigIdDeleteAsync(
            string configId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}