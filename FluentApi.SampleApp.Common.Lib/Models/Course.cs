using System;
using System.Runtime.Serialization;

namespace FluentApi.SampleApp.Models
{
    public class Course 
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
    }
}
