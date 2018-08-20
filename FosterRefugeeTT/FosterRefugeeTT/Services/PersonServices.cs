using FosterRefugeeTT.Models;
using FosterRefugeeTT.Providers;
using FosterRefugeeTT.Services;
using System.Web.Security;

namespace FosterRefugeeTT.Controllers
{
    public class PersonServices : IPersonServices
    {
        Person CurrentUser;
        FosterRefugeeDbModel Context;

        public PersonServices()
        {
            string CurrentUser_Email = Membership.GetUser().Email;
            this.Context = new FosterRefugeeDbModel();
        }

        public string getCurrentUserGreeting()
        {
            //Person currentPerson =  this.Context.Persons.FirstOrDefault(email => CurrentUserString);
            //return currentPerson.GetGreeting();
            return "Welcome Test";
        }
    }
}