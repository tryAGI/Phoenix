
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Tool part in output-available state.
    /// </summary>
    public sealed partial class ToolOutputAvailablePart
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Default Value: output-available
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
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("preliminary")]
        public bool? Preliminary { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolOutputAvailablePart" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="toolCallId"></param>
        /// <param name="title"></param>
        /// <param name="state">
        /// Default Value: output-available
        /// </param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="providerExecuted"></param>
        /// <param name="callProviderMetadata"></param>
        /// <param name="preliminary"></param>
        /// <param name="approval"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolOutputAvailablePart(
            string type,
            string toolCallId,
            string? title,
            string? state,
            object? input,
            object? output,
            bool? providerExecuted,
            global::System.Collections.Generic.Dictionary<string, object>? callProviderMetadata,
            bool? preliminary,
            global::Phoenix.AnyOf<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>? approval)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Title = title;
            this.State = state;
            this.Input = input;
            this.Output = output;
            this.ProviderExecuted = providerExecuted;
            this.CallProviderMetadata = callProviderMetadata;
            this.Preliminary = preliminary;
            this.Approval = approval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolOutputAvailablePart" /> class.
        /// </summary>
        public ToolOutputAvailablePart()
        {
        }

    }
}