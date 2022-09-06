using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SayItWebsiteNet5.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SayItWebsiteNet5.Models
{
    public class Student
    {

        [BsonId]
        public Guid _Id { get; set; }
        [Required]
        [DisplayName("Navn")]
        public string Name { get; set; }
        [DisplayName("Efternavn")]
        public string Surname { get; set; }
        [DisplayName("Start Dato")]
        public DateTime EnrollmentCreated { get; set; }
        public int DaysTotal { get; set; }
        public int AbsentDaysTotal { get; set; }
        [DisplayName("Fravær")]
        public float Absence { get; set; }
        [DisplayName("Noter")] 
        public List<Note> Notes { get; set; }
        [DisplayName("Roller")]
        public List<string> Roles { get; set; }
        [DisplayName("Kursist Status")]
        public bool Active { get; set; }
        public List<SIEvents> ActiveEvents { get; set; }
    }
}

