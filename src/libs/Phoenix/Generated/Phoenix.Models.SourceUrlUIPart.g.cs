
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// A source part of a message.
    /// </summary>
    public sealed partial class SourceUrlUIPart
    {
        /// <summary>
        /// Default Value: source-url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerMetadata")]
        public global::System.Collections.Generic.Dictionary<string, object>? ProviderMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceUrlUIPart" /> class.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="url"></param>
        /// <param name="type">
        /// Default Value: source-url
        /// </param>
        /// <param name="title"></param>
        /// <param name="providerMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceUrlUIPart(
            string sourceId,
            string url,
            string? type,
            string? title,
            global::System.Collections.Generic.Dictionary<string, object>? providerMetadata)
        {
            this.Type = type;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title;
            this.ProviderMetadata = providerMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceUrlUIPart" /> class.
        /// </summary>
        public SourceUrlUIPart()
        {
        }
    }
}