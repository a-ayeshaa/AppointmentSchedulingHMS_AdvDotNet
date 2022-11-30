using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Specialization { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Degree { get; set; }

        [Required]
        [StringLength(100)]
        public string VisitingDays { get; set; }

        [Required]
        [Range(500,3000)]
        public float Appointment_Fees { get; set; }
        public float? Net_Earnings { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
