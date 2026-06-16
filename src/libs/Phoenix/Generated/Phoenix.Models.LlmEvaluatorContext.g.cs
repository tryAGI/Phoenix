
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// LLM-evaluator create/edit form mounted in the current browser route.
    /// </summary>
    public sealed partial class LlmEvaluatorContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"llm_evaluator"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "llm_evaluator";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorNodeId")]
        public string? EvaluatorNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmEvaluatorContext" /> class.
        /// </summary>
        /// <param name="evaluatorNodeId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmEvaluatorContext(
            string? evaluatorNodeId,
            string type = "llm_evaluator")
        {
            this.Type = type;
            this.EvaluatorNodeId = evaluatorNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmEvaluatorContext" /> class.
        /// </summary>
        public LlmEvaluatorContext()
        {
        }

    }
}