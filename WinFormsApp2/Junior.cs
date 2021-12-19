using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalManagementSystem
{
    class Junior
    {
        [Key]
        public int ID { get; set; }
        public int Degree { get; set; }
    }
}
