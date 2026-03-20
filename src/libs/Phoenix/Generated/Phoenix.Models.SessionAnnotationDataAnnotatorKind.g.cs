
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum SessionAnnotationDataAnnotatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Human,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                SessionAnnotationDataAnnotatorKind.Llm => "LLM",
                SessionAnnotationDataAnnotatorKind.Code => "CODE",
                SessionAnnotationDataAnnotatorKind.Human => "HUMAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionAnnotationDataAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "LLM" => SessionAnnotationDataAnnotatorKind.Llm,
                "CODE" => SessionAnnotationDataAnnotatorKind.Code,
                "HUMAN" => SessionAnnotationDataAnnotatorKind.Human,
                _ => null,
            };
        }
    }
}