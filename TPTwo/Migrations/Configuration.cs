namespace TPTwo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TPTwo.Models.MobileServiceContext>
    {
        public Configuration()
        {

            //TOGGLE 1
            AutomaticMigrationsEnabled = true;

            //TOGGLE 2
            //AutomaticMigrationsEnabled = false;
            //step 2 in changing model
            AutomaticMigrationDataLossAllowed = true;


        }

        protected override void Seed(TPTwo.Models.MobileServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
