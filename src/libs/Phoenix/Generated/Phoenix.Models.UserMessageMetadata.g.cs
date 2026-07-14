
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Wire schema for metadata the browser attaches to outgoing user messages.
    /// </summary>
    public sealed partial class UserMessageMetadata
    {
        /// <summary>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentDateTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeZone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TimeZone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageMetadata" /> class.
        /// </summary>
        /// <param name="currentDateTime"></param>
        /// <param name="timeZone"></param>
        /// <param name="type">
        /// Default Value: user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessageMetadata(
            string currentDateTime,
            string timeZone,
            string? type)
        {
            this.Type = type;
            this.CurrentDateTime = currentDateTime ?? throw new global::System.ArgumentNullException(nameof(currentDateTime));
            this.TimeZone = timeZone ?? throw new global::System.ArgumentNullException(nameof(timeZone));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageMetadata" /> class.
        /// </summary>
        public UserMessageMetadata()
        {
        }

    }
}