using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data.Entity;

namespace Union.Core.Base
{
    public abstract class BaseContextBase<T> : DbContext, IUnitOfWork where T : IMapping
    {
        protected BaseContextBase(string conn)
            : base(conn)
        {
            InitConfiguration();

            InitDataBaseStrategy();

            InitMapping();
        }

        public int Save()
        {
            return SaveChanges();
        }

        public abstract void InitConfiguration();

        public abstract void InitDataBaseStrategy();

        public void InitMapping()
        {
            //加载目录下所有IMapping实现
            var catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory);
            var container = new CompositionContainer(catalog);
            _list = container.GetExportedValues<T>();
        }

        [ImportMany]
        IEnumerable<T> _list;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // 动态地加入实体
            if (_list == null) return;

            foreach (var r in _list)
            {
                r.RegistTo(modelBuilder.Configurations);
            }
        }
    }
}