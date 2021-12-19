using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalManagementSystem
{
   public class Section
    {
        [Key]
        public int SecID { get; set; }
        public string SecName { get; set; }
        public string patients_gender { get; set; }
        public string patient_capacity { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
