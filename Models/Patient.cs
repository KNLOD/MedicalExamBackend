using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace MedicalExaminationWebApi.Models
{
    public class Patient
    {
        [Key]
        public int id{get; set;}

        [Column(TypeName="nvarchar(50)")]
        public string name{get; set;}

        [Column(TypeName="nvarchar(50)")]
        public string lastName{get; set;}

        [Column(TypeName="nvarchar(50)")]
        public string patronym{get; set;}

        [Column(TypeName="nvarchar(50)")]
        public string birthday{get; set;}
        
    }
}