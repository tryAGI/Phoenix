#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MetadataVariant1 : global::System.IEquatable<MetadataVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PhoenixUIMessageMetadataVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Wire schema for the chat stream's `message_metadata` payload.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.AssistantMessageMetadata? Assistant { get; init; }
#else
        public global::Phoenix.AssistantMessageMetadata? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAssistant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.AssistantMessageMetadata? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.AssistantMessageMetadata PickAssistant() => IsAssistant
            ? Assistant!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");

        /// <summary>
        /// Wire schema for metadata the browser attaches to outgoing user messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.UserMessageMetadata? User { get; init; }
#else
        public global::Phoenix.UserMessageMetadata? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.UserMessageMetadata? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.UserMessageMetadata PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataVariant1(global::Phoenix.AssistantMessageMetadata value) => new MetadataVariant1((global::Phoenix.AssistantMessageMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.AssistantMessageMetadata?(MetadataVariant1 @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public MetadataVariant1(global::Phoenix.AssistantMessageMetadata? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataVariant1 FromAssistant(global::Phoenix.AssistantMessageMetadata? value) => new MetadataVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataVariant1(global::Phoenix.UserMessageMetadata value) => new MetadataVariant1((global::Phoenix.UserMessageMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.UserMessageMetadata?(MetadataVariant1 @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public MetadataVariant1(global::Phoenix.UserMessageMetadata? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MetadataVariant1 FromUser(global::Phoenix.UserMessageMetadata? value) => new MetadataVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public MetadataVariant1(
            global::Phoenix.PhoenixUIMessageMetadataVariant1DiscriminatorType? type,
            global::Phoenix.AssistantMessageMetadata? assistant,
            global::Phoenix.UserMessageMetadata? user
            )
        {
            Type = type;

            Assistant = assistant;
            User = user;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            User as object ??
            Assistant as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Assistant?.ToString() ??
            User?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAssistant && !IsUser || !IsAssistant && IsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.AssistantMessageMetadata, TResult>? assistant = null,
            global::System.Func<global::Phoenix.UserMessageMetadata, TResult>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.AssistantMessageMetadata>? assistant = null,

            global::System.Action<global::Phoenix.UserMessageMetadata>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.AssistantMessageMetadata>? assistant = null,
            global::System.Action<global::Phoenix.UserMessageMetadata>? user = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Assistant,
                typeof(global::Phoenix.AssistantMessageMetadata),
                User,
                typeof(global::Phoenix.UserMessageMetadata),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MetadataVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.AssistantMessageMetadata?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.UserMessageMetadata?>.Default.Equals(User, other.User) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetadataVariant1 obj1, MetadataVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetadataVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetadataVariant1 obj1, MetadataVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetadataVariant1 o && Equals(o);
        }
    }
}
