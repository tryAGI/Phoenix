
#nullable enable

namespace Phoenix
{
    public partial class PhoenixClient
    {


        private static readonly global::Phoenix.EndPointSecurityRequirement s_CreateTokensOauth2IdpNameTokensGetSecurityRequirement0 =
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
        private static readonly global::Phoenix.EndPointSecurityRequirement[] s_CreateTokensOauth2IdpNameTokensGetSecurityRequirements =
            new global::Phoenix.EndPointSecurityRequirement[]
            {                s_CreateTokensOauth2IdpNameTokensGetSecurityRequirement0,
            };
        partial void PrepareCreateTokensOauth2IdpNameTokensGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string idpName,
            ref string state,
            ref string? code,
            ref string? error,
            ref string? errorDescription,
            ref string phoenixOauth2State,
            ref string phoenixOauth2Nonce,
            ref string? phoenixOauth2CodeVerifier);
        partial void PrepareCreateTokensOauth2IdpNameTokensGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string idpName,
            string state,
            string? code,
            string? error,
            string? errorDescription,
            string phoenixOauth2State,
            string phoenixOauth2Nonce,
            string? phoenixOauth2CodeVerifier);
        partial void ProcessCreateTokensOauth2IdpNameTokensGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTokensOauth2IdpNameTokensGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Tokens
        /// </summary>
        /// <param name="idpName"></param>
        /// <param name="state"></param>
        /// <param name="code"></param>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
        /// <param name="phoenixOauth2State"></param>
        /// <param name="phoenixOauth2Nonce"></param>
        /// <param name="phoenixOauth2CodeVerifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> CreateTokensOauth2IdpNameTokensGetAsync(
            string idpName,
            string state,
            string phoenixOauth2State,
            string phoenixOauth2Nonce,
            string? code = default,
            string? error = default,
            string? errorDescription = default,
            string? phoenixOauth2CodeVerifier = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateTokensOauth2IdpNameTokensGetAsResponseAsync(
                idpName: idpName,
                state: state,
                phoenixOauth2State: phoenixOauth2State,
                phoenixOauth2Nonce: phoenixOauth2Nonce,
                code: code,
                error: error,
                errorDescription: errorDescription,
                phoenixOauth2CodeVerifier: phoenixOauth2CodeVerifier,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create Tokens
        /// </summary>
        /// <param name="idpName"></param>
        /// <param name="state"></param>
        /// <param name="code"></param>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
        /// <param name="phoenixOauth2State"></param>
        /// <param name="phoenixOauth2Nonce"></param>
        /// <param name="phoenixOauth2CodeVerifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<string>> CreateTokensOauth2IdpNameTokensGetAsResponseAsync(
            string idpName,
            string state,
            string phoenixOauth2State,
            string phoenixOauth2Nonce,
            string? code = default,
            string? error = default,
            string? errorDescription = default,
            string? phoenixOauth2CodeVerifier = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateTokensOauth2IdpNameTokensGetArguments(
                httpClient: HttpClient,
                idpName: ref idpName,
                state: ref state,
                code: ref code,
                error: ref error,
                errorDescription: ref errorDescription,
                phoenixOauth2State: ref phoenixOauth2State,
                phoenixOauth2Nonce: ref phoenixOauth2Nonce,
                phoenixOauth2CodeVerifier: ref phoenixOauth2CodeVerifier);


            var __authorizations = global::Phoenix.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTokensOauth2IdpNameTokensGetSecurityRequirements,
                operationName: "CreateTokensOauth2IdpNameTokensGetAsync");

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
                                path: $"/oauth2/{idpName}/tokens",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("state", state)
                                .AddOptionalParameter("code", code)
                                .AddOptionalParameter("error", error)
                                .AddOptionalParameter("error_description", errorDescription)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Phoenix.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                var __cookies = new global::System.Collections.Generic.List<string>();

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
                            var __phoenixOauth2State = phoenixOauth2State;
                            if (__phoenixOauth2State is not null)
                            {
                                __cookies.Add("phoenix-oauth2-state=" + (__phoenixOauth2State ?? string.Empty));
                            }
                            var __phoenixOauth2Nonce = phoenixOauth2Nonce;
                            if (__phoenixOauth2Nonce is not null)
                            {
                                __cookies.Add("phoenix-oauth2-nonce=" + (__phoenixOauth2Nonce ?? string.Empty));
                            }
                            var __phoenixOauth2CodeVerifier = phoenixOauth2CodeVerifier;
                            if (__phoenixOauth2CodeVerifier is not null)
                            {
                                __cookies.Add("phoenix-oauth2-code-verifier=" + (__phoenixOauth2CodeVerifier ?? string.Empty));
                            }

                if (__cookies.Count > 0)
                            {
                                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
                            }
                global::Phoenix.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTokensOauth2IdpNameTokensGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    idpName: idpName!,
                    state: state!,
                    code: code,
                    error: error,
                    errorDescription: errorDescription,
                    phoenixOauth2State: phoenixOauth2State!,
                    phoenixOauth2Nonce: phoenixOauth2Nonce!,
                    phoenixOauth2CodeVerifier: phoenixOauth2CodeVerifier);

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
                                operationId: "CreateTokensOauth2IdpNameTokensGet",
                                methodName: "CreateTokensOauth2IdpNameTokensGetAsync",
                                pathTemplate: "$\"/oauth2/{idpName}/tokens\"",
                                httpMethod: "GET",
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
                                operationId: "CreateTokensOauth2IdpNameTokensGet",
                                methodName: "CreateTokensOauth2IdpNameTokensGetAsync",
                                pathTemplate: "$\"/oauth2/{idpName}/tokens\"",
                                httpMethod: "GET",
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
                                operationId: "CreateTokensOauth2IdpNameTokensGet",
                                methodName: "CreateTokensOauth2IdpNameTokensGetAsync",
                                pathTemplate: "$\"/oauth2/{idpName}/tokens\"",
                                httpMethod: "GET",
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
                ProcessCreateTokensOauth2IdpNameTokensGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Phoenix.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Phoenix.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTokensOauth2IdpNameTokensGet",
                                methodName: "CreateTokensOauth2IdpNameTokensGetAsync",
                                pathTemplate: "$\"/oauth2/{idpName}/tokens\"",
                                httpMethod: "GET",
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
                                operationId: "CreateTokensOauth2IdpNameTokensGet",
                                methodName: "CreateTokensOauth2IdpNameTokensGetAsync",
                                pathTemplate: "$\"/oauth2/{idpName}/tokens\"",
                                httpMethod: "GET",
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


                                throw global::Phoenix.ApiException<global::Phoenix.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreateTokensOauth2IdpNameTokensGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::Phoenix.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Phoenix.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Phoenix.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::Phoenix.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Phoenix.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
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

                                    throw global::Phoenix.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}