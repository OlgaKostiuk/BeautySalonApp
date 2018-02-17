using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautySalon.Models
{
    public class PageViewModel<T>
    {
        public List<T> Data { get; set; }
        public int Count { get; set; }
    }
}