using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Union.Share;


namespace Union.Core
{
    public interface IRepository<T> where T:IEntity
    {
        #region 查询

        IEquatable<T> Query(Expression<Func<T, bool>> predicate);

        PageResult Page(PageInfo pageInfo, Expression<Func<T, bool>> predicate);

        #endregion

        #region 创建

        bool Create(T entity);

        int Create(List<T> entities);

        #endregion

        #region 编辑

        bool Edit(T entity);

        int Edit(Expression<Func<T, bool>> predicate,Dictionary<string, object> fields);

        #endregion

        #region 删除

        int Delete(Expression<Func<T, bool>> predicate);

        #endregion
    }
}