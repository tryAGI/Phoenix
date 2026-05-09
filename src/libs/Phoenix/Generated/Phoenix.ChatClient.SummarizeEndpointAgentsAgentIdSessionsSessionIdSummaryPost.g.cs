
#nullable enable

namespace Phoenix
{
    public partial class ChatClient
    {


        private static readonly global::Phoenix.EndPointSecurityRequirement s_SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostSecurityRequirement0 =
            new global::Phoenix.EndPointSecurityRequirement
            {
                Authorizations = new global::Phoenix.EndPointAuthorizationRequirement[]
                {                    new global::Phoenix.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Phoenix.EndPointSecurityRequirement[] s_SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostSecurityRequirements =
            new global::Phoenix.EndPointSecurityRequirement[]
            {                s_SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostSecurityRequirement0,
            };
        partial void PrepareSummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            ref string sessionId,
            ref global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType providerType,
            ref string modelName,
            ref string? providerId,
            global::Phoenix.ModelProvider? provider,
            ref global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? openaiApiType,
            global::Phoenix.SummarizeRequest request);
        partial void PrepareSummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            string sessionId,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType providerType,
            string modelName,
            string? providerId,
            global::Phoenix.ModelProvider? provider,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? openaiApiType,
            global::Phoenix.SummarizeRequest request);
        partial void ProcessSummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Summarize Endpoint
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="providerType"></param>
        /// <param name="modelName"></param>
        /// <param name="providerId"></param>
        /// <param name="provider"></param>
        /// <param name="openaiApiType">
        /// Default Value: responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Phoenix.SummarizeResponse> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync(
            string agentId,
            string sessionId,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType providerType,
            string modelName,

            global::Phoenix.SummarizeRequest request,
            string? providerId = default,
            global::Phoenix.ModelProvider? provider = default,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? openaiApiType = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsResponseAsync(
                agentId: agentId,
                sessionId: sessionId,
                providerType: providerType,
                modelName: modelName,

                request: request,
                providerId: providerId,
                provider: provider,
                openaiApiType: openaiApiType,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Summarize Endpoint
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="providerType"></param>
        /// <param name="modelName"></param>
        /// <param name="providerId"></param>
        /// <param name="provider"></param>
        /// <param name="openaiApiType">
        /// Default Value: responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SummarizeResponse>> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsResponseAsync(
            string agentId,
            string sessionId,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType providerType,
            string modelName,

            global::Phoenix.SummarizeRequest request,
            string? providerId = default,
            global::Phoenix.ModelProvider? provider = default,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? openaiApiType = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                sessionId: ref sessionId,
                providerType: ref providerType,
                modelName: ref modelName,
                providerId: ref providerId,
                provider: provider,
                openaiApiType: ref openaiApiType,
                request: request);


            var __authorizations = global::Phoenix.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostSecurityRequirements,
                operationName: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync");

            using var __timeoutCancellationTokenSource = global::Phoenix.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Phoenix.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Phoenix.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Phoenix.PathBuilder(
                                path: $"/agents/{agentId}/sessions/{sessionId}/summary",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("provider_type", providerType.ToValueString())
                                .AddRequiredParameter("model_name", modelName)
                                .AddOptionalParameter("provider_id", providerId)
                                .AddOptionalParameter("provider", provider?.ToString())
                                .AddOptionalParameter("openai_api_type", openaiApiType?.ToValueString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Phoenix.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Phoenix.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareSummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    agentId: agentId!,
                    sessionId: sessionId!,
                    providerType: providerType!,
                    modelName: modelName!,
                    providerId: providerId,
                    provider: provider,
                    openaiApiType: openaiApiType,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Phoenix.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Phoenix.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPost",
                                methodName: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync",
                                pathTemplate: "$\"/agents/{agentId}/sessions/{sessionId}/summary\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Phoenix.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Phoenix.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Phoenix.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPost",
                                methodName: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync",
                                pathTemplate: "$\"/agents/{agentId}/sessions/{sessionId}/summary\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Phoenix.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Phoenix.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Phoenix.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Phoenix.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Phoenix.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPost",
                                methodName: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync",
                                pathTemplate: "$\"/agents/{agentId}/sessions/{sessionId}/summary\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Phoenix.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessSummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Phoenix.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Phoenix.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPost",
                                methodName: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync",
                                pathTemplate: "$\"/agents/{agentId}/sessions/{sessionId}/summary\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Phoenix.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Phoenix.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPost",
                                methodName: "SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync",
                                pathTemplate: "$\"/agents/{agentId}/sessions/{sessionId}/summary\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Phoenix.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Phoenix.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Phoenix.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::Phoenix.ApiException<global::Phoenix.HTTPValidationError>(
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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessSummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Phoenix.SummarizeResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SummarizeResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Phoenix.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Phoenix.SummarizeResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SummarizeResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Phoenix.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Summarize Endpoint
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="sessionId"></param>
        /// <param name="providerType"></param>
        /// <param name="modelName"></param>
        /// <param name="providerId"></param>
        /// <param name="provider"></param>
        /// <param name="openaiApiType">
        /// Default Value: responses
        /// </param>
        /// <param name="messages"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Phoenix.SummarizeResponse> SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync(
            string agentId,
            string sessionId,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType providerType,
            string modelName,
            global::System.Collections.Generic.IList<global::Phoenix.UIMessage> messages,
            string? providerId = default,
            global::Phoenix.ModelProvider? provider = default,
            global::Phoenix.SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? openaiApiType = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Phoenix.SummarizeRequest
            {
                Messages = messages,
            };

            return await SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostAsync(
                agentId: agentId,
                sessionId: sessionId,
                providerType: providerType,
                modelName: modelName,
                providerId: providerId,
                provider: provider,
                openaiApiType: openaiApiType,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}