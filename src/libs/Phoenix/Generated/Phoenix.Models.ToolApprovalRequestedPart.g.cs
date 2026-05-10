
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Tool part in approval-requested state (awaiting user decision).
    /// </summary>
    public sealed partial class ToolApprovalRequestedPart
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Default Value: approval-requested
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
        /// Initializes a new instance of the <see cref="ToolApprovalRequestedPart" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="toolCallId"></param>
        /// <param name="state">
        /// Default Value: approval-requested
        /// </param>
        /// <param name="input"></param>
        /// <param name="providerExecuted"></param>
        /// <param name="callProviderMetadata"></param>
        /// <param name="approval"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolApprovalRequestedPart(
            string type,
            string toolCallId,
            string? state,
            object? input,
            bool? providerExecuted,
            global::System.Collections.Generic.Dictionary<string, object>? callProviderMetadata,
            global::Phoenix.AnyOf<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>? approval)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.State = state;
            this.Input = input;
            this.ProviderExecuted = providerExecuted;
            this.CallProviderMetadata = callProviderMetadata;
            this.Approval = approval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalRequestedPart" /> class.
        /// </summary>
        public ToolApprovalRequestedPart()
        {
        }

    }
}