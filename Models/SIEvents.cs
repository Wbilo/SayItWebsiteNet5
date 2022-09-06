using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SayItWebsiteNet5.Models
{
    public class SIEvents
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Required]
        [MinLength(1)]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Dato")]
        public DateTime Date { get; set; }
        public List<Student> Participants {get;set;}
        [MinLength(1)]
        [Required]
        [Display(Name = "Beskrivelse")]
        public string Description { get; set; }
        [MinLength(1)]
        [Required]
        [Display(Name = "Lokation")]
        public string Location { get; set; }
        [Display(Name = "Arrangør" )]
        public string Creator { get; set; }
        



    }
}
