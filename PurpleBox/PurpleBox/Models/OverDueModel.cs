using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PurpleBox.Models
{
    public class OverDueModel
    {
        public RentalRecord record { get; set; }

        public Customer cust { get; set; }

        public Movie movie { get; set; }
    }
}