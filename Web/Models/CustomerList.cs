using System.Collections.Generic;

namespace Web.Models
{
    public class CustomerList : List<Customer>
    {
        public string ImageUrl { get; set; }
    }
}