
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicInvocationParametersContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ThinkingJsonConverter))]
        public global::Phoenix.Thinking? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParametersContent" /> class.
        /// </summary>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="stopSequences"></param>
        /// <param name="thinking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAnthropicInvocationParametersContent(
            int maxTokens,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<string>? stopSequences,
            global::Phoenix.Thinking? thinking)
        {
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.StopSequences = stopSequences;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParametersContent" /> class.
        /// </summary>
        public PromptAnthropicInvocationParametersContent()
        {
        }
    }
}