#nullable enable

namespace Phoenix
{
    public partial interface IChatCompletionsClient
    {
        /// <summary>
        /// OpenAI-compatible chat completions<br/>
        /// Creates a chat completion using the OpenAI wire format, proxying to the selected provider with credentials resolved on the server (secret store first, environment second) — callers never handle provider API keys. Model must be '{provider}:{model_name}' for a built-in provider (one of anthropic, aws, azure_openai, cerebras, deepseek, fireworks, google, groq, moonshot, ollama, openai, perplexity, together, xai) or 'custom:{provider_id}:{model_name}' for a stored custom provider, e.g. 'openai:gpt-4o' or 'anthropic:claude-sonnet-4-5'. Set `stream: true` for server-sent events of `chat.completion.chunk` payloads terminated by `data: [DONE]`. Tool calling is not supported.<br/>
        /// **Phoenix is not an AI gateway.** The same server also takes on trace ingestion traffic, so routing production LLM calls through it competes with ingestion. Use this endpoint only to quickly try out different models in non-production environments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ChatCompletion> CreateChatCompletionAsync(

            global::Phoenix.CreateChatCompletionRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OpenAI-compatible chat completions<br/>
        /// Creates a chat completion using the OpenAI wire format, proxying to the selected provider with credentials resolved on the server (secret store first, environment second) — callers never handle provider API keys. Model must be '{provider}:{model_name}' for a built-in provider (one of anthropic, aws, azure_openai, cerebras, deepseek, fireworks, google, groq, moonshot, ollama, openai, perplexity, together, xai) or 'custom:{provider_id}:{model_name}' for a stored custom provider, e.g. 'openai:gpt-4o' or 'anthropic:claude-sonnet-4-5'. Set `stream: true` for server-sent events of `chat.completion.chunk` payloads terminated by `data: [DONE]`. Tool calling is not supported.<br/>
        /// **Phoenix is not an AI gateway.** The same server also takes on trace ingestion traffic, so routing production LLM calls through it competes with ingestion. Use this endpoint only to quickly try out different models in non-production environments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.ChatCompletion>> CreateChatCompletionAsResponseAsync(

            global::Phoenix.CreateChatCompletionRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OpenAI-compatible chat completions<br/>
        /// Creates a chat completion using the OpenAI wire format, proxying to the selected provider with credentials resolved on the server (secret store first, environment second) — callers never handle provider API keys. Model must be '{provider}:{model_name}' for a built-in provider (one of anthropic, aws, azure_openai, cerebras, deepseek, fireworks, google, groq, moonshot, ollama, openai, perplexity, together, xai) or 'custom:{provider_id}:{model_name}' for a stored custom provider, e.g. 'openai:gpt-4o' or 'anthropic:claude-sonnet-4-5'. Set `stream: true` for server-sent events of `chat.completion.chunk` payloads terminated by `data: [DONE]`. Tool calling is not supported.<br/>
        /// **Phoenix is not an AI gateway.** The same server also takes on trace ingestion traffic, so routing production LLM calls through it competes with ingestion. Use this endpoint only to quickly try out different models in non-production environments.
        /// </summary>
        /// <param name="model">
        /// Model must be '{provider}:{model_name}' for a built-in provider (one of anthropic, aws, azure_openai, cerebras, deepseek, fireworks, google, groq, moonshot, ollama, openai, perplexity, together, xai) or 'custom:{provider_id}:{model_name}' for a stored custom provider, e.g. 'openai:gpt-4o' or 'anthropic:claude-sonnet-4-5'.
        /// </param>
        /// <param name="messages"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="stop"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="seed"></param>
        /// <param name="n"></param>
        /// <param name="streamOptions"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="responseFormat"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ChatCompletion> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionRequestMessage> messages,
            bool? stream = default,
            double? temperature = default,
            double? topP = default,
            int? maxTokens = default,
            int? maxCompletionTokens = default,
            global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop = default,
            double? frequencyPenalty = default,
            double? presencePenalty = default,
            int? seed = default,
            int? n = default,
            global::Phoenix.ChatCompletionStreamOptions? streamOptions = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            object? toolChoice = default,
            object? responseFormat = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}