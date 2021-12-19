using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalManagementSystem
{
    public enum Gender { Male, female }
    public class Patient
    {

        [Key]
        public int PatID  { get; set; }
        [Required]
        public string PatName { get; set; }
        public  Gender gender  { get; set; }
        public string PatDOB { get; set; }
        public DateTime Enternace_Time { get; set; }
        public string Sickness { get; set; }
        public string Perception { get; set; }
        public Section Section { get; set; }
        public ICollection<Doctor_Pateint> doctor_Pateints { get; set; }
    }
}
