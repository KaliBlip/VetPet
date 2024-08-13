using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetPet.Models
{
    public class VetConsultation
    {
        public Guid ConsultationId { get; set; }
        public Guid VetId { get; set; }  // Foreign key to User with userType 'vet'
        public Guid UserId { get; set; } // Foreign key to User
        public string ConsultationType { get; set; } // 'online', 'in-person'
        public DateTime AppointmentTime { get; set; }
        public string Status { get; set; } // 'pending', 'completed', 'cancelled'
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation Properties
        public User Vet { get; set; }  // Vet assigned to the consultation
        public User User { get; set; } // User who booked the consultation
    }

}
