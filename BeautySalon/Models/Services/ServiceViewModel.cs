using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautySalon.Models.Services
{
    public class ServiceViewModel
    {
        public ServiceCategory Category { get; set; }

        public List<Service> Services { get; set; }
    }
}