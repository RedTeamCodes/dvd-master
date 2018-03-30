namespace DVDStore.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DVDStore.Data.Models.DVDStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(DVDStore.Data.Models.DVDStoreContext context)
        {
        


        }
    }
}
