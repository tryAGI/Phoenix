#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create a dataset split
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either dataset ID or dataset name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateDatasetSplitResponseBody> CreateDatasetSplitAsync(
            string datasetIdentifier,

            global::Phoenix.CreateDatasetSplitRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dataset split
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either dataset ID or dataset name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.CreateDatasetSplitResponseBody>> CreateDatasetSplitAsResponseAsync(
            string datasetIdentifier,

            global::Phoenix.CreateDatasetSplitRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a dataset split
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either dataset ID or dataset name.
        /// </param>
        /// <param name="name">
        /// A unique name for the split.
        /// </param>
        /// <param name="description">
        /// An optional description of the split.
        /// </param>
        /// <param name="color">
        /// An optional hex color for the split (e.g. #33c5e8). Omit for a default.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata for the split.
        /// </param>
        /// <param name="exampleIds">
        /// Optional dataset example IDs (GlobalIDs) to seed the split with. Each example must belong to this dataset. Omit to create an empty split.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateDatasetSplitResponseBody> CreateDatasetSplitAsync(
            string datasetIdentifier,
            string name,
            string? description = default,
            string? color = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? exampleIds = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}