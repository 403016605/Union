using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("WorkflowNodeMapping")]
    internal class WorkflowNodeMapping : Mapping<WorkflowNode>
    {
        public WorkflowNodeMapping()
        {
            //HasMany(r => r.Departments);
            //HasMany(r => r.Menus);
            //HasMany(r => r.Persons);
            //HasMany(r => r.Operations);
        }
    }
}