using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdcb.TypeScript.TsTypes;

namespace EventHorizon.Blazor.TypeScript.Interop.Generator.Rules
{
    public class IsStatic
        : IRule
    {
        public bool Check(Node node)
        {
            return node.Children.Count(
                a => a.Kind == SyntaxKind.StaticKeyword
            ) > 0;
        }
    }
}
