// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Editor.Commands;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.EditorUtilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Editor.UnitTests.Commands
{
    public class TypeCharCommandArgsTests
    {
        [Fact]
        public void TestTypedCharProperty()
        {
            var view = EditorFactory.CreateView(TestExportProvider.ExportProviderWithCSharpAndVisualBasic, "class C { }");

            var args = new TypeCharCommandArgs(view, view.TextBuffer, 'c');
            Assert.Equal('c', args.TypedChar);
        }
    }
}
