using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautySalon.Models.Feedbacks
{
    public class FeedbackViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Отзыв")]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string UserName { get; set; }
    }
}