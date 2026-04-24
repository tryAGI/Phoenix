
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Phoenix.JsonConverters.CreateAnnotationConfigDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateAnnotationConfigDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateUserRequestBodyUserDiscriminatorAuthMethodJsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateUserRequestBodyUserDiscriminatorAuthMethodNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodJsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.LDAPUserRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.LDAPUserRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.LDAPUserDataRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.LDAPUserDataRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.LocalUserRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.LocalUserRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.LocalUserDataRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.LocalUserDataRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ModelProviderJsonConverter),

            typeof(global::Phoenix.JsonConverters.ModelProviderNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.OAuth2UserRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.OAuth2UserRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.OAuth2UserDataRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.OAuth2UserDataRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.OptimizationDirectionJsonConverter),

            typeof(global::Phoenix.JsonConverters.OptimizationDirectionNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.OtlpDoubleValueJsonConverter),

            typeof(global::Phoenix.JsonConverters.OtlpDoubleValueNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.OtlpKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.OtlpKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptGroqInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptGroqInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptMessageRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptMessageRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptMessageContentVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptMoonshotInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptMoonshotInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptPerplexityInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptPerplexityInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptTemplateFormatJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptTemplateFormatNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptTemplateTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptTemplateTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptTogetherInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptTogetherInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptToolsToolDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptToolsToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionTemplateDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionInvocationParametersDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionInvocationParametersDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionDataTemplateDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionDataTemplateDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionDataInvocationParametersDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionDataInvocationParametersDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptXAIInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptXAIInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestActionJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestActionNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestAction2JsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestAction2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesSortJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesSortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesOrderJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesOrderNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectSessionsOrderJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectSessionsOrderNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateAnnotationConfigDataJsonConverter),

            typeof(global::Phoenix.JsonConverters.DataJsonConverter),

            typeof(global::Phoenix.JsonConverters.UserJsonConverter),

            typeof(global::Phoenix.JsonConverters.Data2JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data3JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data4JsonConverter),

            typeof(global::Phoenix.JsonConverters.DataItemJsonConverter),

            typeof(global::Phoenix.JsonConverters.DataItem2JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data5JsonConverter),

            typeof(global::Phoenix.JsonConverters.ThinkingJsonConverter),

            typeof(global::Phoenix.JsonConverters.ContentVariant2ItemJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolsItemJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolChoiceJsonConverter),

            typeof(global::Phoenix.JsonConverters.TemplateJsonConverter),

            typeof(global::Phoenix.JsonConverters.InvocationParametersJsonConverter),

            typeof(global::Phoenix.JsonConverters.ResponseFormatVariant1JsonConverter),

            typeof(global::Phoenix.JsonConverters.Template2JsonConverter),

            typeof(global::Phoenix.JsonConverters.InvocationParameters2JsonConverter),

            typeof(global::Phoenix.JsonConverters.ResponseFormatVariant12JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data6JsonConverter),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<double?, global::Phoenix.OtlpDoubleValue?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.OtlpKind?, int?, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Phoenix.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Phoenix.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Phoenix.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSessionsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SessionAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSessionsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.InsertedSessionAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InsertedSessionAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSpanDocumentsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SpanDocumentAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanDocumentAnnotationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSpanDocumentsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.InsertedSpanDocumentAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InsertedSpanDocumentAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSpansRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SpanAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateSpansResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.InsertedSpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InsertedSpanAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateTracesRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.TraceAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotateTracesResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.InsertedTraceAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InsertedTraceAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnnotationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnonymousUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OptimizationDirection), TypeInfoPropertyName = "OptimizationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.CategoricalAnnotationValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContinuousAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContinuousAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigData), TypeInfoPropertyName = "CreateAnnotationConfigData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.FreeformAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType), TypeInfoPropertyName = "CreateAnnotationConfigDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data), TypeInfoPropertyName = "Data2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.FreeformAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "CreateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRunRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRunResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRunResponseBodyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateProjectRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateProjectResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreatePromptRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreatePromptResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSpanNoteRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanNoteData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSpanNoteResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSpansRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Span))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSpansResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateTraceNoteRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceNoteData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateTraceNoteResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.User), TypeInfoPropertyName = "User2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod), TypeInfoPropertyName = "CreateUserRequestBodyUserDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data2), TypeInfoPropertyName = "Data22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod), TypeInfoPropertyName = "CreateUserResponseBodyDataDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DatasetExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DatasetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DatasetWithExampleCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data3), TypeInfoPropertyName = "Data32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "DeleteAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteSessionsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ExperimentEvaluationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ExperimentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data4), TypeInfoPropertyName = "Data42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "GetAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem), TypeInfoPropertyName = "DataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType), TypeInfoPropertyName = "GetAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetDatasetResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetExperimentResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetIncompleteEvaluationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.IncompleteExperimentEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.IncompleteExperimentEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetIncompleteExperimentRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.IncompleteExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.IncompleteExperimentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetPromptResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetPromptVersionTagsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PromptVersionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetPromptVersionsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PromptVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetPromptsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetSessionResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetSessionsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SessionData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetTracesResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.TraceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod), TypeInfoPropertyName = "GetUsersResponseBodyDataItemDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data5), TypeInfoPropertyName = "Data52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod), TypeInfoPropertyName = "GetViewerResponseBodyDataDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserRole), TypeInfoPropertyName = "LDAPUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserDataRole), TypeInfoPropertyName = "LDAPUserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListDatasetExamplesData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DatasetExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListDatasetExamplesResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListDatasetVersionsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DatasetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListDatasetsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListExperimentRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListExperimentsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserRole), TypeInfoPropertyName = "LocalUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserDataRole), TypeInfoPropertyName = "LocalUserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ModelProvider), TypeInfoPropertyName = "ModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserRole), TypeInfoPropertyName = "OAuth2UserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserDataRole), TypeInfoPropertyName = "OAuth2UserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpAnyValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpArrayValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<double?, global::Phoenix.OtlpDoubleValue?, string, object>), TypeInfoPropertyName = "AnyOfDoubleOtlpDoubleValueStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpDoubleValue), TypeInfoPropertyName = "OtlpDoubleValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OtlpAnyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OtlpKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpKeyValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<long?, string, object>), TypeInfoPropertyName = "AnyOfInt64StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpKind), TypeInfoPropertyName = "OtlpKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OtlpEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.OtlpKind?, int?, object>), TypeInfoPropertyName = "AnyOfOtlpKindInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpSpansResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OtlpSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Thinking), TypeInfoPropertyName = "Thinking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType), TypeInfoPropertyName = "PromptAnthropicInvocationParametersContentThinkingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAwsInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAwsInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAzureOpenAIInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptAzureOpenAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptCerebrasInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptCerebrasInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptCerebrasInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptChatTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PromptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptDeepSeekInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptDeepSeekInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptDeepSeekInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptFireworksInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptFireworksInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptFireworksInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGroqInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGroqInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptGroqInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageRole), TypeInfoPropertyName = "PromptMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>), TypeInfoPropertyName = "AnyOfStringIListContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContentVariant2Item), TypeInfoPropertyName = "ContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TextContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolResultContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType), TypeInfoPropertyName = "PromptMessageContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMoonshotInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMoonshotInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptMoonshotInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOllamaInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOllamaInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptOllamaInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOpenAIInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOpenAIInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptOpenAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptPerplexityInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptPerplexityInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptPerplexityInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptResponseFormatJSONSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptResponseFormatJSONSchemaDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptStringTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTemplateFormat), TypeInfoPropertyName = "PromptTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTemplateType), TypeInfoPropertyName = "PromptTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTogetherInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTogetherInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptTogetherInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolChoiceNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolChoiceOneOrMore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolChoiceSpecificFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolChoiceZeroOrMore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolFunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTools))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolsItem), TypeInfoPropertyName = "ToolsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolDiscriminatorType), TypeInfoPropertyName = "PromptToolsToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolChoice), TypeInfoPropertyName = "ToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolChoiceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolChoiceDiscriminatorType), TypeInfoPropertyName = "PromptToolsToolChoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Template), TypeInfoPropertyName = "Template2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTemplateDiscriminatorType), TypeInfoPropertyName = "PromptVersionTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InvocationParameters), TypeInfoPropertyName = "InvocationParameters2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptXAIInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminatorType), TypeInfoPropertyName = "PromptVersionInvocationParametersDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ResponseFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "PromptVersionResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Template2), TypeInfoPropertyName = "Template22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataTemplateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataTemplateDiscriminatorType), TypeInfoPropertyName = "PromptVersionDataTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InvocationParameters2), TypeInfoPropertyName = "InvocationParameters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType), TypeInfoPropertyName = "PromptVersionDataInvocationParametersDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ResponseFormatVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "PromptVersionDataResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTagData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptXAIInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort), TypeInfoPropertyName = "PromptXAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ResponseBodyUpsertOrDeleteSecretsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertOrDeleteSecretsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SecretKeyValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationSource), TypeInfoPropertyName = "SessionAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationAnnotatorKind), TypeInfoPropertyName = "SessionAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationDataAnnotatorKind), TypeInfoPropertyName = "SessionAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SessionAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SessionTraceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionTraceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SpanEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationSource), TypeInfoPropertyName = "SpanAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationAnnotatorKind), TypeInfoPropertyName = "SpanAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationDataAnnotatorKind), TypeInfoPropertyName = "SpanAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind), TypeInfoPropertyName = "SpanDocumentAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpansResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminatorType), TypeInfoPropertyName = "ToolCallContentPartToolCallDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>), TypeInfoPropertyName = "AnyOfBooleanInt32DoubleStringObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationSource), TypeInfoPropertyName = "TraceAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationAnnotatorKind), TypeInfoPropertyName = "TraceAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationDataAnnotatorKind), TypeInfoPropertyName = "TraceAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.TraceAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.TraceSpanData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceSpanData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data6), TypeInfoPropertyName = "Data62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "UpdateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateProjectRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateProjectResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind), TypeInfoPropertyName = "UpsertExperimentEvaluationRequestBodyAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationResponseBodyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertOrDeleteSecretsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.SecretKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequestAction), TypeInfoPropertyName = "UploadDatasetRequestAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OneOf<string, global::System.Collections.Generic.IList<string>, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OneOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "OneOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequestAction2), TypeInfoPropertyName = "UploadDatasetRequestAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectTracesSort), TypeInfoPropertyName = "ListProjectTracesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectTracesOrder), TypeInfoPropertyName = "ListProjectTracesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectSessionsOrder), TypeInfoPropertyName = "ListProjectSessionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedSessionAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanDocumentAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedSpanDocumentAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedSpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedTraceAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.CategoricalAnnotationValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.IncompleteExperimentEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.IncompleteExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptVersionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DatasetExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DatasetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Experiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OtlpAnyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OtlpKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OtlpEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OtlpSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.List<global::Phoenix.ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionTraceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.List<object>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceSpanData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SecretKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OneOf<string, global::System.Collections.Generic.List<string>, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OneOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OneOf<string, object>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}