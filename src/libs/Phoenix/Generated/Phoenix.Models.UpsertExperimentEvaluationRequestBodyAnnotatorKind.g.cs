
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The kind of annotator used for the evaluation
    /// </summary>
    public enum UpsertExperimentEvaluationRequestBodyAnnotatorKind
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Code,
        /// <summary>
        ///
        /// </summary>
        Decision,
        /// <summary>
        ///
        /// </summary>
        Human,
        /// <summary>
        ///
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpsertExperimentEvaluationRequestBodyAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertExperimentEvaluationRequestBodyAnnotatorKind value)
        {
            return value switch
            {
                UpsertExperimentEvaluationRequestBodyAnnotatorKind.Agent => "AGENT",
                UpsertExperimentEvaluationRequestBodyAnnotatorKind.Code => "CODE",
                UpsertExperimentEvaluationRequestBodyAnnotatorKind.Decision => "DECISION",
                UpsertExperimentEvaluationRequestBodyAnnotatorKind.Human => "HUMAN",
                UpsertExperimentEvaluationRequestBodyAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertExperimentEvaluationRequestBodyAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => UpsertExperimentEvaluationRequestBodyAnnotatorKind.Agent,
                "CODE" => UpsertExperimentEvaluationRequestBodyAnnotatorKind.Code,
                "DECISION" => UpsertExperimentEvaluationRequestBodyAnnotatorKind.Decision,
                "HUMAN" => UpsertExperimentEvaluationRequestBodyAnnotatorKind.Human,
                "LLM" => UpsertExperimentEvaluationRequestBodyAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}