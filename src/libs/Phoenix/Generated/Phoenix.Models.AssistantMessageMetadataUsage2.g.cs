
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessageMetadataUsage2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.AssistantMessageMetadataUsageTokens Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptDetails")]
        public global::Phoenix.AssistantMessageMetadataUsageTokenDetails? PromptDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataUsage2" /> class.
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="promptDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantMessageMetadataUsage2(
            global::Phoenix.AssistantMessageMetadataUsageTokens tokens,
            global::Phoenix.AssistantMessageMetadataUsageTokenDetails? promptDetails)
        {
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.PromptDetails = promptDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessageMetadataUsage2" /> class.
        /// </summary>
        public AssistantMessageMetadataUsage2()
        {
        }

    }
}