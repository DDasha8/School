namespace Server1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grades
    {
        public int Id { get; set; }

        public int SubjectsId { get; set; }

        public virtual Subjects Subjects { get; set; }
    }
}
