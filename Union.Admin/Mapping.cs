using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using Union.Core;

namespace Union.Admin
{
    internal class Mapping<TEntity> : EntityTypeConfiguration<TEntity>, IAdminMapping
    where TEntity : class,IEntity
    {
        public Mapping()
        {
            Map(m => m.ToTable(typeof(TEntity).Name));
        }

        public void RegistTo(ConfigurationRegistrar configurationRegistrar)
        {
            configurationRegistrar.Add(this);
        }
    }
}
