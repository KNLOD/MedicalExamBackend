using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;

namespace MedicalExaminationWebApi.Models
{
    public class Examination
    {
        [Key]
        public int id{get; set;}

        [Column(TypeName="integer")]
        public int cholesterol{get; set;}

        [Column(TypeName="integer")]
        public int createnin{get; set;}

        [Column(TypeName="integer")]
        public int glucose{get; set;}

        [Column(TypeName="integer")]
        public int glucosed_hymoglobin{get; set;}

        [Column(TypeName="integer")]
        public int homocystein {get; set;}

        [Column(TypeName="integer")]
        public int c_reactive_protein{get; set;}
        
    }
}