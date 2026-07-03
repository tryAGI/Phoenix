#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Remove a label from a dataset<br/>
        /// Remove a label from a dataset without deleting the label itself. This operation is idempotent: removing a label that is not applied is a no-op.
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="labelId">
        /// The ID of the dataset label to remove
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveDatasetLabelFromDatasetAsync(
            string datasetIdentifier,
            string labelId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a label from a dataset<br/>
        /// Remove a label from a dataset without deleting the label itself. This operation is idempotent: removing a label that is not applied is a no-op.
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="labelId">
        /// The ID of the dataset label to remove
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> RemoveDatasetLabelFromDatasetAsResponseAsync(
            string datasetIdentifier,
            string labelId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}