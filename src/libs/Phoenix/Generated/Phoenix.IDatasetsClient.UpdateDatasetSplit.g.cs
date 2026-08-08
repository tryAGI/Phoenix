#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update a dataset split
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either dataset ID or dataset name.
        /// </param>
        /// <param name="splitId">
        /// The ID (GlobalID) of the dataset split.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateDatasetSplitResponseBody> UpdateDatasetSplitAsync(
            string datasetIdentifier,
            string splitId,

            global::Phoenix.UpdateDatasetSplitRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a dataset split
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either dataset ID or dataset name.
        /// </param>
        /// <param name="splitId">
        /// The ID (GlobalID) of the dataset split.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.UpdateDatasetSplitResponseBody>> UpdateDatasetSplitAsResponseAsync(
            string datasetIdentifier,
            string splitId,

            global::Phoenix.UpdateDatasetSplitRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a dataset split
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either dataset ID or dataset name.
        /// </param>
        /// <param name="splitId">
        /// The ID (GlobalID) of the dataset split.
        /// </param>
        /// <param name="name">
        /// A new unique name for the split.
        /// </param>
        /// <param name="description">
        /// A new description, or null to clear it.
        /// </param>
        /// <param name="color">
        /// A new hex color for the split.
        /// </param>
        /// <param name="metadata">
        /// New JSON metadata that replaces the existing metadata.
        /// </param>
        /// <param name="addExampleIds">
        /// Dataset example IDs (GlobalIDs) to add to the split. Each example must belong to this dataset. Adding an example already in the split is a no-op.
        /// </param>
        /// <param name="removeExampleIds">
        /// Dataset example IDs (GlobalIDs) to remove from the split.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateDatasetSplitResponseBody> UpdateDatasetSplitAsync(
            string datasetIdentifier,
            string splitId,
            string? name = default,
            string? description = default,
            string? color = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? addExampleIds = default,
            global::System.Collections.Generic.IList<string>? removeExampleIds = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}