using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Union.Core.Base;

namespace Union.Admin.Entities
{
    public class WorkflowNode : EntityBase
    {
        [Description("名称"), Required]
        public string Name { get; set; }

        [Description("编码"), Required]
        public string Code { get; set; }

        [Description("描述")]
        public string Description { get; set; }

        [Description("退单")]
        public Guid? RejectId { get; set; }

        [Description("状态")]
        public virtual State State { get; set; }

        [Description("角色")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}