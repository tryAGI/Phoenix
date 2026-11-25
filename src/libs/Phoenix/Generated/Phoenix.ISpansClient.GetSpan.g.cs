#nullable enable

namespace Phoenix
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Get a single span by span_identifier<br/>
        /// Fetch a single span by identifier. The identifier may be either a Global ID or an OpenTelemetry span_id. Returns the span in the same shape as the elements of the list-spans endpoint.
        /// </summary>
        /// <param name="spanIdentifier">
        /// The span identifier: either a Global ID or OpenTelemetry span_id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetSpanResponseBody> GetSpanAsync(
            string spanIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a single span by span_identifier<br/>
        /// Fetch a single span by identifier. The identifier may be either a Global ID or an OpenTelemetry span_id. Returns the span in the same shape as the elements of the list-spans endpoint.
        /// </summary>
        /// <param name="spanIdentifier">
        /// The span identifier: either a Global ID or OpenTelemetry span_id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetSpanResponseBody>> GetSpanAsResponseAsync(
            string spanIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}