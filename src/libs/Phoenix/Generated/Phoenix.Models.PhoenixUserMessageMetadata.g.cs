
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The ``phoenix`` metadata namespace the browser attaches to outgoing<br/>
    /// user messages.
    /// </summary>
    public sealed partial class PhoenixUserMessageMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user";

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
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCompactionMessage")]
        public bool? IsCompactionMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoenixUserMessageMetadata" /> class.
        /// </summary>
        /// <param name="currentDateTime"></param>
        /// <param name="timeZone"></param>
        /// <param name="isCompactionMessage">
        /// Default Value: false
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoenixUserMessageMetadata(
            string currentDateTime,
            string timeZone,
            bool? isCompactionMessage,
            string type = "user")
        {
            this.Type = type;
            this.CurrentDateTime = currentDateTime ?? throw new global::System.ArgumentNullException(nameof(currentDateTime));
            this.TimeZone = timeZone ?? throw new global::System.ArgumentNullException(nameof(timeZone));
            this.IsCompactionMessage = isCompactionMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoenixUserMessageMetadata" /> class.
        /// </summary>
        public PhoenixUserMessageMetadata()
        {
        }

    }
}