using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VetPet.Models
{
    
    
        public class User
        {
            public Guid UserId { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string PasswordHash { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ProfilePicture { get; set; }
            public string UserType { get; set; } // 'regular', 'vet', 'admin'
            public string Bio { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }

            // Navigation Properties
            public ICollection<Posts> Posts { get; set; }
            public ICollection<Listing> Listings { get; set; }
            public ICollection<Comment> Comments { get; set; }



            public ICollection<Listing> Listing { get; set; }
            public ICollection<VetConsultation> VetConsultations { get; set; }
            public ICollection<LostFound> LostFounds { get; set; }
            public ICollection<Service> Services { get; set; }
        }
    }

    
