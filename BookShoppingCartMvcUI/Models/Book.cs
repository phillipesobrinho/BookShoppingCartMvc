﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string BookName { get; set; }
        public double Price { get; set; }

        public string? Image { get; set; }

        [Required]
        public int GenreId { get; set; }

        // Navigation property for the Genre entity
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        public List<OrderDetail> CartDetail{ get; set; }
    }
}
