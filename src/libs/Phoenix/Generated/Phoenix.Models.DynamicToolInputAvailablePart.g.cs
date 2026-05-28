
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Dynamic tool part in input-available state.
    /// </summary>
    public sealed partial class DynamicToolInputAvailablePart
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Default Value: input-available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerExecuted")]
        public bool? ProviderExecuted { get; set; }

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
        /// Initializes a new instance of the <see cref="DynamicToolInputAvailablePart" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="toolCallId"></param>
        /// <param name="input"></param>
        /// <param name="type">
        /// Default Value: dynamic-tool
        /// </param>
        /// <param name="title"></param>
        /// <param name="state">
        /// Default Value: input-available
        /// </param>
        /// <param name="providerExecuted"></param>
        /// <param name="callProviderMetadata"></param>
        /// <param name="approval"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicToolInputAvailablePart(
            string toolName,
            string toolCallId,
            object input,
            string? type,
            string? title,
            string? state,
            bool? providerExecuted,
            global::System.Collections.Generic.Dictionary<string, object>? callProviderMetadata,
            global::Phoenix.AnyOf<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>? approval)
        {
            this.Type = type;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Title = title;
            this.State = state;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ProviderExecuted = providerExecuted;
            this.CallProviderMetadata = callProviderMetadata;
            this.Approval = approval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicToolInputAvailablePart" /> class.
        /// </summary>
        public DynamicToolInputAvailablePart()
        {
        }

    }
}