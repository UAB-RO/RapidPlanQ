namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StructureCode")]
    public partial class StructureCode
    {
        public int Id { get; set; }

        public int StructureID { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string CodingScheme { get; set; }

        public virtual ModelStructure ModelStructure { get; set; }
    }
}
