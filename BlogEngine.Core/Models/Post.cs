using System;
using System.Collections;
using System.Collections.Generic;

namespace BlogEngine.Core.Models
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
