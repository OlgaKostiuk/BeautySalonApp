using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautySalon.Models.Services
{
    public class ServiceViewModel
    {
        [Key]
        public int Id { get; set; }

        public ServiceCategory Category { get; set; }

        public List<Service> Services { get; set; }
    }
}