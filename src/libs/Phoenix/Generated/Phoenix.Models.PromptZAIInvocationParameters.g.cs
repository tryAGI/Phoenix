
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptZAIInvocationParameters
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"zai"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "zai";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zai")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptZAIInvocationParametersContent Zai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptZAIInvocationParameters" /> class.
        /// </summary>
        /// <param name="zai"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptZAIInvocationParameters(
            global::Phoenix.PromptZAIInvocationParametersContent zai,
            string type = "zai")
        {
            this.Type = type;
            this.Zai = zai ?? throw new global::System.ArgumentNullException(nameof(zai));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptZAIInvocationParameters" /> class.
        /// </summary>
        public PromptZAIInvocationParameters()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PromptZAIInvocationParameters"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PromptZAIInvocationParameters FromZai(global::Phoenix.PromptZAIInvocationParametersContent zai)
        {
            return new PromptZAIInvocationParameters
            {
                Zai = zai,
            };
        }

    }
}