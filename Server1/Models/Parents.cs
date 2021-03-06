namespace Server1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parents
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Passw { get; set; }

        public int Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }
    }
}
