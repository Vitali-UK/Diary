﻿using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title!")]
        [StringLength(100, MinimumLength = 3 ,ErrorMessage = "Title should be between 3 and 100 characters!")]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateOnly Created { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
