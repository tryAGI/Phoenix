#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Permanently delete examples from a dataset<br/>
        /// Permanently delete examples and all of their revisions from every version of the dataset. The experiment runs on these examples, their evaluations, their task and evaluator traces, and their experiment logs are deleted too. The dataset, its versions, its experiments, and its other examples are kept. This cannot be undone. Example IDs that are not in the dataset are skipped, so a repeated request succeeds. Wait for experiments on the dataset to finish first, because runs and traces that arrive after the request are kept.
        /// </summary>
        /// <param name="id">
        /// The ID of the dataset
        /// </param>
        /// <param name="exampleIds">
        /// Identifiers of the examples to delete: dataset example IDs (GlobalIDs) or user-provided IDs. To delete more examples, send more requests.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetExamplesAsync(
            string id,
            global::System.Collections.Generic.IList<string> exampleIds,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently delete examples from a dataset<br/>
        /// Permanently delete examples and all of their revisions from every version of the dataset. The experiment runs on these examples, their evaluations, their task and evaluator traces, and their experiment logs are deleted too. The dataset, its versions, its experiments, and its other examples are kept. This cannot be undone. Example IDs that are not in the dataset are skipped, so a repeated request succeeds. Wait for experiments on the dataset to finish first, because runs and traces that arrive after the request are kept.
        /// </summary>
        /// <param name="id">
        /// The ID of the dataset
        /// </param>
        /// <param name="exampleIds">
        /// Identifiers of the examples to delete: dataset example IDs (GlobalIDs) or user-provided IDs. To delete more examples, send more requests.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteDatasetExamplesAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string> exampleIds,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}