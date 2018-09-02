namespace CreaciónDeCRUDconCsharpUsandoMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CreaciónDeCRUDconCsharpUsandoMVC.Context.DataStore>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;//evita perdida de datos
            ContextKey = "CreaciónDeCRUDconCsharpUsandoMVC.Context.DataStore";
        }

        protected override void Seed(CreaciónDeCRUDconCsharpUsandoMVC.Context.DataStore context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
