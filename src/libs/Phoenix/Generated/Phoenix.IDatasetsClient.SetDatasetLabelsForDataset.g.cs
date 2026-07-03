#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Replace the set of labels applied to a dataset<br/>
        /// Replace the entire set of labels applied to a dataset. Labels present in the request but not currently applied are added; labels currently applied but absent from the request are removed. An empty list removes all labels.
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SetDatasetLabelsForDatasetResponseBody> SetDatasetLabelsForDatasetAsync(
            string datasetIdentifier,

            global::Phoenix.SetDatasetLabelsRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the set of labels applied to a dataset<br/>
        /// Replace the entire set of labels applied to a dataset. Labels present in the request but not currently applied are added; labels currently applied but absent from the request are removed. An empty list removes all labels.
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SetDatasetLabelsForDatasetResponseBody>> SetDatasetLabelsForDatasetAsResponseAsync(
            string datasetIdentifier,

            global::Phoenix.SetDatasetLabelsRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the set of labels applied to a dataset<br/>
        /// Replace the entire set of labels applied to a dataset. Labels present in the request but not currently applied are added; labels currently applied but absent from the request are removed. An empty list removes all labels.
        /// </summary>
        /// <param name="datasetIdentifier">
        /// The dataset identifier: either the dataset ID (GlobalID) or its name.
        /// </param>
        /// <param name="datasetLabelIds">
        /// The complete set of dataset label GlobalIDs to apply to the dataset. Labels not in this list are removed from the dataset; an empty list removes all labels.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SetDatasetLabelsForDatasetResponseBody> SetDatasetLabelsForDatasetAsync(
            string datasetIdentifier,
            global::System.Collections.Generic.IList<string>? datasetLabelIds = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}