
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOllamaInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"ollama"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ollama";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ollama")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptOllamaInvocationParametersContent Ollama { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOllamaInvocationParameters" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ollama"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptOllamaInvocationParameters(
            global::Phoenix.PromptOllamaInvocationParametersContent ollama,
            string type = "ollama")
        {
            this.Ollama = ollama ?? throw new global::System.ArgumentNullException(nameof(ollama));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOllamaInvocationParameters" /> class.
        /// </summary>
        public PromptOllamaInvocationParameters()
        {
        }
    }
}