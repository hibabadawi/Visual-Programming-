using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalManagementSystem
{
  public  class Consultant : Doctor
    {
        
        public string Clinic_Name { get; set; }
    }
}

