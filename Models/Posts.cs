using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VetPet.Models
{
    public class Posts
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Media { get; set; } // JSON or comma-separated URLs
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Likes { get; set; }
        public int CommentsCount { get; set; }
        public string PostType { get; set; } // 'blog', 'question', 'experience'

        // Navigation Properties
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
