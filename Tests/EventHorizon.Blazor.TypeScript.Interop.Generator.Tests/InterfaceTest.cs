using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using Sdcb.TypeScript;
using Xunit;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Tests.GenerateClassStatementStringTests
{
    public class InterfaceTest
    {
        [Fact]
        public void ShouldGenerateInterfaceString()
        {
            // Given
            var sourceFile = "interface.ts";
            var source = File.ReadAllText($"./SourceFiles/{sourceFile}");
            var expected = File.ReadAllText($"./ExpectedResults/interface.Expected.txt");
            var ast = new TypeScriptAST(source, sourceFile);
            var typeOverrideMap = new Dictionary<string, string>();

            // When
            var generated = GenerateInteropClassStatement.Generate(
                "ProjectAssembly",
                "ExampleInterface",
                ast,
                typeOverrideMap
            );
            var actual = GenerateClassStatementString.Generate(
                generated
            );

            // Then
            actual.Should().Be(
                expected
            );
        }
    }
}
