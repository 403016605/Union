using System.Data.Entity;
using MySql.Data.Entity;
using Union.Core.Base;

namespace Union.Admin
{
    [DbConfigurationType(typeof (MySqlEFConfiguration))]
    public class AdminEntities : ContextBase<IAdminMapping>
    {
        public AdminEntities(string conn)
            : base(conn)
        {
        }

        public AdminEntities()
            : base("name=AdminEntities")
        {
        }

        public override void InitConfiguration()
        {
            Configuration.ProxyCreationEnabled = false;

            Configuration.LazyLoadingEnabled = false;
        }

        public override void InitDataBaseStrategy()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<AdminEntities, BaseMigrationsConfiguration<AdminEntities>>());
        }
    }
}