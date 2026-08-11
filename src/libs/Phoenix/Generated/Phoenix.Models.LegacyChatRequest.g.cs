#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Discriminated union of legacy chat request payloads.
    /// </summary>
    public readonly partial struct LegacyChatRequest : global::System.IEquatable<LegacyChatRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.LegacyChatRequestDiscriminatorTrigger? Trigger { get; }

        /// <summary>
        /// Submit message extended with Phoenix-specific fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.LegacyChatSubmitMessage? SubmitMessage { get; init; }
#else
        public global::Phoenix.LegacyChatSubmitMessage? SubmitMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubmitMessage))]
#endif
        public bool IsSubmitMessage => SubmitMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubmitMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.LegacyChatSubmitMessage? value)
        {
            value = SubmitMessage;
            return IsSubmitMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.LegacyChatSubmitMessage PickSubmitMessage() => IsSubmitMessage
            ? SubmitMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubmitMessage' but the value was {ToString()}.");

        /// <summary>
        /// Regenerate message extended with Phoenix-specific fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.LegacyChatRegenerateMessage? RegenerateMessage { get; init; }
#else
        public global::Phoenix.LegacyChatRegenerateMessage? RegenerateMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RegenerateMessage))]
#endif
        public bool IsRegenerateMessage => RegenerateMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRegenerateMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.LegacyChatRegenerateMessage? value)
        {
            value = RegenerateMessage;
            return IsRegenerateMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.LegacyChatRegenerateMessage PickRegenerateMessage() => IsRegenerateMessage
            ? RegenerateMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RegenerateMessage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LegacyChatRequest(global::Phoenix.LegacyChatSubmitMessage value) => new LegacyChatRequest((global::Phoenix.LegacyChatSubmitMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LegacyChatSubmitMessage?(LegacyChatRequest @this) => @this.SubmitMessage;

        /// <summary>
        /// 
        /// </summary>
        public LegacyChatRequest(global::Phoenix.LegacyChatSubmitMessage? value)
        {
            SubmitMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LegacyChatRequest FromSubmitMessage(global::Phoenix.LegacyChatSubmitMessage? value) => new LegacyChatRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LegacyChatRequest(global::Phoenix.LegacyChatRegenerateMessage value) => new LegacyChatRequest((global::Phoenix.LegacyChatRegenerateMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LegacyChatRegenerateMessage?(LegacyChatRequest @this) => @this.RegenerateMessage;

        /// <summary>
        /// 
        /// </summary>
        public LegacyChatRequest(global::Phoenix.LegacyChatRegenerateMessage? value)
        {
            RegenerateMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static LegacyChatRequest FromRegenerateMessage(global::Phoenix.LegacyChatRegenerateMessage? value) => new LegacyChatRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public LegacyChatRequest(
            global::Phoenix.LegacyChatRequestDiscriminatorTrigger? trigger,
            global::Phoenix.LegacyChatSubmitMessage? submitMessage,
            global::Phoenix.LegacyChatRegenerateMessage? regenerateMessage
            )
        {
            Trigger = trigger;

            SubmitMessage = submitMessage;
            RegenerateMessage = regenerateMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RegenerateMessage as object ??
            SubmitMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SubmitMessage?.ToString() ??
            RegenerateMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSubmitMessage && !IsRegenerateMessage || !IsSubmitMessage && IsRegenerateMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.LegacyChatSubmitMessage, TResult>? submitMessage = null,
            global::System.Func<global::Phoenix.LegacyChatRegenerateMessage, TResult>? regenerateMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubmitMessage && submitMessage != null)
            {
                return submitMessage(SubmitMessage!);
            }
            else if (IsRegenerateMessage && regenerateMessage != null)
            {
                return regenerateMessage(RegenerateMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.LegacyChatSubmitMessage>? submitMessage = null,

            global::System.Action<global::Phoenix.LegacyChatRegenerateMessage>? regenerateMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubmitMessage)
            {
                submitMessage?.Invoke(SubmitMessage!);
            }
            else if (IsRegenerateMessage)
            {
                regenerateMessage?.Invoke(RegenerateMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.LegacyChatSubmitMessage>? submitMessage = null,
            global::System.Action<global::Phoenix.LegacyChatRegenerateMessage>? regenerateMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubmitMessage)
            {
                submitMessage?.Invoke(SubmitMessage!);
            }
            else if (IsRegenerateMessage)
            {
                regenerateMessage?.Invoke(RegenerateMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SubmitMessage,
                typeof(global::Phoenix.LegacyChatSubmitMessage),
                RegenerateMessage,
                typeof(global::Phoenix.LegacyChatRegenerateMessage),
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
        public bool Equals(LegacyChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LegacyChatSubmitMessage?>.Default.Equals(SubmitMessage, other.SubmitMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LegacyChatRegenerateMessage?>.Default.Equals(RegenerateMessage, other.RegenerateMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LegacyChatRequest obj1, LegacyChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LegacyChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LegacyChatRequest obj1, LegacyChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LegacyChatRequest o && Equals(o);
        }
    }
}
