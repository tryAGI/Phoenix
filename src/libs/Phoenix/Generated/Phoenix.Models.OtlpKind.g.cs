
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum OtlpKind
    {
        /// <summary>
        /// 
        /// </summary>
        SpanKindUnspecified,
        /// <summary>
        /// 
        /// </summary>
        SpanKindInternal,
        /// <summary>
        /// 
        /// </summary>
        SpanKindServer,
        /// <summary>
        /// 
        /// </summary>
        SpanKindClient,
        /// <summary>
        /// 
        /// </summary>
        SpanKindProducer,
        /// <summary>
        /// 
        /// </summary>
        SpanKindConsumer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OtlpKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OtlpKind value)
        {
            return value switch
            {
                OtlpKind.SpanKindUnspecified => "SPAN_KIND_UNSPECIFIED",
                OtlpKind.SpanKindInternal => "SPAN_KIND_INTERNAL",
                OtlpKind.SpanKindServer => "SPAN_KIND_SERVER",
                OtlpKind.SpanKindClient => "SPAN_KIND_CLIENT",
                OtlpKind.SpanKindProducer => "SPAN_KIND_PRODUCER",
                OtlpKind.SpanKindConsumer => "SPAN_KIND_CONSUMER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OtlpKind? ToEnum(string value)
        {
            return value switch
            {
                "SPAN_KIND_UNSPECIFIED" => OtlpKind.SpanKindUnspecified,
                "SPAN_KIND_INTERNAL" => OtlpKind.SpanKindInternal,
                "SPAN_KIND_SERVER" => OtlpKind.SpanKindServer,
                "SPAN_KIND_CLIENT" => OtlpKind.SpanKindClient,
                "SPAN_KIND_PRODUCER" => OtlpKind.SpanKindProducer,
                "SPAN_KIND_CONSUMER" => OtlpKind.SpanKindConsumer,
                _ => null,
            };
        }
    }
}