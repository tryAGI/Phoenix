
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Payload of the durable ``data-error`` part persisted for protocol errors.
    /// </summary>
    public sealed partial class AgentErrorData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorData" /> class.
        /// </summary>
        /// <param name="errorText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentErrorData(
            string errorText)
        {
            this.ErrorText = errorText ?? throw new global::System.ArgumentNullException(nameof(errorText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentErrorData" /> class.
        /// </summary>
        public AgentErrorData()
        {
        }

    }
}