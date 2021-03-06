﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEngine.Core.Models
{
    [Table("comment")]
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public string Author { get; set; }

        public DateTime DataCreated { get; set; }
    }
}
