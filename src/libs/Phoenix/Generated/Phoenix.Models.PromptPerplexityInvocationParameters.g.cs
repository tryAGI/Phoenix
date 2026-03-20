
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptPerplexityInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"perplexity"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "perplexity";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perplexity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptPerplexityInvocationParametersContent Perplexity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPerplexityInvocationParameters" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="perplexity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptPerplexityInvocationParameters(
            global::Phoenix.PromptPerplexityInvocationParametersContent perplexity,
            string type = "perplexity")
        {
            this.Perplexity = perplexity ?? throw new global::System.ArgumentNullException(nameof(perplexity));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPerplexityInvocationParameters" /> class.
        /// </summary>
        public PromptPerplexityInvocationParameters()
        {
        }
    }
}