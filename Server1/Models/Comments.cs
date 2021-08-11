namespace Server1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Theme { get; set; }

        public DateTime Day { get; set; }

        public DateTime Time { get; set; }

        [Required]
        [StringLength(100)]
        public string Content { get; set; }
    }
}
