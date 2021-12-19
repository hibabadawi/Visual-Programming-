using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalManagementSystem
{
    public class Hospital
    {
       [Key]
        public int ID { get; set; }
        [Required]
        public string HospName { get; set; }
        public string HospLocation { get; set; }
        public string HospType { get; set; }

        public ICollection<Section> Sections { get; set; }

    }
}
