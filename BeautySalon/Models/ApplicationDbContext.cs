using System.Data.Entity;
using BeautySalon.Models.Feedbacks;
using BeautySalon.Models.Orders;
using BeautySalon.Models.Promotions;
using BeautySalon.Models.Services;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BeautySalon.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<PromotionImage> PromotionImage { get; set; }

        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<CallbackOrder> CallbackOrders { get; set; }
    }
}