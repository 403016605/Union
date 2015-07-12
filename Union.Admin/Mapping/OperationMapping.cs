using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("OperationMapping")]
    internal class OperationMapping : Mapping<Operation>
    {
    }
}