namespace Server1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Exams
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime Day { get; set; }

        public DateTime Time { get; set; }

        public int SubjectsId { get; set; }

        public int GroupsId { get; set; }

        public virtual Groups Groups { get; set; }

        public virtual Subjects Subjects { get; set; }
    }
}
