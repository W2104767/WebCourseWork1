using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeaponShop.Models
{
    // this model is to represent the customers that may pruchase a weapon(s)
    public class Customer
    {
        public int CustomerId{ get; set; }
        public string FirstName {get; set;}
        public string LastName{ get; set; }
        public string Email{ get; set; }
        public string PhoneNumber{ get; set; }
        public string PostCode{ get; set; }
    
    // The relationship for customer is that one customer can place many orders
    
    [JsonIgnore]
     public List <Order>? Orders { get; set; }   
    
    }
}