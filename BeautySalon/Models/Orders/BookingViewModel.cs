using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BeautySalon.Models.Services;

namespace BeautySalon.Models.Orders
{
    public class BookingViewModel
    {
        //public List<ServiceViewModel> ServiceList;

        public int Id { get; set; }

        [Required(ErrorMessage = "Требуется ввести дату")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Требуется ввести время")]
        public DateTime Time { get; set; }

        public DateTime BookingDateTime { get; set; }

        [Required(ErrorMessage = "Требуется ввести имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Требуется ввести номер телефона")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Неверный формат номера телефона")]
        public string PhoneNumber { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Требуется выбрать услугу")]
        public int ServiceId { get; set; }
    }
}