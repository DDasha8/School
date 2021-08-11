namespace Server1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Teachers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teachers()
        {
            Timetable = new HashSet<Timetable>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Passw { get; set; }

        public int Phone { get; set; }

        [Required]
        [MaxLength(100)]
        public byte[] Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
