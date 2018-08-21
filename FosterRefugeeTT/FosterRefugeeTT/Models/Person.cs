using GoogleMapsAPI.NET.API.Common.Components.Locations.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterRefugeeTT.Models
{
    [ScaffoldTable(true)]
    public class Person
    {
        [Key]
        [Required]
        public String Email { get; set; }

        String Nationality { get; set; }
        String HighestLevelOfEducation { get; set; }
        Story MyStory { get; set; }
        UserProfile MyProfile { get; set; }
        Document SupportingDocuments { get; set; }
        Address PrimaryAddress { get; set; }
        Address MailingAddress { get; set; }
        Address ResidentialAddress { get; set; }
        Address CountryOfOrigin { get; set; }
    }
}
