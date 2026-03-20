
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAnnotationConfigResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.Data6JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.Data6 Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnnotationConfigResponseBody" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAnnotationConfigResponseBody(
            global::Phoenix.Data6 data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnnotationConfigResponseBody" /> class.
        /// </summary>
        public UpdateAnnotationConfigResponseBody()
        {
        }
    }
}