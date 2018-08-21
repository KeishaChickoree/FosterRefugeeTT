using System;
using System.ComponentModel.DataAnnotations;

namespace FosterRefugeeTT.Models
{
    [ScaffoldTable(true)]
    public class Document
    {
        [Key]
        public Guid Id { get; set; }
        public byte[] File { get; set; }
        string Name { get; set; }
        DocumentType Type { get; set; }

    }
}