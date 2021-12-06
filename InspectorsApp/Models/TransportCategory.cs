namespace InspectorsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransportCategory
    {
        [Key]
        [StringLength(5)]
        public string CategoryID { get; set; }

        [Required]
        [StringLength(300)]
        public string Desctiption { get; set; }
    }
}
