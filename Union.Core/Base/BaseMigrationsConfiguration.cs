using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Union.Core.Base
{
    public class BaseMigrationsConfiguration<T> : DbMigrationsConfiguration<T> where T : DbContext
    {
        public BaseMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;

            this.AutomaticMigrationsEnabled = true;
        }
    }
}