#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Discriminated union of chat request payloads.
    /// </summary>
    public readonly partial struct ChatRequest : global::System.IEquatable<ChatRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.ChatRequestDiscriminatorTrigger? Trigger { get; }

        /// <summary>
        /// Submit message extended with Phoenix-specific fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.ChatSubmitMessage? SubmitMessage { get; init; }
#else
        public global::Phoenix.ChatSubmitMessage? SubmitMessage { get; }
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
            out global::Phoenix.ChatSubmitMessage? value)
        {
            value = SubmitMessage;
            return IsSubmitMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.ChatSubmitMessage PickSubmitMessage() => IsSubmitMessage
            ? SubmitMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubmitMessage' but the value was {ToString()}.");

        /// <summary>
        /// Regenerate message extended with Phoenix-specific fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.ChatRegenerateMessage? RegenerateMessage { get; init; }
#else
        public global::Phoenix.ChatRegenerateMessage? RegenerateMessage { get; }
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
            out global::Phoenix.ChatRegenerateMessage? value)
        {
            value = RegenerateMessage;
            return IsRegenerateMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.ChatRegenerateMessage PickRegenerateMessage() => IsRegenerateMessage
            ? RegenerateMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RegenerateMessage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequest(global::Phoenix.ChatSubmitMessage value) => new ChatRequest((global::Phoenix.ChatSubmitMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.ChatSubmitMessage?(ChatRequest @this) => @this.SubmitMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequest(global::Phoenix.ChatSubmitMessage? value)
        {
            SubmitMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequest FromSubmitMessage(global::Phoenix.ChatSubmitMessage? value) => new ChatRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequest(global::Phoenix.ChatRegenerateMessage value) => new ChatRequest((global::Phoenix.ChatRegenerateMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.ChatRegenerateMessage?(ChatRequest @this) => @this.RegenerateMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequest(global::Phoenix.ChatRegenerateMessage? value)
        {
            RegenerateMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatRequest FromRegenerateMessage(global::Phoenix.ChatRegenerateMessage? value) => new ChatRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatRequest(
            global::Phoenix.ChatRequestDiscriminatorTrigger? trigger,
            global::Phoenix.ChatSubmitMessage? submitMessage,
            global::Phoenix.ChatRegenerateMessage? regenerateMessage
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
            global::System.Func<global::Phoenix.ChatSubmitMessage, TResult>? submitMessage = null,
            global::System.Func<global::Phoenix.ChatRegenerateMessage, TResult>? regenerateMessage = null,
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
            global::System.Action<global::Phoenix.ChatSubmitMessage>? submitMessage = null,

            global::System.Action<global::Phoenix.ChatRegenerateMessage>? regenerateMessage = null,
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
            global::System.Action<global::Phoenix.ChatSubmitMessage>? submitMessage = null,
            global::System.Action<global::Phoenix.ChatRegenerateMessage>? regenerateMessage = null,
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
                typeof(global::Phoenix.ChatSubmitMessage),
                RegenerateMessage,
                typeof(global::Phoenix.ChatRegenerateMessage),
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
        public bool Equals(ChatRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ChatSubmitMessage?>.Default.Equals(SubmitMessage, other.SubmitMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ChatRegenerateMessage?>.Default.Equals(RegenerateMessage, other.RegenerateMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequest obj1, ChatRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequest obj1, ChatRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequest o && Equals(o);
        }
    }
}
