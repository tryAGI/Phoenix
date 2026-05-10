
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Dynamic tool part in input-streaming state.
    /// </summary>
    public sealed partial class DynamicToolInputStreamingPart
    {
        /// <summary>
        /// Default Value: dynamic-tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Default Value: input-streaming
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callProviderMetadata")]
        public global::System.Collections.Generic.Dictionary<string, object>? CallProviderMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>))]
        public global::Phoenix.AnyOf<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>? Approval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicToolInputStreamingPart" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="toolCallId"></param>
        /// <param name="type">
        /// Default Value: dynamic-tool
        /// </param>
        /// <param name="state">
        /// Default Value: input-streaming
        /// </param>
        /// <param name="input"></param>
        /// <param name="callProviderMetadata"></param>
        /// <param name="approval"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicToolInputStreamingPart(
            string toolName,
            string toolCallId,
            string? type,
            string? state,
            object? input,
            global::System.Collections.Generic.Dictionary<string, object>? callProviderMetadata,
            global::Phoenix.AnyOf<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>? approval)
        {
            this.Type = type;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.State = state;
            this.Input = input;
            this.CallProviderMetadata = callProviderMetadata;
            this.Approval = approval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicToolInputStreamingPart" /> class.
        /// </summary>
        public DynamicToolInputStreamingPart()
        {
        }

    }
}