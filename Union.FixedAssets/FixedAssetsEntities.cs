using System.Data.Entity;
using Union.Core.Base;

namespace Union.FixedAssets
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class FixedAssetsEntities : ContextBase<IFixedAssetsMapping>
    {
        public FixedAssetsEntities(string conn)
            : base(conn)
        {

        }

        public FixedAssetsEntities()
            : base("name=FixedAssetsEntities")
        {

        }

        public override void InitConfiguration()
        {
            Configuration.ProxyCreationEnabled = false;

            Configuration.LazyLoadingEnabled = false;
        }

        public override void InitDataBaseStrategy()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FixedAssetsEntities, BaseMigrationsConfiguration<FixedAssetsEntities>>());
        }
    }
}