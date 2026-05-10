
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatV2ChatV2PostRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.ChatV2ChatV2PostRequestDiscriminatorTriggerJsonConverter))]
        public global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV2ChatV2PostRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="trigger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatV2ChatV2PostRequestDiscriminator(
            global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger? trigger)
        {
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV2ChatV2PostRequestDiscriminator" /> class.
        /// </summary>
        public ChatV2ChatV2PostRequestDiscriminator()
        {
        }

    }
}