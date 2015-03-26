using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("WorkflowTypeMapping")]
    internal class WorkflowTypeMapping : Mapping<WorkflowType>
    {
        public WorkflowTypeMapping()
        {
            //HasMany(r => r.Departments);
            //HasMany(r => r.Menus);
            //HasMany(r => r.Persons);
            //HasMany(r => r.Operations);
        }
    }
}