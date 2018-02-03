using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeautySalon.Models.Promotions
{
    public class PromotionImage
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(Promotion))]
        public int PromotionId { get; set; }
        public virtual Promotion Promotion { get; set; }
    }
}