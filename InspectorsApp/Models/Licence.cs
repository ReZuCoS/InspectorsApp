namespace InspectorsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Licence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Licence()
        {
            Cars = new HashSet<Car>();
        }

        public int ID { get; set; }

        public int DriverID { get; set; }

        [Column(TypeName = "date")]
        public DateTime LicenceDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpireDate { get; set; }

        [Required]
        [StringLength(10)]
        public string Categories { get; set; }

        [Required]
        [StringLength(4)]
        public string Series { get; set; }

        [Required]
        [StringLength(6)]
        public string Number { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
