using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalManagementSystem
{
   public class Doctor
    {
        [Key]
        public int DocID { get; set; }
        [Required]
        public string DocName { get; set; }
        public string DocSpciality { get; set; }
        public string DocLocation { get; set; }
        [MaxLength(12)]
        public string DocPassword { get; set; }
        public ICollection<Doctor_Pateint> doctor_Pateints { get; set; }
    }
}
