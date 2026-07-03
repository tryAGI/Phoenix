#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Apply a label to a dataset<br/>
        /// Apply an existing label to a dataset. This operation is idempotent: applying a label that is already applied is a no-op that returns the label.
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="labelId">
        /// The ID of the dataset label to apply
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AddDatasetLabelToDatasetResponseBody> AddDatasetLabelToDatasetAsync(
            string datasetIdentifier,
            string labelId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply a label to a dataset<br/>
        /// Apply an existing label to a dataset. This operation is idempotent: applying a label that is already applied is a no-op that returns the label.
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="labelId">
        /// The ID of the dataset label to apply
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.AddDatasetLabelToDatasetResponseBody>> AddDatasetLabelToDatasetAsResponseAsync(
            string datasetIdentifier,
            string labelId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}