using System;
using System.Collections.Generic;
using System.ComponentModel;
using Union.Share.Extension;

namespace Union.Admin.Entities
{
    /// <summary>
    ///     部门
    /// </summary>
    public class Department : Entity
    {
        public Department()
        {
            Id = Guid.NewGuid();
            CreateTime = DateTime.Now.CurrentNow();
        }

        [Description("上级")]
        public Guid? ParentId { get; set; }

        [Description("部门名称")]
        public string Name { get; set; }

        [Description("部门编码")]
        public string Code { get; set; }

        [Description("上级")]
        public virtual Department Parent { get; set; }

        [Description("下级")]
        public virtual ICollection<Department> Departments { get; set; }

        [Description("人员")]
        public virtual ICollection<Person> Persons { get; set; }

        [Description("角色")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}