using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PurpleBox
{
    [MetadataType(typeof(GenreMetaData))]
    public partial class Genre
    {

    }

    public class GenreMetaData
    {
        [DisplayName("Genre")]
        [Required(ErrorMessage = "Genre required")]
        public string GenreName { get; set; }
    }

    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {

    }

    public class CustomerMetaData
    {
        [DisplayName("Customer")]
        public int CustomerID { get; set; }
        [DisplayName("Customer")]
        [Required(ErrorMessage = "Customer name required")]
        public string CustomerName { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone number required")]
        public string CustomerPhoneNum { get; set; }
    }

    [MetadataType(typeof(MovieMetaData))]
    public partial class Movie
    {

    }

    public class MovieMetaData
    {
        [DisplayName("Movie")]
        public int MovieID { get; set; }
        [DisplayName("Movie")]
        [Required(ErrorMessage = "You must enter a movie")]
        public string MovieName { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "The description is required")]
        public string MovieDescription { get; set; }

        [DisplayName("Genre")]
        public int MovieGenre { get; set; }
    }

    [MetadataType(typeof(RentalRecordMetaData))]
    public partial class RentalRecord
    {

    }

    public class RentalRecordMetaData
    {
        [DisplayName("Date Rented")]
        [Required(ErrorMessage = "Enter Today's date")]
        public System.DateTime RentalDate { get; set; }
     
        [DisplayName("Date Due")]
        [Required(ErrorMessage = "Enter Due date")]
        public System.DateTime DueDate { get; set; }

        [DisplayName("Date Returned")]
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }
}