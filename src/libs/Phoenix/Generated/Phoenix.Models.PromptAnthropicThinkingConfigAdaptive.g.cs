
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicThinkingConfigAdaptive
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"adaptive"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "adaptive";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayJsonConverter))]
        public global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay? Display { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigAdaptive" /> class.
        /// </summary>
        /// <param name="display"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAnthropicThinkingConfigAdaptive(
            global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay? display,
            string type = "adaptive")
        {
            this.Type = type;
            this.Display = display;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigAdaptive" /> class.
        /// </summary>
        public PromptAnthropicThinkingConfigAdaptive()
        {
        }

    }
}