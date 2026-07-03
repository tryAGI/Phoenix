#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List the labels applied to a dataset
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ListDatasetLabelsForDatasetResponseBody> ListDatasetLabelsForDatasetAsync(
            string datasetIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the labels applied to a dataset
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.ListDatasetLabelsForDatasetResponseBody>> ListDatasetLabelsForDatasetAsResponseAsync(
            string datasetIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}