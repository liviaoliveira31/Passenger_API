using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Passenger_API.Models
{
    public class Address
    {

       
        [JsonProperty("cep")]
        [MaxLength(9)]
        public string ZipCode { get; set; }   
        [JsonProperty("logradouro")]
        [MaxLength(100)]
        public string? Street { get; set; }
        public int Number { get; set; }
        [MaxLength(10)]
        public string Complement { get; set; }
        [MaxLength(10)]
        [JsonProperty("localidade")]
        public string City { get; set; }

        [MaxLength(2)]
        [JsonProperty("uf")]
        public string State { get; set; }
    }
}
