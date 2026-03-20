
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAzureOpenAIInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"azure_openai"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "azure_openai";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_openai")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptAzureOpenAIInvocationParametersContent AzureOpenai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAzureOpenAIInvocationParameters" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="azureOpenai"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAzureOpenAIInvocationParameters(
            global::Phoenix.PromptAzureOpenAIInvocationParametersContent azureOpenai,
            string type = "azure_openai")
        {
            this.AzureOpenai = azureOpenai ?? throw new global::System.ArgumentNullException(nameof(azureOpenai));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAzureOpenAIInvocationParameters" /> class.
        /// </summary>
        public PromptAzureOpenAIInvocationParameters()
        {
        }
    }
}