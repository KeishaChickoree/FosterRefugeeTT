using GoogleMapsAPI.NET.API.Common.Components.Locations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FosterRefugeeTT.Models
{
    public class Address
    {
        string StreetNameLine1 { get; set; }
        string StreetNameLine2 { get; set; }
        string StreetNameLine3 { get; set; }
        string City { get; set; }
        string Country { get; set; }
        Location GPSLocation { get; set; }


    }
}