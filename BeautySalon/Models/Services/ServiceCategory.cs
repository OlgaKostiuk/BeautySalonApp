using System.Collections.Generic;

namespace BeautySalon.Models.Services
{
    public class ServiceCategory
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string GenderAffiliation { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public ServiceCategory()
        {
            Services = new HashSet<Service>();
        }
    }

    public static class GenderAffiliation
    {
        public const string ForMen = "для мужчин";
        public const string ForWomen = "для женщин";
    }
}