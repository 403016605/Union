using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("WorkflowTypeMapping")]
    internal class WorkflowTypeMapping : Mapping<WorkflowType>
    {
    }
}