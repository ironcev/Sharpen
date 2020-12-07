﻿namespace Sharpen.Engine.SharpenSuggestions.CSharp80.NullableReferenceTypes.Suggestions
{
    internal abstract class BaseEnableNullableContextAndDeclareIdentifierAsNullableSuggestion : ISharpenSuggestion
    {
        public string MinimumLanguageVersion { get; } = CSharpLanguageVersions.CSharp80;
        public ICSharpFeature LanguageFeature { get; } = CSharpFeatures.NullableReferenceTypes.Instance;
        public abstract string FriendlyName { get; }
        public SharpenSuggestionType SuggestionType { get; } = SharpenSuggestionType.Recommendation;
    }
}
