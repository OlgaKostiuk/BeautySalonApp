using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeautySalon.Models.Promotions
{
    public class PromotionImage
    {
        public virtual int Id { get; set; }

        public virtual string Path { get; set; }

        public virtual bool IsDeleted { get; set; }

        [ForeignKey(nameof(Promotion))]
        public virtual int PromotionId { get; set; }
        public Promotion Promotion { get; set; }
    }
}