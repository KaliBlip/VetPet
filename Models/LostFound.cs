using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetPet.Models
{
    public class LostFound
    {
        public Guid ReportId { get; set; }
        public Guid UserId { get; set; }  // Foreign key to User
        public string PetName { get; set; }
        public string Type { get; set; } // 'lost', 'found'
        public string Description { get; set; }
        public string LastSeenLocation { get; set; }
        public string Status { get; set; } // 'open', 'resolved'
        public string Media { get; set; } // JSON or comma-separated URLs
        public string MapCoordinates { get; set; } // JSON format for latitude and longitude
        public DateTime CreatedAt { get; set; }

        // Navigation Properties
        public User User { get; set; }  // Each report belongs to one User
    }

}
