using System;
using System.ComponentModel;
using Union.Core.Base;

namespace Union.Admin.Entities
{
    public abstract class Entity : EntityBase
    {
        #region 实体基本属性

        //[Key]
        //[Description("主键")]
        //public TKey Id { get; protected set; }

        [Description("创建时间")]
        public DateTime CreateTime { get; protected set; }

        [Description("创建人员")]
        public string CreatePerson { get; set; }

        [Description("编辑时间")]
        public DateTime UpdateTime { get; set; }

        [Description("编辑人员")]
        public string UpdatePerson { get; set; }

        [Description("顺序")]
        public int Sort { get; set; }

        #endregion 实体基本属性
    }
}