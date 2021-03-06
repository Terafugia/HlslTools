﻿using System.Threading.Tasks;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;
using Xunit;

namespace ShaderTools.Editor.VisualStudio.Tests.Hlsl.Tagging.Classification
{
#if false
    public class SemanticTaggerTests : AsyncTaggerTestsBase
    {
        private readonly HlslClassificationService _hlslClassificationService;

        public SemanticTaggerTests()
        {
            _hlslClassificationService = Container.GetExportedValue<HlslClassificationService>();
        }

        [Theory(Skip = "Need to update test")]
        //[HlslTestSuiteData]
        public async Task CanDoTagging(string testFile)
        {
            await RunTestAsync<SemanticTagger, IClassificationTag>(testFile, CreateTagger);
        }

        private SemanticTagger CreateTagger(BackgroundParser backgroundParser, ITextBuffer textBuffer)
        {
            return new SemanticTagger(_hlslClassificationService, backgroundParser);
        }
    }
#endif
}