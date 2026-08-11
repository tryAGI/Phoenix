
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// ``UIMessage`` with ``metadata`` narrowed to ``PhoenixAssistantMessageMetadata``.
    /// </summary>
    public sealed partial class LegacyAssistantMetadataUIMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.LegacyAssistantMetadataUIMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.LegacyAssistantMetadataUIMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Phoenix.LegacyAssistantMessageMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.PydanticAiUiVercelAiRequestTypesToolOutputAvailablePart, global::Phoenix.PydanticAiUiVercelAiRequestTypesToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.PydanticAiUiVercelAiRequestTypesDynamicToolOutputAvailablePart, global::Phoenix.PydanticAiUiVercelAiRequestTypesDynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>> Parts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyAssistantMetadataUIMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role"></param>
        /// <param name="parts"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyAssistantMetadataUIMessage(
            string id,
            global::Phoenix.LegacyAssistantMetadataUIMessageRole role,
            global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.PydanticAiUiVercelAiRequestTypesToolOutputAvailablePart, global::Phoenix.PydanticAiUiVercelAiRequestTypesToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.PydanticAiUiVercelAiRequestTypesDynamicToolOutputAvailablePart, global::Phoenix.PydanticAiUiVercelAiRequestTypesDynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>> parts,
            global::Phoenix.LegacyAssistantMessageMetadata? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
            this.Metadata = metadata;
            this.Parts = parts ?? throw new global::System.ArgumentNullException(nameof(parts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyAssistantMetadataUIMessage" /> class.
        /// </summary>
        public LegacyAssistantMetadataUIMessage()
        {
        }

    }
}