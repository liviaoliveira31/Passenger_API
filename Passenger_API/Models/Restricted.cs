﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Passenger_API.Models
{
    [BsonIgnoreExtraElements]
    public class Restricted
    {
        [MaxLength(14)]
        [Required]
        public string CPF { get; set; }
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        public char Gender { get; set; }
        [MaxLength(14)]
        public string Phone { get; set; }
        public DateTime DtBirth { get; set; }
        public DateTime DtRegister { get; set; }
        public bool Status { get; set; }
        public Address Address { get; set; }
    }
}
