using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Union.Admin.Entities
{
    /// <summary>
    /// 菜单
    /// </summary>
    public partial class Menu : Entity
    {
        [Description("菜单"), Required]
        public string Name { get; set; }

        [Description("地址")]
        public string Url { get; set; }

        [Description("图标")]
        public string Icon { get; set; }

        [Description("描述")]
        public string Description { get; set; }

        [Description("上级")]
        public Guid? ParentId { get; set; }

        [Description("上级")]
        public virtual Menu Parent { get; set; }

        [Description("下级")]
        public virtual ICollection<Menu> Menus { get; set; }

        [Description("操作")]
        public virtual ICollection<Operation> Operations { get; set; }

        [Description("角色")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}