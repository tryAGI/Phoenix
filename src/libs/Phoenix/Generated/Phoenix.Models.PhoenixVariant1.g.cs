#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoenixVariant1 : global::System.IEquatable<PhoenixVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.MessageMetadataPhoenixVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// The ``phoenix`` metadata namespace of an assistant message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PhoenixAssistantMessageMetadata? Assistant { get; init; }
#else
        public global::Phoenix.PhoenixAssistantMessageMetadata? Assistant { get; }
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
            out global::Phoenix.PhoenixAssistantMessageMetadata? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PhoenixAssistantMessageMetadata PickAssistant() => IsAssistant
            ? Assistant!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");

        /// <summary>
        /// The ``phoenix`` metadata namespace the browser attaches to outgoing<br/>
        /// user messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PhoenixUserMessageMetadata? User { get; init; }
#else
        public global::Phoenix.PhoenixUserMessageMetadata? User { get; }
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
            out global::Phoenix.PhoenixUserMessageMetadata? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PhoenixUserMessageMetadata PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoenixVariant1(global::Phoenix.PhoenixAssistantMessageMetadata value) => new PhoenixVariant1((global::Phoenix.PhoenixAssistantMessageMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PhoenixAssistantMessageMetadata?(PhoenixVariant1 @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public PhoenixVariant1(global::Phoenix.PhoenixAssistantMessageMetadata? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PhoenixVariant1 FromAssistant(global::Phoenix.PhoenixAssistantMessageMetadata? value) => new PhoenixVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoenixVariant1(global::Phoenix.PhoenixUserMessageMetadata value) => new PhoenixVariant1((global::Phoenix.PhoenixUserMessageMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PhoenixUserMessageMetadata?(PhoenixVariant1 @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public PhoenixVariant1(global::Phoenix.PhoenixUserMessageMetadata? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PhoenixVariant1 FromUser(global::Phoenix.PhoenixUserMessageMetadata? value) => new PhoenixVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public PhoenixVariant1(
            global::Phoenix.MessageMetadataPhoenixVariant1DiscriminatorType? type,
            global::Phoenix.PhoenixAssistantMessageMetadata? assistant,
            global::Phoenix.PhoenixUserMessageMetadata? user
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
            global::System.Func<global::Phoenix.PhoenixAssistantMessageMetadata, TResult>? assistant = null,
            global::System.Func<global::Phoenix.PhoenixUserMessageMetadata, TResult>? user = null,
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
            global::System.Action<global::Phoenix.PhoenixAssistantMessageMetadata>? assistant = null,

            global::System.Action<global::Phoenix.PhoenixUserMessageMetadata>? user = null,
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
            global::System.Action<global::Phoenix.PhoenixAssistantMessageMetadata>? assistant = null,
            global::System.Action<global::Phoenix.PhoenixUserMessageMetadata>? user = null,
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
                typeof(global::Phoenix.PhoenixAssistantMessageMetadata),
                User,
                typeof(global::Phoenix.PhoenixUserMessageMetadata),
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
        public bool Equals(PhoenixVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PhoenixAssistantMessageMetadata?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PhoenixUserMessageMetadata?>.Default.Equals(User, other.User) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoenixVariant1 obj1, PhoenixVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoenixVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoenixVariant1 obj1, PhoenixVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoenixVariant1 o && Equals(o);
        }
    }
}
