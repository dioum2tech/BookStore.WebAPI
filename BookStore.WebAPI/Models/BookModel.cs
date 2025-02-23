﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
