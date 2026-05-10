
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// A step boundary part of a message.
    /// </summary>
    public sealed partial class StepStartUIPart
    {
        /// <summary>
        /// Default Value: step-start
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepStartUIPart" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: step-start
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepStartUIPart(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepStartUIPart" /> class.
        /// </summary>
        public StepStartUIPart()
        {
        }

    }
}