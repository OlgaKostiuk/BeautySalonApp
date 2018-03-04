using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BeautySalon.Models.Orders;

namespace BeautySalon.Models.Services
{
    public class Service
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual ServiceCategory Category { get; set; }

        public virtual ICollection<ServiceSubtype> Subtypes { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

        public Service()
        {
            Subtypes = new HashSet<ServiceSubtype>();
            Bookings = new HashSet<Booking>();
        }
    }
}