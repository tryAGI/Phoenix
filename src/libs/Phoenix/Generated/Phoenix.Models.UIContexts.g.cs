
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UIContexts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public global::Phoenix.ProjectUIContext? Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::Phoenix.TraceUIContext? Trace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::Phoenix.SessionUIContext? Session { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span")]
        public global::Phoenix.SpanUIContext? Span { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::Phoenix.PromptUIContext? Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        public global::Phoenix.PromptVersionUIContext? PromptVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        public global::Phoenix.DatasetUIContext? Dataset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground")]
        public global::Phoenix.PlaygroundUIContext? Playground { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeEvaluator")]
        public global::Phoenix.CodeEvaluatorUIContext? CodeEvaluator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmEvaluator")]
        public global::Phoenix.LlmEvaluatorUIContext? LlmEvaluator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UIContexts" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="trace"></param>
        /// <param name="session"></param>
        /// <param name="span"></param>
        /// <param name="prompt"></param>
        /// <param name="promptVersion"></param>
        /// <param name="dataset"></param>
        /// <param name="playground"></param>
        /// <param name="codeEvaluator"></param>
        /// <param name="llmEvaluator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UIContexts(
            global::Phoenix.ProjectUIContext? project,
            global::Phoenix.TraceUIContext? trace,
            global::Phoenix.SessionUIContext? session,
            global::Phoenix.SpanUIContext? span,
            global::Phoenix.PromptUIContext? prompt,
            global::Phoenix.PromptVersionUIContext? promptVersion,
            global::Phoenix.DatasetUIContext? dataset,
            global::Phoenix.PlaygroundUIContext? playground,
            global::Phoenix.CodeEvaluatorUIContext? codeEvaluator,
            global::Phoenix.LlmEvaluatorUIContext? llmEvaluator)
        {
            this.Project = project;
            this.Trace = trace;
            this.Session = session;
            this.Span = span;
            this.Prompt = prompt;
            this.PromptVersion = promptVersion;
            this.Dataset = dataset;
            this.Playground = playground;
            this.CodeEvaluator = codeEvaluator;
            this.LlmEvaluator = llmEvaluator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIContexts" /> class.
        /// </summary>
        public UIContexts()
        {
        }

    }
}