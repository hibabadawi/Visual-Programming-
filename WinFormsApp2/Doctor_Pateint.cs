using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
   public class Doctor_Pateint
    {
        public int ID { get; set; }
        public Patient Patient { get; set; }
        public int DocID { get; set; }
        public Doctor Doctor { get; set; }
        public string diagnose { get; set; }
    }
}
