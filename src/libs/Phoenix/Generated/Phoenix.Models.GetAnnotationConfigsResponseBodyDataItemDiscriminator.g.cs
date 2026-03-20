
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnnotationConfigsResponseBodyDataItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter))]
        public global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnnotationConfigsResponseBodyDataItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnnotationConfigsResponseBodyDataItemDiscriminator(
            global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnnotationConfigsResponseBodyDataItemDiscriminator" /> class.
        /// </summary>
        public GetAnnotationConfigsResponseBodyDataItemDiscriminator()
        {
        }
    }
}