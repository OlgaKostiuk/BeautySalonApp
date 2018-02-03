using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautySalon.Models.Promotions
{
    public class PromotionViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [AllowHtml]
        [Display(Name = "Полное описание")]
        public string Description { get; set; }

        [Display(Name = "Начало действия акции:")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        //[DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Окончание действия акции:")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        //[DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Картинки")]
        public IList<PromotionImage> Images { get; set; }
    }


}
