using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Reflection;

namespace Union.Core.Base
{
    public abstract class EntityBase : IEntity
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        #region 实体基本属性

        [Key]
        [Description("主键")]
        public Guid Id { get; protected set; }

        #endregion 实体基本属性

        public virtual ExpandoObject ToExpandoObject()
        {
            var type = GetType();

            var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            IDictionary<string, object> result = new ExpandoObject();

            foreach (var property in properties)
            {
                result.Add(property.Name, property.GetValue(this, null));
            }

            return result as ExpandoObject;
        }
    }
}