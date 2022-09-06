using MongoDB.Bson;
using System;

namespace SayItWebsiteNet5.Models
{
    public class SmsService
    {
        public BsonObjectId Id { get; set; }
        Sms SmsInfo { get; set; }
        public DateTime SendDate { get; set;}
    }
}
