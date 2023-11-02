namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttachedDatasheet")]
    public partial class AttachedDatasheet
    {
        public int ID { get; set; }

        public int ModelID { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        [Required]
        public byte[] FileData { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }

        public virtual PlanningModel PlanningModel { get; set; }
    }
}
