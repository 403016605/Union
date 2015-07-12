using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Union.Admin.Entities
{
    /// <summary>
    ///     角色
    /// </summary>
    public class Role : Entity
    {
        [Description("角色"), Required]
        public string Name { get; set; }

        [Description("描述"), Required]
        public string Description { get; set; }

        [Description("人员")]
        public virtual ICollection<Person> Persons { get; set; }

        [Description("部门")]
        public virtual ICollection<Department> Departments { get; set; }

        [Description("菜单")]
        public virtual ICollection<Menu> Menus { get; set; }

        [Description("操作")]
        public virtual ICollection<Operation> Operations { get; set; }

        [Description("包含的流程状态")]
        public virtual ICollection<WorkflowNode> WorkflowNodes { get; set; }
    }
}