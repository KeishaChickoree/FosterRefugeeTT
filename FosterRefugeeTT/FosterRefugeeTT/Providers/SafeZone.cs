namespace FosterRefugeeTT.Providers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SafeZone")]
    public partial class SafeZone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public DbGeography Address { get; set; }

        public int MaxRefugees { get; set; }

        public int MaxHosts { get; set; }
    }
}
