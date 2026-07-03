#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a dataset label by ID
        /// </summary>
        /// <param name="labelId">
        /// The ID of the dataset label
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetDatasetLabelResponseBody> GetDatasetLabelAsync(
            string labelId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a dataset label by ID
        /// </summary>
        /// <param name="labelId">
        /// The ID of the dataset label
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetDatasetLabelResponseBody>> GetDatasetLabelAsResponseAsync(
            string labelId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}