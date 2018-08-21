using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FosterRefugeeTT.Models
{
    [ScaffoldTable(true)]
    public class HostHistory
    {
        [Key]
        public Guid Id { get; set; }
        Host KeyHost { get; set; }
        Refugee HostedRefugee { get; set; }
    }
}