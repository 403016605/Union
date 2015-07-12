using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("RoleMapping")]
    internal class RoleMapping : Mapping<Role>
    {
    }
}