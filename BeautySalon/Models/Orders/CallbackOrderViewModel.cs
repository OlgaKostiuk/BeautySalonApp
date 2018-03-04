using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautySalon.Models.Orders
{
    public class CallbackOrderViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется ввести имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Требуется ввести номер телефона")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Неверный формат номера телефона")]
        public string PhoneNumber { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsPending { get; set; }
    }
}