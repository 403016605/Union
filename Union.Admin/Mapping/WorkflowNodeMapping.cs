using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("WorkflowNodeMapping")]
    internal class WorkflowNodeMapping : Mapping<WorkflowNode>
    {
    }
}