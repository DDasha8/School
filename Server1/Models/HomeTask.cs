namespace Server1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HomeTask")]
    public partial class HomeTask
    {
        public int Id { get; set; }

        public DateTime Day { get; set; }

        [Required]
        [StringLength(100)]
        public string Content { get; set; }

        public int SubjectsId { get; set; }

        public int StudentsId { get; set; }

        public virtual Students Students { get; set; }

        public virtual Subjects Subjects { get; set; }
    }
}
