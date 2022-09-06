using SayItWebsiteNet5.Models;
using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;
using SayItWebsiteNet5.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SayItWebsiteNet5.Models
{
    public class Protocol
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int? WeekNumber { get; set; }
        public Dictionary<string, ProtocolData> StudentProtocol { get; set; }
        [DisplayName("Dato")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        [BindProperty]
        // Dato for skabelsen af protokollen
        public DateTime Date { get; set; }
        // lav prop for dato valgt i input feldtet
        //  public DateTime DateChosen { get; set; }

        [BsonIgnore]
        public string SecretId { get; set; }

    }
}

