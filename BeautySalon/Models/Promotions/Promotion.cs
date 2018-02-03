using System;
using System.Collections.Generic;

namespace BeautySalon.Models.Promotions
{
    public class Promotion
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        
        public bool IsDeleted { get; set; }

        public virtual ICollection<PromotionImage> Images { get; set; }

        public Promotion()
        {
                Images = new HashSet<PromotionImage>();
        }
    }
}