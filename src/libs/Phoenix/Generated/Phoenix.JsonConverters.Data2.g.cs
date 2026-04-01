#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class Data2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.Data2>
    {
        /// <inheritdoc />
        public override global::Phoenix.Data2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CreateUserResponseBodyDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CreateUserResponseBodyDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.LocalUser? local = default;
            if (discriminator?.AuthMethod == global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod.Local)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LocalUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LocalUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LocalUser)}");
                local = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.OAuth2User? oauth2 = default;
            if (discriminator?.AuthMethod == global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.OAuth2User), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.OAuth2User> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.OAuth2User)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.LDAPUser? ldap = default;
            if (discriminator?.AuthMethod == global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod.Ldap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LDAPUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LDAPUser> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LDAPUser)}");
                ldap = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.Data2(
                discriminator?.AuthMethod,
                local,

                oauth2,

                ldap
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Phoenix.Data2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLocal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LocalUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LocalUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.LocalUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Local!, typeInfo);
            }
            else if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.OAuth2User), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.OAuth2User?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.OAuth2User).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2!, typeInfo);
            }
            else if (value.IsLdap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LDAPUser), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LDAPUser?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.LDAPUser).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ldap!, typeInfo);
            }
        }
    }
}