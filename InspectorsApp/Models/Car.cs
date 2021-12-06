namespace InspectorsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Car
    {
        [Key]
        [StringLength(50)]
        public string VIN { get; set; }

        public int LicenceID { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(4)]
        public string Year { get; set; }

        public int Weight { get; set; }

        public int Color { get; set; }

        public int EngineType { get; set; }

        [Required]
        [StringLength(50)]
        public string DriveType { get; set; }

        public virtual Licence Licence { get; set; }
    }
}
