using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Union.Admin.Entities
{
    /// <summary>
    ///     操作
    /// </summary>
    public class Operation : Entity
    {
        [Description("操作"), Required]
        public string Name { get; set; }

        [Description("方法"), Required]
        public string Function { get; set; }

        [Description("图标")]
        public string Icon { get; set; }

        [Description("描述"), Required]
        public string Description { get; set; }

        [Description("操作码"), Required]
        public string ActionCode { get; set; }

        [Description("菜单")]
        public virtual ICollection<Menu> Menus { get; set; }

        [Description("角色")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}