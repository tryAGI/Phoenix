#nullable enable

namespace Phoenix
{
    public partial interface ISecretsClient
    {
        /// <summary>
        /// Upsert or delete secrets<br/>
        /// Atomically upsert or delete a batch of secrets. Entries with a non-null `value` are created or updated; entries with `value: null` are deleted. The `value` field is required for every entry, and omitting it returns 422. When the same key appears more than once, the last occurrence wins. Deleting a non-existent key succeeds silently. Secret values are never returned in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ResponseBodyUpsertOrDeleteSecretsResult> UpsertOrDeleteSecretsAsync(

            global::Phoenix.UpsertOrDeleteSecretsRequest request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert or delete secrets<br/>
        /// Atomically upsert or delete a batch of secrets. Entries with a non-null `value` are created or updated; entries with `value: null` are deleted. The `value` field is required for every entry, and omitting it returns 422. When the same key appears more than once, the last occurrence wins. Deleting a non-existent key succeeds silently. Secret values are never returned in the response.
        /// </summary>
        /// <param name="secrets"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ResponseBodyUpsertOrDeleteSecretsResult> UpsertOrDeleteSecretsAsync(
            global::System.Collections.Generic.IList<global::Phoenix.SecretKeyValue> secrets,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}