
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
            typeof(global::Phoenix.JsonConverters.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.AssistantMetadataUIMessageRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.AssistantMetadataUIMessageRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.BuiltInProviderModelSelectionOpenaiApiTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.BuiltInProviderModelSelectionOpenaiApiTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatContextDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatContextDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageEditPermissionJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageEditPermissionNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageModelDiscriminatorProviderTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageModelDiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRequestDiscriminatorTriggerJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRequestDiscriminatorTriggerNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatSubmitMessageEditPermissionJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatSubmitMessageEditPermissionNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatSubmitMessageModelDiscriminatorProviderTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatSubmitMessageModelDiscriminatorProviderTypeNullableJsonConverter),

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

            typeof(global::Phoenix.JsonConverters.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter),

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

            typeof(global::Phoenix.JsonConverters.PlaygroundEvaluatorContextKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.PlaygroundEvaluatorContextKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PlaygroundInstanceContextModelVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PlaygroundInstanceContextModelVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicOutputConfigEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicOutputConfigEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigEnabledDisplayJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigEnabledDisplayNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelNullableJsonConverter),

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

            typeof(global::Phoenix.JsonConverters.ReasoningUIPartState2JsonConverter),

            typeof(global::Phoenix.JsonConverters.ReasoningUIPartState2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TextUIPartState2JsonConverter),

            typeof(global::Phoenix.JsonConverters.TextUIPartState2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UIMessageRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.UIMessageRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SummarizeRequestModelDiscriminatorProviderTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.SummarizeRequestModelDiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallProviderMetadataToolExecutionEnvironmentJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallProviderMetadataToolExecutionEnvironmentNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestActionJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestActionNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestAction2JsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestAction2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteSpanAnnotationsAnnotatorKind2JsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteSpanAnnotationsAnnotatorKind2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteTraceAnnotationsAnnotatorKind2JsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteTraceAnnotationsAnnotatorKind2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteSessionAnnotationsAnnotatorKind2JsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteSessionAnnotationsAnnotatorKind2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesSortJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesSortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesOrderJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesOrderNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectSessionsOrderJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectSessionsOrderNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DataJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatContextJsonConverter),

            typeof(global::Phoenix.JsonConverters.ModelJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRequestJsonConverter),

            typeof(global::Phoenix.JsonConverters.Model2JsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateAnnotationConfigDataJsonConverter),

            typeof(global::Phoenix.JsonConverters.Data2JsonConverter),

            typeof(global::Phoenix.JsonConverters.UserJsonConverter),

            typeof(global::Phoenix.JsonConverters.Data3JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data4JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data5JsonConverter),

            typeof(global::Phoenix.JsonConverters.DataItemJsonConverter),

            typeof(global::Phoenix.JsonConverters.DataItem2JsonConverter),

            typeof(global::Phoenix.JsonConverters.DataItem3JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data6JsonConverter),

            typeof(global::Phoenix.JsonConverters.ModelVariant1JsonConverter),

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

            typeof(global::Phoenix.JsonConverters.DataItem4JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data7JsonConverter),

            typeof(global::Phoenix.JsonConverters.Model3JsonConverter),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<double?, global::Phoenix.OtlpDoubleValue?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.OtlpKind?, int?, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Phoenix.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Phoenix.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Phoenix.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Phoenix.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>>), TypeInfoPropertyName = "StepStartUIPart_ed9b3d00af27a569")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>), TypeInfoPropertyName = "StepStartUIPart_ee2f9588200af449")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>?), TypeInfoPropertyName = "StepStartUIPart_4f65f1009b57fac6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>>), TypeInfoPropertyName = "StepStartUIPart_6eee758df17ea469")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AddDatasetLabelToDatasetResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DatasetLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AgentSpanContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnonymousUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AppContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data), TypeInfoPropertyName = "Data2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContinuousAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.FreeformAnnotationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssistantMessageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssistantMessageMetadataTraceIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssistantMessageMetadataUsage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssistantMessageMetadataUsageTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssistantMessageMetadataUsageTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssistantMetadataUIMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssistantMetadataUIMessageRole), TypeInfoPropertyName = "AssistantMetadataUIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TextUIPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ReasoningUIPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolInputStreamingPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolInputAvailablePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolOutputAvailablePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolOutputErrorPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolApprovalRequestedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolApprovalRespondedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolOutputDeniedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DynamicToolInputStreamingPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DynamicToolInputAvailablePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DynamicToolOutputAvailablePart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DynamicToolOutputErrorPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DynamicToolApprovalRequestedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DynamicToolApprovalRespondedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DynamicToolOutputDeniedPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SourceUrlUIPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SourceDocumentUIPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.FileUIPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataUIPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.StepStartUIPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.BuiltInProviderModelSelection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ModelProvider), TypeInfoPropertyName = "ModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.BuiltInProviderModelSelectionOpenaiApiType), TypeInfoPropertyName = "BuiltInProviderModelSelectionOpenaiApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OptimizationDirection), TypeInfoPropertyName = "OptimizationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.CategoricalAnnotationValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CategoricalAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatContext), TypeInfoPropertyName = "ChatContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ProjectContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CodeEvaluatorContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LlmEvaluatorContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DatasetContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GraphQLContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.WebAccessContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SubagentsContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatContextDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatContextDiscriminatorType), TypeInfoPropertyName = "ChatContextDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRegenerateMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.AssistantMetadataUIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.ChatContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRegenerateMessageEditPermission), TypeInfoPropertyName = "ChatRegenerateMessageEditPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Model), TypeInfoPropertyName = "Model2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CustomProviderModelSelection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRegenerateMessageModelDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRegenerateMessageModelDiscriminatorProviderType), TypeInfoPropertyName = "ChatRegenerateMessageModelDiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRequest), TypeInfoPropertyName = "ChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatSubmitMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRequestDiscriminatorTrigger), TypeInfoPropertyName = "ChatRequestDiscriminatorTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatSubmitMessageEditPermission), TypeInfoPropertyName = "ChatSubmitMessageEditPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Model2), TypeInfoPropertyName = "Model22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatSubmitMessageModelDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatSubmitMessageModelDiscriminatorProviderType), TypeInfoPropertyName = "ChatSubmitMessageModelDiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContinuousAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigData), TypeInfoPropertyName = "CreateAnnotationConfigData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.FreeformAnnotationConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType), TypeInfoPropertyName = "CreateAnnotationConfigDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data2), TypeInfoPropertyName = "Data22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "CreateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateDatasetLabelRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateDatasetLabelResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateExperimentRequestBody))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSessionNoteRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionNoteData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateSessionNoteResponseBody))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data3), TypeInfoPropertyName = "Data32")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data4), TypeInfoPropertyName = "Data42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "DeleteAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteSessionsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>), TypeInfoPropertyName = "AnyOfToolApprovalRequestedToolApprovalRespondedObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolApprovalRequested))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolApprovalResponded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ExperimentEvaluationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ExperimentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data5), TypeInfoPropertyName = "Data52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "GetAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem), TypeInfoPropertyName = "DataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType), TypeInfoPropertyName = "GetAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetDatasetLabelResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetDatasetLabelsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DatasetLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetDatasetResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetExperimentResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetIncompleteEvaluationsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.IncompleteExperimentEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.IncompleteExperimentEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetIncompleteExperimentRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.IncompleteExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.IncompleteExperimentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType), TypeInfoPropertyName = "GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem3), TypeInfoPropertyName = "DataItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod), TypeInfoPropertyName = "GetUsersResponseBodyDataItemDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data6), TypeInfoPropertyName = "Data62")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListDatasetLabelsForDatasetResponseBody))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundBuiltinModelContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundExperimentScaffoldContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PlaygroundInstanceContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundInstanceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.PlaygroundEvaluatorContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundEvaluatorContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundCustomProviderModelContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundEvaluatorContextKind), TypeInfoPropertyName = "PlaygroundEvaluatorContextKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ModelVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundInstanceContextModelVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundInstanceContextModelVariant1DiscriminatorType), TypeInfoPropertyName = "PlaygroundInstanceContextModelVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicOutputConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Thinking), TypeInfoPropertyName = "Thinking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType), TypeInfoPropertyName = "PromptAnthropicInvocationParametersContentThinkingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicOutputConfigEffort), TypeInfoPropertyName = "PromptAnthropicOutputConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay), TypeInfoPropertyName = "PromptAnthropicThinkingConfigAdaptiveDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay), TypeInfoPropertyName = "PromptAnthropicThinkingConfigEnabledDisplay2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleThinkingConfigThinkingLevel), TypeInfoPropertyName = "PromptGoogleThinkingConfigThinkingLevel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolRaw))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ReasoningUIPartState2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetDatasetLabelsForDatasetResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetDatasetLabelsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.DataItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem4), TypeInfoPropertyName = "DataItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType), TypeInfoPropertyName = "SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TextUIPartState2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UIMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UIMessageRole), TypeInfoPropertyName = "UIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data7), TypeInfoPropertyName = "Data72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType), TypeInfoPropertyName = "UpdateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateDatasetLabelRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateDatasetLabelResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateExperimentRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateExperimentResponseBody))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SummarizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.UIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Model3), TypeInfoPropertyName = "Model32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SummarizeRequestModelDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SummarizeRequestModelDiscriminatorProviderType), TypeInfoPropertyName = "SummarizeRequestModelDiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SummarizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallProviderMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallProviderMetadataToolExecutionEnvironment), TypeInfoPropertyName = "ToolCallProviderMetadataToolExecutionEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequestAction), TypeInfoPropertyName = "UploadDatasetRequestAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OneOf<string, global::System.Collections.Generic.IList<string>, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OneOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "OneOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.OneOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequestAction2), TypeInfoPropertyName = "UploadDatasetRequestAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteSpanAnnotationsAnnotatorKind2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteTraceAnnotationsAnnotatorKind2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteSessionAnnotationsAnnotatorKind2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectTracesSort), TypeInfoPropertyName = "ListProjectTracesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectTracesOrder), TypeInfoPropertyName = "ListProjectTracesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectSessionsOrder), TypeInfoPropertyName = "ListProjectSessionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data?), TypeInfoPropertyName = "NullableData2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableAssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AssistantMetadataUIMessageRole?), TypeInfoPropertyName = "NullableAssistantMetadataUIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ModelProvider?), TypeInfoPropertyName = "NullableModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.BuiltInProviderModelSelectionOpenaiApiType?), TypeInfoPropertyName = "NullableBuiltInProviderModelSelectionOpenaiApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OptimizationDirection?), TypeInfoPropertyName = "NullableOptimizationDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatContext?), TypeInfoPropertyName = "NullableChatContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatContextDiscriminatorType?), TypeInfoPropertyName = "NullableChatContextDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRegenerateMessageEditPermission?), TypeInfoPropertyName = "NullableChatRegenerateMessageEditPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Model?), TypeInfoPropertyName = "NullableModel2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRegenerateMessageModelDiscriminatorProviderType?), TypeInfoPropertyName = "NullableChatRegenerateMessageModelDiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRequest?), TypeInfoPropertyName = "NullableChatRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatRequestDiscriminatorTrigger?), TypeInfoPropertyName = "NullableChatRequestDiscriminatorTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatSubmitMessageEditPermission?), TypeInfoPropertyName = "NullableChatSubmitMessageEditPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Model2?), TypeInfoPropertyName = "NullableModel22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ChatSubmitMessageModelDiscriminatorProviderType?), TypeInfoPropertyName = "NullableChatSubmitMessageModelDiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigData?), TypeInfoPropertyName = "NullableCreateAnnotationConfigData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigDataDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAnnotationConfigDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data2?), TypeInfoPropertyName = "NullableData22")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Phoenix.JsonConverters.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.AssistantMetadataUIMessageRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.AssistantMetadataUIMessageRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.BuiltInProviderModelSelectionOpenaiApiTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.BuiltInProviderModelSelectionOpenaiApiTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatContextDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatContextDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageEditPermissionJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageEditPermissionNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageModelDiscriminatorProviderTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRegenerateMessageModelDiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRequestDiscriminatorTriggerJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRequestDiscriminatorTriggerNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatSubmitMessageEditPermissionJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatSubmitMessageEditPermissionNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatSubmitMessageModelDiscriminatorProviderTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatSubmitMessageModelDiscriminatorProviderTypeNullableJsonConverter),

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

            typeof(global::Phoenix.JsonConverters.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter),

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

            typeof(global::Phoenix.JsonConverters.PlaygroundEvaluatorContextKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.PlaygroundEvaluatorContextKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PlaygroundInstanceContextModelVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PlaygroundInstanceContextModelVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicOutputConfigEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicOutputConfigEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigEnabledDisplayJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigEnabledDisplayNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelJsonConverter),

            typeof(global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelNullableJsonConverter),

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

            typeof(global::Phoenix.JsonConverters.ReasoningUIPartState2JsonConverter),

            typeof(global::Phoenix.JsonConverters.ReasoningUIPartState2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TextUIPartState2JsonConverter),

            typeof(global::Phoenix.JsonConverters.TextUIPartState2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationSourceJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationSourceNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UIMessageRoleJsonConverter),

            typeof(global::Phoenix.JsonConverters.UIMessageRoleNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindJsonConverter),

            typeof(global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.SummarizeRequestModelDiscriminatorProviderTypeJsonConverter),

            typeof(global::Phoenix.JsonConverters.SummarizeRequestModelDiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallProviderMetadataToolExecutionEnvironmentJsonConverter),

            typeof(global::Phoenix.JsonConverters.ToolCallProviderMetadataToolExecutionEnvironmentNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestActionJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestActionNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestAction2JsonConverter),

            typeof(global::Phoenix.JsonConverters.UploadDatasetRequestAction2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteSpanAnnotationsAnnotatorKind2JsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteSpanAnnotationsAnnotatorKind2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteTraceAnnotationsAnnotatorKind2JsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteTraceAnnotationsAnnotatorKind2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteSessionAnnotationsAnnotatorKind2JsonConverter),

            typeof(global::Phoenix.JsonConverters.DeleteSessionAnnotationsAnnotatorKind2NullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesSortJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesSortNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesOrderJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectTracesOrderNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectSessionsOrderJsonConverter),

            typeof(global::Phoenix.JsonConverters.ListProjectSessionsOrderNullableJsonConverter),

            typeof(global::Phoenix.JsonConverters.DataJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatContextJsonConverter),

            typeof(global::Phoenix.JsonConverters.ModelJsonConverter),

            typeof(global::Phoenix.JsonConverters.ChatRequestJsonConverter),

            typeof(global::Phoenix.JsonConverters.Model2JsonConverter),

            typeof(global::Phoenix.JsonConverters.CreateAnnotationConfigDataJsonConverter),

            typeof(global::Phoenix.JsonConverters.Data2JsonConverter),

            typeof(global::Phoenix.JsonConverters.UserJsonConverter),

            typeof(global::Phoenix.JsonConverters.Data3JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data4JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data5JsonConverter),

            typeof(global::Phoenix.JsonConverters.DataItemJsonConverter),

            typeof(global::Phoenix.JsonConverters.DataItem2JsonConverter),

            typeof(global::Phoenix.JsonConverters.DataItem3JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data6JsonConverter),

            typeof(global::Phoenix.JsonConverters.ModelVariant1JsonConverter),

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

            typeof(global::Phoenix.JsonConverters.DataItem4JsonConverter),

            typeof(global::Phoenix.JsonConverters.Data7JsonConverter),

            typeof(global::Phoenix.JsonConverters.Model3JsonConverter),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<double?, global::Phoenix.OtlpDoubleValue?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.OtlpKind?, int?, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>),

            typeof(global::Phoenix.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Phoenix.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Phoenix.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Phoenix.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Phoenix.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>>), TypeInfoPropertyName = "StepStartUIPart_ed9b3d00af27a569")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>), TypeInfoPropertyName = "StepStartUIPart_ee2f9588200af449")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>?), TypeInfoPropertyName = "StepStartUIPart_4f65f1009b57fac6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.AnyOf<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>>), TypeInfoPropertyName = "StepStartUIPart_6eee758df17ea469")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableCreateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.User?), TypeInfoPropertyName = "NullableUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod?), TypeInfoPropertyName = "NullableCreateUserRequestBodyUserDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data3?), TypeInfoPropertyName = "NullableData32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod?), TypeInfoPropertyName = "NullableCreateUserResponseBodyDataDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data4?), TypeInfoPropertyName = "NullableData42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableDeleteAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>?), TypeInfoPropertyName = "NullableAnyOfToolApprovalRequestedToolApprovalRespondedObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data5?), TypeInfoPropertyName = "NullableData52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableGetAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem?), TypeInfoPropertyName = "NullableDataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem2?), TypeInfoPropertyName = "NullableDataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableGetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem3?), TypeInfoPropertyName = "NullableDataItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod?), TypeInfoPropertyName = "NullableGetUsersResponseBodyDataItemDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data6?), TypeInfoPropertyName = "NullableData62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod?), TypeInfoPropertyName = "NullableGetViewerResponseBodyDataDiscriminatorAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserRole?), TypeInfoPropertyName = "NullableLDAPUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LDAPUserDataRole?), TypeInfoPropertyName = "NullableLDAPUserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserRole?), TypeInfoPropertyName = "NullableLocalUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.LocalUserDataRole?), TypeInfoPropertyName = "NullableLocalUserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserRole?), TypeInfoPropertyName = "NullableOAuth2UserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OAuth2UserDataRole?), TypeInfoPropertyName = "NullableOAuth2UserDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<double?, global::Phoenix.OtlpDoubleValue?, string, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleOtlpDoubleValueStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpDoubleValue?), TypeInfoPropertyName = "NullableOtlpDoubleValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<long?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt64StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OtlpKind?), TypeInfoPropertyName = "NullableOtlpKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<global::Phoenix.OtlpKind?, int?, object>?), TypeInfoPropertyName = "NullableAnyOfOtlpKindInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundEvaluatorContextKind?), TypeInfoPropertyName = "NullablePlaygroundEvaluatorContextKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PlaygroundInstanceContextModelVariant1DiscriminatorType?), TypeInfoPropertyName = "NullablePlaygroundInstanceContextModelVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Thinking?), TypeInfoPropertyName = "NullableThinking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType?), TypeInfoPropertyName = "NullablePromptAnthropicInvocationParametersContentThinkingDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicOutputConfigEffort?), TypeInfoPropertyName = "NullablePromptAnthropicOutputConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay?), TypeInfoPropertyName = "NullablePromptAnthropicThinkingConfigAdaptiveDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay?), TypeInfoPropertyName = "NullablePromptAnthropicThinkingConfigEnabledDisplay2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptAzureOpenAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptCerebrasInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptDeepSeekInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptFireworksInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGoogleThinkingConfigThinkingLevel?), TypeInfoPropertyName = "NullablePromptGoogleThinkingConfigThinkingLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptGroqInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageRole?), TypeInfoPropertyName = "NullablePromptMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>?), TypeInfoPropertyName = "NullableAnyOfStringIListContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ContentVariant2Item?), TypeInfoPropertyName = "NullableContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullablePromptMessageContentVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptMoonshotInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptOllamaInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptOpenAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptPerplexityInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTemplateFormat?), TypeInfoPropertyName = "NullablePromptTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTemplateType?), TypeInfoPropertyName = "NullablePromptTemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptTogetherInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolsItem?), TypeInfoPropertyName = "NullableToolsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolDiscriminatorType?), TypeInfoPropertyName = "NullablePromptToolsToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolChoice?), TypeInfoPropertyName = "NullableToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptToolsToolChoiceDiscriminatorType?), TypeInfoPropertyName = "NullablePromptToolsToolChoiceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Template?), TypeInfoPropertyName = "NullableTemplate2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionTemplateDiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InvocationParameters?), TypeInfoPropertyName = "NullableInvocationParameters2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionInvocationParametersDiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionInvocationParametersDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Template2?), TypeInfoPropertyName = "NullableTemplate22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataTemplateDiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionDataTemplateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.InvocationParameters2?), TypeInfoPropertyName = "NullableInvocationParameters22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionDataInvocationParametersDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullablePromptVersionDataResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort?), TypeInfoPropertyName = "NullablePromptXAIInvocationParametersContentReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationSource?), TypeInfoPropertyName = "NullableSessionAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationAnnotatorKind?), TypeInfoPropertyName = "NullableSessionAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SessionAnnotationDataAnnotatorKind?), TypeInfoPropertyName = "NullableSessionAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.DataItem4?), TypeInfoPropertyName = "NullableDataItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableSetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationSource?), TypeInfoPropertyName = "NullableSpanAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationAnnotatorKind?), TypeInfoPropertyName = "NullableSpanAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanAnnotationDataAnnotatorKind?), TypeInfoPropertyName = "NullableSpanAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind?), TypeInfoPropertyName = "NullableSpanDocumentAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallContentPartToolCallDiscriminatorType?), TypeInfoPropertyName = "NullableToolCallContentPartToolCallDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanInt32DoubleStringObjectIListObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationSource?), TypeInfoPropertyName = "NullableTraceAnnotationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationAnnotatorKind?), TypeInfoPropertyName = "NullableTraceAnnotationAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.TraceAnnotationDataAnnotatorKind?), TypeInfoPropertyName = "NullableTraceAnnotationDataAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UIMessageRole?), TypeInfoPropertyName = "NullableUIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Data7?), TypeInfoPropertyName = "NullableData72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType?), TypeInfoPropertyName = "NullableUpdateAnnotationConfigResponseBodyDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind?), TypeInfoPropertyName = "NullableUpsertExperimentEvaluationRequestBodyAnnotatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.Model3?), TypeInfoPropertyName = "NullableModel32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.SummarizeRequestModelDiscriminatorProviderType?), TypeInfoPropertyName = "NullableSummarizeRequestModelDiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ToolCallProviderMetadataToolExecutionEnvironment?), TypeInfoPropertyName = "NullableToolCallProviderMetadataToolExecutionEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequestAction?), TypeInfoPropertyName = "NullableUploadDatasetRequestAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OneOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableOneOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OneOf<string, object>?), TypeInfoPropertyName = "NullableOneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.UploadDatasetRequestAction2?), TypeInfoPropertyName = "NullableUploadDatasetRequestAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectTracesSort?), TypeInfoPropertyName = "NullableListProjectTracesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectTracesOrder?), TypeInfoPropertyName = "NullableListProjectTracesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.ListProjectSessionsOrder?), TypeInfoPropertyName = "NullableListProjectSessionsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedSessionAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanDocumentAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedSpanDocumentAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedSpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceAnnotationData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.InsertedTraceAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.CategoricalAnnotationValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.AssistantMetadataUIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ChatContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DatasetLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.IncompleteExperimentEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.IncompleteExperimentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptVersionTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem3>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PlaygroundInstanceContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PlaygroundEvaluatorContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.PromptMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<string, global::System.Collections.Generic.List<global::Phoenix.ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SessionTraceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.DataItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SpanAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.List<object>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.TraceSpanData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.SecretKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.UIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OneOf<string, global::System.Collections.Generic.List<string>, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Phoenix.OneOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Phoenix.OneOf<string, object>>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Phoenix.JsonConverters.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.AssistantMetadataUIMessageRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.AssistantMetadataUIMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.BuiltInProviderModelSelectionOpenaiApiTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.BuiltInProviderModelSelectionOpenaiApiTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatContextDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatContextDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatRegenerateMessageEditPermissionJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatRegenerateMessageEditPermissionNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatRegenerateMessageModelDiscriminatorProviderTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatRegenerateMessageModelDiscriminatorProviderTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatRequestDiscriminatorTriggerJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatRequestDiscriminatorTriggerNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatSubmitMessageEditPermissionJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatSubmitMessageEditPermissionNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatSubmitMessageModelDiscriminatorProviderTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatSubmitMessageModelDiscriminatorProviderTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateAnnotationConfigDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateAnnotationConfigDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateUserRequestBodyUserDiscriminatorAuthMethodJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateUserRequestBodyUserDiscriminatorAuthMethodNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateUserResponseBodyDataDiscriminatorAuthMethodNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DeleteAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetUsersResponseBodyDataItemDiscriminatorAuthMethodNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.GetViewerResponseBodyDataDiscriminatorAuthMethodNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.LDAPUserRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.LDAPUserRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.LDAPUserDataRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.LDAPUserDataRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.LocalUserRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.LocalUserRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.LocalUserDataRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.LocalUserDataRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ModelProviderJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ModelProviderNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OAuth2UserRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OAuth2UserRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OAuth2UserDataRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OAuth2UserDataRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OptimizationDirectionJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OptimizationDirectionNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OtlpDoubleValueJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OtlpDoubleValueNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OtlpKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.OtlpKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PlaygroundEvaluatorContextKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PlaygroundEvaluatorContextKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PlaygroundInstanceContextModelVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PlaygroundInstanceContextModelVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAnthropicOutputConfigEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAnthropicOutputConfigEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigAdaptiveDisplayNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigEnabledDisplayJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAnthropicThinkingConfigEnabledDisplayNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptAzureOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptFireworksInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptGoogleThinkingConfigThinkingLevelNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptGroqInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptGroqInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptMessageRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptMessageContentVariant2ItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptMessageContentVariant2ItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptMoonshotInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptMoonshotInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptOpenAIInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptPerplexityInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptPerplexityInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptTemplateFormatJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptTemplateFormatNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptTemplateTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptTemplateTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptTogetherInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptTogetherInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptToolsToolDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptToolsToolDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionTemplateDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionTemplateDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionInvocationParametersDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionInvocationParametersDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionResponseFormatVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionResponseFormatVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionDataTemplateDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionDataTemplateDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionDataInvocationParametersDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionDataInvocationParametersDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptXAIInvocationParametersContentReasoningEffortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.PromptXAIInvocationParametersContentReasoningEffortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ReasoningUIPartState2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ReasoningUIPartState2NullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SessionAnnotationSourceJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SessionAnnotationSourceNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SessionAnnotationAnnotatorKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SessionAnnotationDataAnnotatorKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SpanAnnotationSourceJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SpanAnnotationSourceNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SpanAnnotationAnnotatorKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SpanAnnotationDataAnnotatorKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SpanDocumentAnnotationDataAnnotatorKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TextUIPartState2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TextUIPartState2NullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ToolCallContentPartToolCallDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TraceAnnotationSourceJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TraceAnnotationSourceNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TraceAnnotationAnnotatorKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TraceAnnotationDataAnnotatorKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UIMessageRoleJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UIMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UpdateAnnotationConfigResponseBodyDataDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UpsertExperimentEvaluationRequestBodyAnnotatorKindNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SummarizeRequestModelDiscriminatorProviderTypeJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.SummarizeRequestModelDiscriminatorProviderTypeNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ToolCallProviderMetadataToolExecutionEnvironmentJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ToolCallProviderMetadataToolExecutionEnvironmentNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UploadDatasetRequestActionJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UploadDatasetRequestActionNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UploadDatasetRequestAction2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UploadDatasetRequestAction2NullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DeleteSpanAnnotationsAnnotatorKind2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DeleteSpanAnnotationsAnnotatorKind2NullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DeleteTraceAnnotationsAnnotatorKind2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DeleteTraceAnnotationsAnnotatorKind2NullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DeleteSessionAnnotationsAnnotatorKind2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DeleteSessionAnnotationsAnnotatorKind2NullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ListProjectTracesSortJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ListProjectTracesSortNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ListProjectTracesOrderJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ListProjectTracesOrderNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ListProjectSessionsOrderJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ListProjectSessionsOrderNullableJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatContextJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ModelJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ChatRequestJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Model2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.CreateAnnotationConfigDataJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.UserJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data3JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data4JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data5JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataItemJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataItem2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataItem3JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data6JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ModelVariant1JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ThinkingJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ContentVariant2ItemJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ToolsItemJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ToolChoiceJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.TemplateJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.InvocationParametersJsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ResponseFormatVariant1JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Template2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.InvocationParameters2JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.ResponseFormatVariant12JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.DataItem4JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Data7JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.Model3JsonConverter());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<double?, global::Phoenix.OtlpDoubleValue?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.OtlpKind?, int?, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<long?, string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<global::Phoenix.TextUIPart, global::Phoenix.ReasoningUIPart, global::Phoenix.ToolInputStreamingPart, global::Phoenix.ToolInputAvailablePart, global::Phoenix.ToolOutputAvailablePart, global::Phoenix.ToolOutputErrorPart, global::Phoenix.ToolApprovalRequestedPart, global::Phoenix.ToolApprovalRespondedPart, global::Phoenix.ToolOutputDeniedPart, global::Phoenix.DynamicToolInputStreamingPart, global::Phoenix.DynamicToolInputAvailablePart, global::Phoenix.DynamicToolOutputAvailablePart, global::Phoenix.DynamicToolOutputErrorPart, global::Phoenix.DynamicToolApprovalRequestedPart, global::Phoenix.DynamicToolApprovalRespondedPart, global::Phoenix.DynamicToolOutputDeniedPart, global::Phoenix.SourceUrlUIPart, global::Phoenix.SourceDocumentUIPart, global::Phoenix.FileUIPart, global::Phoenix.DataUIPart, global::Phoenix.StepStartUIPart>());
            options.Converters.Add(new global::Phoenix.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Phoenix.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.OneOfJsonConverter<string, object>());
            options.Converters.Add(new global::Phoenix.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}