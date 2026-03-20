
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicInvocationParametersContentThinkingDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeJsonConverter))]
        public global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParametersContentThinkingDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAnthropicInvocationParametersContentThinkingDiscriminator(
            global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParametersContentThinkingDiscriminator" /> class.
        /// </summary>
        public PromptAnthropicInvocationParametersContentThinkingDiscriminator()
        {
        }
    }
}