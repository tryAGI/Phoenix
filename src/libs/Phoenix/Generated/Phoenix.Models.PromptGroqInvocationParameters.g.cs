
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptGroqInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"groq"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "groq";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptGroqInvocationParametersContent Groq { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGroqInvocationParameters" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="groq"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptGroqInvocationParameters(
            global::Phoenix.PromptGroqInvocationParametersContent groq,
            string type = "groq")
        {
            this.Groq = groq ?? throw new global::System.ArgumentNullException(nameof(groq));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGroqInvocationParameters" /> class.
        /// </summary>
        public PromptGroqInvocationParameters()
        {
        }
    }
}