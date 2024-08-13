using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetPet.Models
{
    public class Listing
    {
        public Guid ListingId { get; set; }
        public Guid UserId { get; set; }  // Foreign key to User
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; } // 'pet', 'accessory', 'service'
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string ContactInfo { get; set; }
        public string Media { get; set; } // JSON or comma-separated URLs
        public string Status { get; set; } // 'available', 'sold'
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation Properties
        public User User { get; set; }  // Each Listing belongs to one User
    }

}
