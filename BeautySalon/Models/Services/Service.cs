﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Models.Services
{
    public class Service
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ClientGender { get; set; }

        public decimal Price { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual ServiceCategory Category { get; set; }
    }
}