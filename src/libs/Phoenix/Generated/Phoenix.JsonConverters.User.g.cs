#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix.JsonConverters
{
    /// <inheritdoc />
    public class UserJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Phoenix.User>
    {
        /// <inheritdoc />
        public override global::Phoenix.User Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.CreateUserRequestBodyUserDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.CreateUserRequestBodyUserDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Phoenix.LocalUserData? local = default;
            if (discriminator?.AuthMethod == global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod.Local)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LocalUserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LocalUserData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LocalUserData)}");
                local = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.OAuth2UserData? oauth2 = default;
            if (discriminator?.AuthMethod == global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.OAuth2UserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.OAuth2UserData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.OAuth2UserData)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Phoenix.LDAPUserData? ldap = default;
            if (discriminator?.AuthMethod == global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod.Ldap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LDAPUserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LDAPUserData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Phoenix.LDAPUserData)}");
                ldap = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Phoenix.User(
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
            global::Phoenix.User value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLocal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LocalUserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LocalUserData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.LocalUserData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Local, typeInfo);
            }
            else if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.OAuth2UserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.OAuth2UserData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.OAuth2UserData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeInfo);
            }
            else if (value.IsLdap)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Phoenix.LDAPUserData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Phoenix.LDAPUserData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Phoenix.LDAPUserData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ldap, typeInfo);
            }
        }
    }
}