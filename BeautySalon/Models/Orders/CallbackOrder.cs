using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautySalon.Models.Orders
{
    public class CallbackOrder
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsPending { get; set; }
    }
}