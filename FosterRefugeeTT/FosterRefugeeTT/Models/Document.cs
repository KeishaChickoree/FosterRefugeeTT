using System.ComponentModel.DataAnnotations;

namespace FosterRefugeeTT.Models
{
    public class Document
    {
        [Key]
        public byte[] File { get; set; }
        string Name { get; set; }
        DocumentType Type { get; set; }

    }
}