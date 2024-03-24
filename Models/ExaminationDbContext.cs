using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MedicalExaminationWebApi.Models
{
    public class ExaminationDbContext:DbContext
    {
        public ExaminationDbContext(DbContextOptions<ExaminationDbContext> options):base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Examination> Examinations { get; set;}

        
    }
}