using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEngine.Core.Models
{
    [Table("user")]
    public class User 
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string OldPassword { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}