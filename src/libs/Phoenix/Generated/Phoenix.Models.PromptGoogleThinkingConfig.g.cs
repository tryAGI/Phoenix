
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptGoogleThinkingConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_budget")]
        public int? ThinkingBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelJsonConverter))]
        public global::Phoenix.PromptGoogleThinkingConfigThinkingLevel? ThinkingLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_thoughts")]
        public bool? IncludeThoughts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGoogleThinkingConfig" /> class.
        /// </summary>
        /// <param name="thinkingBudget"></param>
        /// <param name="thinkingLevel"></param>
        /// <param name="includeThoughts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptGoogleThinkingConfig(
            int? thinkingBudget,
            global::Phoenix.PromptGoogleThinkingConfigThinkingLevel? thinkingLevel,
            bool? includeThoughts)
        {
            this.ThinkingBudget = thinkingBudget;
            this.ThinkingLevel = thinkingLevel;
            this.IncludeThoughts = includeThoughts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGoogleThinkingConfig" /> class.
        /// </summary>
        public PromptGoogleThinkingConfig()
        {
        }

    }
}