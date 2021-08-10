namespace Server1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Events
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Name { get; set; }

        public DateTime Day { get; set; }

        public DateTime Time { get; set; }
    }
}
