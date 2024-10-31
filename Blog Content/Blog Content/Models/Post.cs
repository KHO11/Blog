using System;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DatePosted { get; set; } = DateTime.Now;
    }
}
