
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// A document source part of a message.
    /// </summary>
    public sealed partial class SourceDocumentUIPart
    {
        /// <summary>
        /// Default Value: source-document
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
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

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
        /// Initializes a new instance of the <see cref="SourceDocumentUIPart" /> class.
        /// </summary>
        /// <param name="sourceId"></param>
        /// <param name="mediaType"></param>
        /// <param name="title"></param>
        /// <param name="type">
        /// Default Value: source-document
        /// </param>
        /// <param name="filename"></param>
        /// <param name="providerMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceDocumentUIPart(
            string sourceId,
            string mediaType,
            string title,
            string? type,
            string? filename,
            global::System.Collections.Generic.Dictionary<string, object>? providerMetadata)
        {
            this.Type = type;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Filename = filename;
            this.ProviderMetadata = providerMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceDocumentUIPart" /> class.
        /// </summary>
        public SourceDocumentUIPart()
        {
        }
    }
}