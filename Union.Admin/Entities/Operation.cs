using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Union.Admin.Entities
{
    /// <summary>
    ///     ����
    /// </summary>
    public class Operation : Entity
    {
        [Description("����"), Required]
        public string Name { get; set; }

        [Description("����"), Required]
        public string Function { get; set; }

        [Description("ͼ��")]
        public string Icon { get; set; }

        [Description("����"), Required]
        public string Description { get; set; }

        [Description("������"), Required]
        public string ActionCode { get; set; }

        [Description("�˵�")]
        public virtual ICollection<Menu> Menus { get; set; }

        [Description("��ɫ")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}