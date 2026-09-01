
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// One client-held credential riding the request for the duration of a turn.<br/>
    /// The value is ephemeral: it is injected server-side as transport auth for<br/>
    /// the matching integration and is never persisted, traced, or echoed. It is<br/>
    /// top-level on the request body — never part of the message — so it cannot<br/>
    /// reach the session transcript.
    /// </summary>
    public sealed partial class ChatRequestCredential
    {
        /// <summary>
        /// The credential's secret-key name.
        /// </summary>
        /// <default>"GITHUB_PERSONAL_ACCESS_TOKEN"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string Key { get; set; } = "GITHUB_PERSONAL_ACCESS_TOKEN";

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCredential" /> class.
        /// </summary>
        /// <param name="value">
        /// Included only in requests
        /// </param>
        /// <param name="key">
        /// The credential's secret-key name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestCredential(
            string? value,
            string key = "GITHUB_PERSONAL_ACCESS_TOKEN")
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCredential" /> class.
        /// </summary>
        public ChatRequestCredential()
        {
        }

    }
}