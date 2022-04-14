using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PaymentAPI.Models



{
    public class Payment
    {
        [Key]
        public int paymentDetailId {get; set;}
        public string cardOwnerName {get; set;}
        public string cardNumber {get; set;}
        // [JsonIgnore]        
        public int month {get; set;}
        // [JsonIgnore]
        public int year {get; set;}
        //public DateTime expirationDate {get; set;}
        public string securityCode{get; set;}
    }
}