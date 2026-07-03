#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete a dataset label by ID<br/>
        /// Delete a dataset label. This also removes the label from every dataset it is applied to.
        /// </summary>
        /// <param name="labelId">
        /// The ID of the dataset label
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetLabelAsync(
            string labelId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a dataset label by ID<br/>
        /// Delete a dataset label. This also removes the label from every dataset it is applied to.
        /// </summary>
        /// <param name="labelId">
        /// The ID of the dataset label
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteDatasetLabelAsResponseAsync(
            string labelId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}