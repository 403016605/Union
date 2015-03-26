using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Union.Admin.Entities
{
    /// <summary>
    /// 人员
    /// </summary>
    public class Person : Entity
    {
        [Description("账号"), Required]
        public string Account { get; set; }

        [Description("姓名"), Required]
        public string Name { get; set; }

        [Description("密码"), Required]
        public string Password { get; set; }

        [Description("性别"), Required]
        public bool Sex { get; set; }

        [Description("状态"), Required]
        public bool State { get; set; }

        [Description("部门")]
        public Guid DepartmentId { get; set; }

        [Description("部门"), Required]
        public virtual Department Department { get; set; }

        [Description("角色")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}
