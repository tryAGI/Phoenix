
#nullable enable

namespace Phoenix
{
    public partial class SecretsClient
    {
        partial void PrepareUpsertOrDeleteSecretsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Phoenix.UpsertOrDeleteSecretsRequest request);
        partial void PrepareUpsertOrDeleteSecretsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Phoenix.UpsertOrDeleteSecretsRequest request);
        partial void ProcessUpsertOrDeleteSecretsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpsertOrDeleteSecretsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upsert or delete secrets<br/>
        /// Atomically upsert or delete a batch of secrets. Entries with a non-null `value` are created or updated; entries with `value: null` are deleted. The `value` field is required for every entry, and omitting it returns 422. When the same key appears more than once, the last occurrence wins. Deleting a non-existent key succeeds silently. Secret values are never returned in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Phoenix.ResponseBodyUpsertOrDeleteSecretsResult> UpsertOrDeleteSecretsAsync(

            global::Phoenix.UpsertOrDeleteSecretsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpsertOrDeleteSecretsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Phoenix.PathBuilder(
                path: "/v1/secrets",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpsertOrDeleteSecretsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpsertOrDeleteSecretsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                string? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Phoenix.ApiException<string>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unprocessable Entity
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                string? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_422, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_422, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Phoenix.ApiException<string>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Insufficient Storage
            if ((int)__response.StatusCode == 507)
            {
                string? __content_507 = null;
                global::System.Exception? __exception_507 = null;
                string? __value_507 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_507 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_507 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_507, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_507 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_507 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_507, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_507 = __ex;
                }

                throw new global::Phoenix.ApiException<string>(
                    message: __content_507 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_507,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_507,
                    ResponseObject = __value_507,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpsertOrDeleteSecretsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Phoenix.ResponseBodyUpsertOrDeleteSecretsResult.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Phoenix.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Phoenix.ResponseBodyUpsertOrDeleteSecretsResult.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Phoenix.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Upsert or delete secrets<br/>
        /// Atomically upsert or delete a batch of secrets. Entries with a non-null `value` are created or updated; entries with `value: null` are deleted. The `value` field is required for every entry, and omitting it returns 422. When the same key appears more than once, the last occurrence wins. Deleting a non-existent key succeeds silently. Secret values are never returned in the response.
        /// </summary>
        /// <param name="secrets"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Phoenix.ResponseBodyUpsertOrDeleteSecretsResult> UpsertOrDeleteSecretsAsync(
            global::System.Collections.Generic.IList<global::Phoenix.SecretKeyValue> secrets,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Phoenix.UpsertOrDeleteSecretsRequest
            {
                Secrets = secrets,
            };

            return await UpsertOrDeleteSecretsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}