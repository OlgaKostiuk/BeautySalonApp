using System;
using System.Collections.Generic;

namespace BeautySalon.Models.Promotions
{
    public class Promotion
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        
        public virtual bool IsDeleted { get; set; }

        public virtual ICollection<PromotionImage> Images { get; set; }

        public Promotion()
        {
                Images = new HashSet<PromotionImage>();
        }
    }
}