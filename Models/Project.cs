using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SayItWebsiteNet5.Models
{
    public class Project
    {

        [BsonId]
        public BsonObjectId Id { get; set; }
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Beskrivelse")]
        public string Description { get; set; }

        [Display(Name ="Status")]
        public bool Active { get; set; }
       
        [Display(Name = "Ejer")]
        public Student Owner { get; set; }

        [Display(Name = "Medvirkende")]
        public List<Student> Participants { get; set; }
    }
}
