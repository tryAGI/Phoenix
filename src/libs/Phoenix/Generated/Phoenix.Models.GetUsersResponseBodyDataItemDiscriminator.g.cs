
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUsersResponseBodyDataItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodJsonConverter))]
        public global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersResponseBodyDataItemDiscriminator" /> class.
        /// </summary>
        /// <param name="authMethod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsersResponseBodyDataItemDiscriminator(
            global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod? authMethod)
        {
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersResponseBodyDataItemDiscriminator" /> class.
        /// </summary>
        public GetUsersResponseBodyDataItemDiscriminator()
        {
        }
    }
}