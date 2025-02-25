﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    /// <summary>
    /// Category
    /// </summary>
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 to 100")]
        public int DisplayOrder { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
