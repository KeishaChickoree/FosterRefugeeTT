using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FosterRefugeeTT.Models
{
    [ScaffoldTable(true)]
    public class UserProfile
    {
        [Key]
        public Person User { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        char Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        DateTime RegistrationDate { get; set; }

        [DisplayName("Full Customer Name")]
        public string FullCustomerName
        {
            get
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }

        public string CustomerGreeting
        {
            get
            {
                return "Welcome " + FirstName + "!";
            }
        }
    }
}