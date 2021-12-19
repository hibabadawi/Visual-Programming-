using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem
{
    class HospContext : DbContext
    {

            public DbSet<Doctor> Doctors { get; set; }
            public DbSet<Patient> Patients { get; set; }
            public DbSet<Hospital> Hospitals { get; set; }
            public DbSet<Junior> Juniors { get; set; }
            public DbSet<Consultant> Consultants { get; set; }
            public DbSet<Section> sections { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionBuilder.UseSqlServer(@"Server=DESKTOP-BEV00GS\HBDB;Database=Hospital;Trusted_connection=True;");
            }

        }
}
