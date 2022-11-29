using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.EF.Models
{
//    id
//user_id
//name
//dob
//registeredAt
//gender
//phone
//blood_group
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]

        public DateTime RegisteredAt { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [Required]
        [StringLength(3)]
        public string BloodGroup { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
