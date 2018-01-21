using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautySalon.Models.Promotions
{
    public class CreatePromotionViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Полное описание")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Начало действия акции:")]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "Окончания действия акции:")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Картинки")]
        public IList<PromotionImage> Images { get; set; }
    }


}
