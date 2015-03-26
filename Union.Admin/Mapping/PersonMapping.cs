using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("PersonMapping")]
    internal class PersonMapping : Mapping<Person>
    {
        public PersonMapping()
        {
            //一个人员对一个部门；一个部门对多个人员；支持级联删除
            //this.HasRequired(p=>p.Department).WithMany(d=>d.Persons).WillCascadeOnDelete(true);
        }
    }
}