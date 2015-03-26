using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("RoleMapping")]
    internal class RoleMapping : Mapping<Role>
    {
        public RoleMapping()
        {
            //HasMany(r => r.Departments);
            //HasMany(r => r.Menus);
            //HasMany(r => r.Persons);
            //HasMany(r => r.Operations);
        }
    }
}