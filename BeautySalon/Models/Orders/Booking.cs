using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BeautySalon.Models.Services;

namespace BeautySalon.Models.Orders
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public DateTime BookingDateTime { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsPending { get; set; }

        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }
    }
}