using GoogleMapsAPI.NET.API.Common.Components.Locations.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FosterRefugeeTT.Models
{
    [Table("PersonAddress")]
    public class Address
    {
        [Key]
        public Guid Id;
        string StreetNameLine1 { get; set; }
        string StreetNameLine2 { get; set; }
        string StreetNameLine3 { get; set; }
        string City { get; set; }
        string Country { get; set; }
        Location GPSLocation { get; set; }


    }
}