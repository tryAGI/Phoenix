
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicThinkingConfigEnabled
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigEnabled" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="budgetTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAnthropicThinkingConfigEnabled(
            int budgetTokens,
            string type = "enabled")
        {
            this.BudgetTokens = budgetTokens;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicThinkingConfigEnabled" /> class.
        /// </summary>
        public PromptAnthropicThinkingConfigEnabled()
        {
        }
    }
}