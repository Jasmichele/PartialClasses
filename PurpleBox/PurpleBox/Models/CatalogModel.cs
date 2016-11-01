using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleBox.Models
{
    public class CatalogModel
    {
        public Movie movie { get; set; }
        public Customer customer { get; set; }
        public RentalRecord record { get; set; }
      
    }
}