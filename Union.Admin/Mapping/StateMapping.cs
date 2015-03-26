using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("StateMapping")]
    internal class StateMapping : Mapping<State>
    {
        public StateMapping()
        {
            //HasMany(r => r.Departments);
            //HasMany(r => r.Menus);
            //HasMany(r => r.Persons);
            //HasMany(r => r.Operations);
        }
    }
}