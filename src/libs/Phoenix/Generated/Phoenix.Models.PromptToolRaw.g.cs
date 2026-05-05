
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptToolRaw
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"raw"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "raw";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Raw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolRaw" /> class.
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptToolRaw(
            object raw,
            string type = "raw")
        {
            this.Type = type;
            this.Raw = raw ?? throw new global::System.ArgumentNullException(nameof(raw));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolRaw" /> class.
        /// </summary>
        public PromptToolRaw()
        {
        }
    }
}