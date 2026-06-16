#nullable enable

namespace Phoenix
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Update an experiment by ID<br/>
        /// Partially update an experiment's name, description, and/or metadata. Only the fields included in the request body are changed; omitted fields are left as-is. Patching an ephemeral experiment refreshes its last-update timestamp, which extends the window before it is swept away.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateExperimentResponseBody> UpdateExperimentAsync(
            string experimentId,

            global::Phoenix.UpdateExperimentRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an experiment by ID<br/>
        /// Partially update an experiment's name, description, and/or metadata. Only the fields included in the request body are changed; omitted fields are left as-is. Patching an ephemeral experiment refreshes its last-update timestamp, which extends the window before it is swept away.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.UpdateExperimentResponseBody>> UpdateExperimentAsResponseAsync(
            string experimentId,

            global::Phoenix.UpdateExperimentRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an experiment by ID<br/>
        /// Partially update an experiment's name, description, and/or metadata. Only the fields included in the request body are changed; omitted fields are left as-is. Patching an ephemeral experiment refreshes its last-update timestamp, which extends the window before it is swept away.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="name">
        /// New name for the experiment (null is rejected; name is required)
        /// </param>
        /// <param name="description">
        /// New description for the experiment (null clears the description)
        /// </param>
        /// <param name="metadata">
        /// New metadata object for the experiment (replaces the existing metadata as a whole; null is rejected)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UpdateExperimentResponseBody> UpdateExperimentAsync(
            string experimentId,
            string? name = default,
            string? description = default,
            object? metadata = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}