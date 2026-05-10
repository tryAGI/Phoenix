
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// A file part of a message.
    /// </summary>
    public sealed partial class FileUIPart
    {
        /// <summary>
        /// Default Value: file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        /// Initializes a new instance of the <see cref="FileUIPart" /> class.
        /// </summary>
        /// <param name="mediaType"></param>
        /// <param name="url"></param>
        /// <param name="type">
        /// Default Value: file
        /// </param>
        /// <param name="filename"></param>
        /// <param name="providerMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileUIPart(
            string mediaType,
            string url,
            string? type,
            string? filename,
            global::System.Collections.Generic.Dictionary<string, object>? providerMetadata)
        {
            this.Type = type;
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Filename = filename;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ProviderMetadata = providerMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUIPart" /> class.
        /// </summary>
        public FileUIPart()
        {
        }

    }
}