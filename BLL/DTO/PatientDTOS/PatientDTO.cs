using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.PatientDTOS
{
    public class PatientDTO
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
        public int UserId { get; set; }

    }
}
