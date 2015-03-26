using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Union.Core.Base;

namespace Union.Admin.Entities
{
    public class State : EntityBase
    {
        [Description("名称"), Required]
        public string Name { get; set; }

        [Description("编码"), Required]
        public string Code { get; set; }

        [Description("描述")]
        public string Description { get; set; }
    }
}