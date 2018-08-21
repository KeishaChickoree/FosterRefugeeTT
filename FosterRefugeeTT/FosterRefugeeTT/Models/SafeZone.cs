using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GoogleMapsAPI.NET;
using GoogleMapsAPI.NET.API.Common.Components.Locations.Common;

namespace FosterRefugeeTT.Models
{
    [ScaffoldTable(true)]
    public class SafeZone
    {
        [Key]
        public Guid SafeZoneKey { get; set; }
        protected String Name { get; set; }
        protected Location Address { get; set; }
        protected Person KeyContact { get; set; }
        //protected List<IPerson> ZoneAdmins { get; set; }

    }
}