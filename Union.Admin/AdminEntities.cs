using System.Data.Entity;
using Union.Core.Base;

namespace Union.Admin
{
    public class AdminEntities : BaseContextBase<IAdminMapping>
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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AdminEntities, BaseMigrationsConfiguration<AdminEntities>>());
        }
    }
}