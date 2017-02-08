using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ASPLab3
{
    [MetadataType(typeof(Customer_Validation))]
    public partial class Customer
    {

    }

    public class Customer_Validation
    {
      //  [StringLength(30, ErrorMessage = "CustomerID must be 30 characters or less")]
        //public string CustomerID { get; set; }

      //  [StringLength(30, ErrorMessage = "CompanyName must be 30 characters or less")]
        //public string CompanyName { get; set; }

      //  [StringLength(30, ErrorMessage = "ContactName must be 30 characters or less")]
       // public string ContactName { get; set; }

       // [StringLength(30, ErrorMessage = "ContactTitle must be 30 characters or less")]
        //public string ContactTitle { get; set; }

       // [StringLength(30, ErrorMessage = "City must be 30 characters or less")]
       // public string City { get; set; }

    }
}