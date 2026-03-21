#nullable enable

namespace Phoenix
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Update an annotation configuration
        /// </summary>
        /// <param name="configId">
        /// ID of the annotation configuration
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateAnnotationConfigResponseBody> UpdateAnnotationConfigV1AnnotationConfigsConfigIdPutAsync(
            string configId,

            global::Phoenix.CreateAnnotationConfigData request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}