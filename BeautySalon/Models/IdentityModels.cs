﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using BeautySalon.Models.Feedbacks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BeautySalon.Models
{
    public static class RoleTypes
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim(ClaimTypes.Name, this.Name));
            userIdentity.AddClaim(new Claim(ClaimTypes.Gender, this.Gender));
            return userIdentity;
        }

        public string Name { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public ApplicationUser()
        {
            Feedbacks = new HashSet<Feedback>();
        }
    }
}