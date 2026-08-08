#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete a dataset split
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either dataset ID or dataset name.
        /// </param>
        /// <param name="splitId">
        /// The ID (GlobalID) of the dataset split.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetSplitAsync(
            string datasetIdentifier,
            string splitId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a dataset split
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either dataset ID or dataset name.
        /// </param>
        /// <param name="splitId">
        /// The ID (GlobalID) of the dataset split.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteDatasetSplitAsResponseAsync(
            string datasetIdentifier,
            string splitId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}