namespace Server1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timetable")]
    public partial class Timetable
    {
        public int Id { get; set; }

        public DateTime Day { get; set; }

        public DateTime Time { get; set; }

        public int TeachersId { get; set; }

        public int SubjectsId { get; set; }

        public int GroupsId { get; set; }

        public virtual Groups Groups { get; set; }

        public virtual Subjects Subjects { get; set; }

        public virtual Teachers Teachers { get; set; }
    }
}
