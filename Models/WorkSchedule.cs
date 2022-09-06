using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace SayItWebsiteNet5.Models
{
    public class WorkSchedule
    {
        public BsonObjectId Id { get; set; }
        
        DateTime CreationDate { get; set; }
        public List<WorkObj> Groups {get;set;}
        public int StudentsPrGrp { get; set; } = 2;
        public int AmountOfWeeks { get; set; } = 6;
    

    }
}
