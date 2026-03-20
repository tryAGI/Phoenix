
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptFireworksInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"fireworks"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "fireworks";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fireworks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptFireworksInvocationParametersContent Fireworks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFireworksInvocationParameters" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fireworks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptFireworksInvocationParameters(
            global::Phoenix.PromptFireworksInvocationParametersContent fireworks,
            string type = "fireworks")
        {
            this.Fireworks = fireworks ?? throw new global::System.ArgumentNullException(nameof(fireworks));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFireworksInvocationParameters" /> class.
        /// </summary>
        public PromptFireworksInvocationParameters()
        {
        }
    }
}