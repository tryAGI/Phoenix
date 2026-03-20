#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {

        /// <summary>
        /// Upload dataset from JSON, JSONL, CSV, or PyArrow
        /// </summary>
        /// <param name="sync">
        /// If true, fulfill request synchronously and return JSON containing dataset_id.<br/>
        /// Default Value: false
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UploadDatasetResponseBody> UploadDatasetAsync(

            global::Phoenix.UploadDatasetRequest request,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload dataset from JSON, JSONL, CSV, or PyArrow
        /// </summary>
        /// <param name="sync">
        /// If true, fulfill request synchronously and return JSON containing dataset_id.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="action"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="metadata"></param>
        /// <param name="splits">
        /// Split per example: string, string array, or null
        /// </param>
        /// <param name="spanIds">
        /// Span IDs to link examples back to spans
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.UploadDatasetResponseBody> UploadDatasetAsync(
            string name,
            global::System.Collections.Generic.IList<object> inputs,
            bool? sync = default,
            global::Phoenix.UploadDatasetRequestAction? action = default,
            string? description = default,
            global::System.Collections.Generic.IList<object>? outputs = default,
            global::System.Collections.Generic.IList<object>? metadata = default,
            global::System.Collections.Generic.IList<global::Phoenix.OneOf<string, global::System.Collections.Generic.IList<string>, object>>? splits = default,
            global::System.Collections.Generic.IList<global::Phoenix.OneOf<string, object>>? spanIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}