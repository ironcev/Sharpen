﻿using System.ComponentModel.Design;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.LanguageServices;
using Sharpen.Engine.CodeDetection;
using Sharpen.Engine.Analysis;

namespace Sharpen.VisualStudioExtension.Commands
{
    /// <summary>
    /// Contains shared services required by Sharpen extension commands.
    /// </summary>
    internal interface ICommandServicesContainer
    {
        AsyncPackage Package { get; }
        IAsyncServiceProvider ServiceProvider { get; }
        VisualStudioWorkspace Workspace { get; }
        EnvDTE80.DTE2 VisualStudioIde { get; }
        IMenuCommandService MenuCommandService { get; }
        SharpenExtensionService SharpenExtensionService { get; }
        IGeneratedCodeDetector GeneratedCodeDetector { get; }
        IScopeAnalyzerCreator ScopeAnalyzerCreator { get; }
    }
}