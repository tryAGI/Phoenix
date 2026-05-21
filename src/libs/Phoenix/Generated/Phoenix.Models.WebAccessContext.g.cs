
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// User's per-turn request to expose web search / fetch tools.
    /// </summary>
    public sealed partial class WebAccessContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"web_access"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_access";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAccessContext" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebAccessContext(
            bool enabled,
            string type = "web_access")
        {
            this.Type = type;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAccessContext" /> class.
        /// </summary>
        public WebAccessContext()
        {
        }

        /// <summary>
        /// Creates a new <see cref="WebAccessContext"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static WebAccessContext FromEnabled(bool enabled)
        {
            return new WebAccessContext
            {
                Enabled = enabled,
            };
        }

    }
}