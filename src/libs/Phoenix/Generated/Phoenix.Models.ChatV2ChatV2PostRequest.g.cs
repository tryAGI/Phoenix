#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatV2ChatV2PostRequest : global::System.IEquatable<ChatV2ChatV2PostRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger? Trigger { get; }

        /// <summary>
        /// Submit message extended with Phoenix-specific fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.SubmitMessage? SubmitMessage { get; init; }
#else
        public global::Phoenix.SubmitMessage? SubmitMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubmitMessage))]
#endif
        public bool IsSubmitMessage => SubmitMessage != null;

        /// <summary>
        /// Regenerate message extended with Phoenix-specific fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.RegenerateMessage? RegenerateMessage { get; init; }
#else
        public global::Phoenix.RegenerateMessage? RegenerateMessage { get; }
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
        public static implicit operator ChatV2ChatV2PostRequest(global::Phoenix.SubmitMessage value) => new ChatV2ChatV2PostRequest((global::Phoenix.SubmitMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.SubmitMessage?(ChatV2ChatV2PostRequest @this) => @this.SubmitMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatV2ChatV2PostRequest(global::Phoenix.SubmitMessage? value)
        {
            SubmitMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatV2ChatV2PostRequest(global::Phoenix.RegenerateMessage value) => new ChatV2ChatV2PostRequest((global::Phoenix.RegenerateMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.RegenerateMessage?(ChatV2ChatV2PostRequest @this) => @this.RegenerateMessage;

        /// <summary>
        /// 
        /// </summary>
        public ChatV2ChatV2PostRequest(global::Phoenix.RegenerateMessage? value)
        {
            RegenerateMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatV2ChatV2PostRequest(
            global::Phoenix.ChatV2ChatV2PostRequestDiscriminatorTrigger? trigger,
            global::Phoenix.SubmitMessage? submitMessage,
            global::Phoenix.RegenerateMessage? regenerateMessage
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
            global::System.Func<global::Phoenix.SubmitMessage?, TResult>? submitMessage = null,
            global::System.Func<global::Phoenix.RegenerateMessage?, TResult>? regenerateMessage = null,
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
            global::System.Action<global::Phoenix.SubmitMessage?>? submitMessage = null,
            global::System.Action<global::Phoenix.RegenerateMessage?>? regenerateMessage = null,
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
                typeof(global::Phoenix.SubmitMessage),
                RegenerateMessage,
                typeof(global::Phoenix.RegenerateMessage),
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
        public bool Equals(ChatV2ChatV2PostRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.SubmitMessage?>.Default.Equals(SubmitMessage, other.SubmitMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.RegenerateMessage?>.Default.Equals(RegenerateMessage, other.RegenerateMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatV2ChatV2PostRequest obj1, ChatV2ChatV2PostRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatV2ChatV2PostRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatV2ChatV2PostRequest obj1, ChatV2ChatV2PostRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatV2ChatV2PostRequest o && Equals(o);
        }
    }
}
