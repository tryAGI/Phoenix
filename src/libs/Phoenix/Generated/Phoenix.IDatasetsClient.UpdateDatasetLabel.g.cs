#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update a dataset label by ID<br/>
        /// Partially update a dataset label's name, color, and/or description. Only the fields included in the request body are changed; omitted fields are left as-is.
        /// </summary>
        /// <param name="labelId">
        /// The ID of the dataset label
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateDatasetLabelResponseBody> UpdateDatasetLabelAsync(
            string labelId,

            global::Phoenix.UpdateDatasetLabelRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a dataset label by ID<br/>
        /// Partially update a dataset label's name, color, and/or description. Only the fields included in the request body are changed; omitted fields are left as-is.
        /// </summary>
        /// <param name="labelId">
        /// The ID of the dataset label
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.UpdateDatasetLabelResponseBody>> UpdateDatasetLabelAsResponseAsync(
            string labelId,

            global::Phoenix.UpdateDatasetLabelRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a dataset label by ID<br/>
        /// Partially update a dataset label's name, color, and/or description. Only the fields included in the request body are changed; omitted fields are left as-is.
        /// </summary>
        /// <param name="labelId">
        /// The ID of the dataset label
        /// </param>
        /// <param name="name">
        /// New name for the label (null is rejected; name is required)
        /// </param>
        /// <param name="color">
        /// New lowercase hex color code for the label (null is rejected)
        /// </param>
        /// <param name="description">
        /// New description for the label (null clears the description)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateDatasetLabelResponseBody> UpdateDatasetLabelAsync(
            string labelId,
            string? name = default,
            string? color = default,
            string? description = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}