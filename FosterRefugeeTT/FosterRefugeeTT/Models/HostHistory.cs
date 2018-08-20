using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FosterRefugeeTT.Models
{
    public class HostHistory
    {
        Host KeyHost { get; set; }
        Refugee HostedRefugee { get; set; }
    }
}