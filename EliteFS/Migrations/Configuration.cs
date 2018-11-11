namespace EliteFS.Migrations
{
    using EliteFS.EliteModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EliteFS.Models.EliteDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EliteFS.Models.EliteDbContext";
        }

        protected override void Seed(EliteFS.Models.EliteDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var categories = new List<Category>
            {
                    new Category{ CategoryName = "Hat" },
                    new Category{ CategoryName = "Dress" },
                    new Category{ CategoryName = "Wallet" },
                    new Category{ CategoryName = "Clothes" },
                    new Category{ CategoryName = "Wallet" },
                    new Category{ CategoryName = "Bag" },
                    new Category{ CategoryName = "Sunglasses" },
                    new Category{ CategoryName = "Swimwear" }
             };
            categories.ForEach(s => context.Categories.AddOrUpdate(
                p => p.CategoryName, s
                ));
            context.SaveChanges();
        }
    }
}
