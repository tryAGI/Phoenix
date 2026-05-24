
#nullable enable

namespace Phoenix
{
    public partial class AnnotationsClient
    {


        private static readonly global::Phoenix.EndPointSecurityRequirement s_DeleteSessionAnnotationsSecurityRequirement0 =
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
        private static readonly global::Phoenix.EndPointSecurityRequirement[] s_DeleteSessionAnnotationsSecurityRequirements =
            new global::Phoenix.EndPointSecurityRequirement[]
            {                s_DeleteSessionAnnotationsSecurityRequirement0,
            };
        partial void PrepareDeleteSessionAnnotationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectIdentifier,
            ref string? name,
            ref string? identifier,
            global::Phoenix.DeleteSessionAnnotationsAnnotatorKind2? annotatorKind,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            ref bool? deleteAll);
        partial void PrepareDeleteSessionAnnotationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectIdentifier,
            string? name,
            string? identifier,
            global::Phoenix.DeleteSessionAnnotationsAnnotatorKind2? annotatorKind,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            bool? deleteAll);
        partial void ProcessDeleteSessionAnnotationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete session annotations in a project that match the supplied filter.<br/>
        /// Hard-delete session annotations within the named project that match the<br/>
        /// supplied filter.<br/>
        /// - The request must either supply both `start_time` AND `end_time`<br/>
        ///   to bound the delete to a `[start_time, end_time)` time window,<br/>
        ///   OR set `delete_all=true` to acknowledge an unbounded sweep. A request<br/>
        ///   that satisfies neither is rejected with 422.<br/>
        /// - `name`, `identifier`, and `annotator_kind` are optional narrowing<br/>
        ///   filters; on their own they do NOT authorize the request — they only<br/>
        ///   narrow within an already-authorized request (bounded time range or<br/>
        ///   `delete_all=true`).<br/>
        /// - All supplied filters are combined with AND. `name` and `identifier`,<br/>
        ///   when present, must be non-empty.<br/>
        /// - `start_time` is inclusive (`&gt;=`); `end_time` is exclusive<br/>
        ///   (`&lt;`). When both are supplied, `start_time` must be strictly earlier<br/>
        ///   than `end_time` (else 422). A half-bounded range (only one of<br/>
        ///   the two) does NOT satisfy the gate and is rejected unless<br/>
        ///   `delete_all=true` is also set. Naive datetimes are interpreted as UTC.<br/>
        /// - The endpoint is idempotent: a request that matches no rows still<br/>
        ///   returns 204.<br/>
        /// - When authentication is enabled, non-admin callers can only delete rows<br/>
        ///   they own (`user_id == current_user.id`); admins delete all matching<br/>
        ///   rows.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="name">
        /// Optional annotation name. When provided, must be non-empty and narrows the delete to annotations of that name.
        /// </param>
        /// <param name="identifier">
        /// Optional annotation identifier. When provided, must be non-empty and narrows the delete to annotations with that identifier.
        /// </param>
        /// <param name="annotatorKind">
        /// Optional annotator kind. When provided, narrows the delete to annotations produced by this annotator kind.
        /// </param>
        /// <param name="startTime">
        /// Optional inclusive lower bound on `created_at` (&gt;=). Naive datetimes are interpreted as UTC.
        /// </param>
        /// <param name="endTime">
        /// Optional exclusive upper bound on `created_at` (&lt;). Naive datetimes are interpreted as UTC.
        /// </param>
        /// <param name="deleteAll">
        /// Opt-in flag that authorizes the request without a bounded `[start_time, end_time)` time window. When `false` (default) or absent, the request must supply both `start_time` AND `end_time` to bound the delete. When `true`, the time-range bound is waived and any other filters (`name`, `identifier`, `annotator_kind`) still narrow the delete within the project — e.g. `delete_all=true&amp;name=X` deletes all annotations named X regardless of time.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        public async global::System.Threading.Tasks.Task DeleteSessionAnnotationsAsync(
            string projectIdentifier,
            string? name = default,
            string? identifier = default,
            global::Phoenix.DeleteSessionAnnotationsAnnotatorKind2? annotatorKind = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            bool? deleteAll = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await DeleteSessionAnnotationsAsResponseAsync(
                projectIdentifier: projectIdentifier,
                name: name,
                identifier: identifier,
                annotatorKind: annotatorKind,
                startTime: startTime,
                endTime: endTime,
                deleteAll: deleteAll,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete session annotations in a project that match the supplied filter.<br/>
        /// Hard-delete session annotations within the named project that match the<br/>
        /// supplied filter.<br/>
        /// - The request must either supply both `start_time` AND `end_time`<br/>
        ///   to bound the delete to a `[start_time, end_time)` time window,<br/>
        ///   OR set `delete_all=true` to acknowledge an unbounded sweep. A request<br/>
        ///   that satisfies neither is rejected with 422.<br/>
        /// - `name`, `identifier`, and `annotator_kind` are optional narrowing<br/>
        ///   filters; on their own they do NOT authorize the request — they only<br/>
        ///   narrow within an already-authorized request (bounded time range or<br/>
        ///   `delete_all=true`).<br/>
        /// - All supplied filters are combined with AND. `name` and `identifier`,<br/>
        ///   when present, must be non-empty.<br/>
        /// - `start_time` is inclusive (`&gt;=`); `end_time` is exclusive<br/>
        ///   (`&lt;`). When both are supplied, `start_time` must be strictly earlier<br/>
        ///   than `end_time` (else 422). A half-bounded range (only one of<br/>
        ///   the two) does NOT satisfy the gate and is rejected unless<br/>
        ///   `delete_all=true` is also set. Naive datetimes are interpreted as UTC.<br/>
        /// - The endpoint is idempotent: a request that matches no rows still<br/>
        ///   returns 204.<br/>
        /// - When authentication is enabled, non-admin callers can only delete rows<br/>
        ///   they own (`user_id == current_user.id`); admins delete all matching<br/>
        ///   rows.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="name">
        /// Optional annotation name. When provided, must be non-empty and narrows the delete to annotations of that name.
        /// </param>
        /// <param name="identifier">
        /// Optional annotation identifier. When provided, must be non-empty and narrows the delete to annotations with that identifier.
        /// </param>
        /// <param name="annotatorKind">
        /// Optional annotator kind. When provided, narrows the delete to annotations produced by this annotator kind.
        /// </param>
        /// <param name="startTime">
        /// Optional inclusive lower bound on `created_at` (&gt;=). Naive datetimes are interpreted as UTC.
        /// </param>
        /// <param name="endTime">
        /// Optional exclusive upper bound on `created_at` (&lt;). Naive datetimes are interpreted as UTC.
        /// </param>
        /// <param name="deleteAll">
        /// Opt-in flag that authorizes the request without a bounded `[start_time, end_time)` time window. When `false` (default) or absent, the request must supply both `start_time` AND `end_time` to bound the delete. When `true`, the time-range bound is waived and any other filters (`name`, `identifier`, `annotator_kind`) still narrow the delete within the project — e.g. `delete_all=true&amp;name=X` deletes all annotations named X regardless of time.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteSessionAnnotationsAsResponseAsync(
            string projectIdentifier,
            string? name = default,
            string? identifier = default,
            global::Phoenix.DeleteSessionAnnotationsAnnotatorKind2? annotatorKind = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            bool? deleteAll = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDeleteSessionAnnotationsArguments(
                httpClient: HttpClient,
                projectIdentifier: ref projectIdentifier,
                name: ref name,
                identifier: ref identifier,
                annotatorKind: annotatorKind,
                startTime: startTime,
                endTime: endTime,
                deleteAll: ref deleteAll);


            var __authorizations = global::Phoenix.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DeleteSessionAnnotationsSecurityRequirements,
                operationName: "DeleteSessionAnnotationsAsync");

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
                                path: $"/v1/projects/{projectIdentifier}/session_annotations",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("identifier", identifier)
                                .AddOptionalParameter("annotator_kind", annotatorKind?.ToString())
                                .AddOptionalParameter("start_time", startTime?.ToString())
                                .AddOptionalParameter("end_time", endTime?.ToString())
                                .AddOptionalParameter("delete_all", deleteAll?.ToString().ToLowerInvariant())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Phoenix.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Delete,
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
                global::Phoenix.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareDeleteSessionAnnotationsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    projectIdentifier: projectIdentifier!,
                    name: name,
                    identifier: identifier,
                    annotatorKind: annotatorKind,
                    startTime: startTime,
                    endTime: endTime,
                    deleteAll: deleteAll);

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
                                operationId: "DeleteSessionAnnotations",
                                methodName: "DeleteSessionAnnotationsAsync",
                                pathTemplate: "$\"/v1/projects/{projectIdentifier}/session_annotations\"",
                                httpMethod: "DELETE",
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
                                operationId: "DeleteSessionAnnotations",
                                methodName: "DeleteSessionAnnotationsAsync",
                                pathTemplate: "$\"/v1/projects/{projectIdentifier}/session_annotations\"",
                                httpMethod: "DELETE",
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
                                operationId: "DeleteSessionAnnotations",
                                methodName: "DeleteSessionAnnotationsAsync",
                                pathTemplate: "$\"/v1/projects/{projectIdentifier}/session_annotations\"",
                                httpMethod: "DELETE",
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
                ProcessDeleteSessionAnnotationsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Phoenix.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Phoenix.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DeleteSessionAnnotations",
                                methodName: "DeleteSessionAnnotationsAsync",
                                pathTemplate: "$\"/v1/projects/{projectIdentifier}/session_annotations\"",
                                httpMethod: "DELETE",
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
                                operationId: "DeleteSessionAnnotations",
                                methodName: "DeleteSessionAnnotationsAsync",
                                pathTemplate: "$\"/v1/projects/{projectIdentifier}/session_annotations\"",
                                httpMethod: "DELETE",
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
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                string? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_403, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Phoenix.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Project not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                string? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_404, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Phoenix.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Invalid parameters
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                string? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_422, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_422, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Phoenix.ApiException<string>.Create(
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

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::Phoenix.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Phoenix.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
                                    return new global::Phoenix.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Phoenix.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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