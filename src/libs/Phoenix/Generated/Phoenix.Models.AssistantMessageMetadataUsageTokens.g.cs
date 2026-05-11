
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageMetadataUsageTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataUsageTokens" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="completion"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageMetadataUsageTokens(
            int prompt,
            int completion,
            int total)
        {
            this.Prompt = prompt;
            this.Completion = completion;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataUsageTokens" /> class.
        /// </summary>
        public AssistantMessageMetadataUsageTokens()
        {
        }

    }
}