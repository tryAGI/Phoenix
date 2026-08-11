
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyChatRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.LegacyChatRequestDiscriminatorTriggerJsonConverter))]
        public global::Phoenix.LegacyChatRequestDiscriminatorTrigger? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyChatRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="trigger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyChatRequestDiscriminator(
            global::Phoenix.LegacyChatRequestDiscriminatorTrigger? trigger)
        {
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyChatRequestDiscriminator" /> class.
        /// </summary>
        public LegacyChatRequestDiscriminator()
        {
        }

    }
}