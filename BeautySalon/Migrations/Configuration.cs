using System.Collections.Generic;
using BeautySalon.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BeautySalon.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BeautySalon.Models.ApplicationDbContext";
        }

        protected override void Seed(BeautySalon.Models.ApplicationDbContext context)
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

            //// Initialize default identity roles
            //var roleStore = new RoleStore<IdentityRole>(context);
            //var roleManager = new RoleManager<IdentityRole>(roleStore);
            //// RoleTypes is a class containing constant string values for different roles
            //List<IdentityRole> identityRoles = new List<IdentityRole>();
            //identityRoles.Add(new IdentityRole() { Name = RoleTypes.Admin });
            //identityRoles.Add(new IdentityRole() { Name = RoleTypes.User });

            //foreach (IdentityRole role in identityRoles)
            //{
            //    roleManager.Create(role);
            //}

            //// Initialize default user
            //var userStore = new UserStore<ApplicationUser>(context);
            //var userManager = new UserManager<ApplicationUser>(userStore);
            //ApplicationUser admin = new ApplicationUser();
            //admin.Email = "admin@admin.com";
            //admin.UserName = "admin@admin.com";

            //userManager.Create(admin, "1Admin!");
            //userManager.AddToRole(admin.Id, RoleTypes.Admin);

            //// Add code to initialize context tables

            //base.Seed(context);
        }
    }
}
