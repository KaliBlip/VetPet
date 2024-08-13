using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetPet.Models
{
    public class Service
    {
        public Guid ServiceId { get; set; }
        public Guid UserId { get; set; }  // Foreign key to User
        public string ServiceType { get; set; } // 'pet sitting', 'walking', 'training', 'grooming'
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string ContactInfo { get; set; }
        public string Availability { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation Properties
        public User User { get; set; }  // Each service belongs to one User
    }

}
