
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptXAIInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"xai"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "xai";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptXAIInvocationParametersContent Xai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptXAIInvocationParameters" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="xai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptXAIInvocationParameters(
            global::Phoenix.PromptXAIInvocationParametersContent xai,
            string type = "xai")
        {
            this.Xai = xai ?? throw new global::System.ArgumentNullException(nameof(xai));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptXAIInvocationParameters" /> class.
        /// </summary>
        public PromptXAIInvocationParameters()
        {
        }
    }
}