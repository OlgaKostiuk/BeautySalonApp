using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautySalon.Models
{
    public class PageRequestModel
    {
        public int CountPerPage { get; set; } = 5;
        public int PageNumber { get; set; } = 1;
    }
}