using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterRefugeeTT.Models
{
    interface IPerson
    {
        String Name { get; set; }
        String Nationality { get; set; }
        String HighestLevelOfEducation { get; set; }
        

    }
}
