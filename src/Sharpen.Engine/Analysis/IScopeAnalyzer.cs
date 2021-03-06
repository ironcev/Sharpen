﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sharpen.Engine.Analysis
{
    public interface IScopeAnalyzer
    {
        bool CanExecuteScopeAnalysis(out string errorMessage);
        int GetAnalysisMaximumProgress();
        Task<IEnumerable<AnalysisResult>> AnalyzeScopeAsync(IProgress<int> progress);
    }
}
