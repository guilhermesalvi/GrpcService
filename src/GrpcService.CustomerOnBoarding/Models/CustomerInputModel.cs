using System;
using System.Text.Json.Serialization;

namespace GrpcService.CustomerOnBoarding.Models
{
    public class CustomerInputModel
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
