using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("DepartmentMapping")]
    internal class DepartmentMapping : Mapping<Department>
    {
    }
}