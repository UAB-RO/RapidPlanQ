namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtractedData")]
    public partial class ExtractedData
    {
        public int ID { get; set; }

        public int TrainingCaseID { get; set; }

        public int ModelStructureID { get; set; }

        public Guid PlanStructureUID { get; set; }

        [Required]
        public byte[] Data { get; set; }

        [StringLength(255)]
        public string HstryUserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? HstryDateTime { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] HstryTimeStamp { get; set; }

        public double? PlanStructureTargetDoseLevel { get; set; }

        public virtual ModelStructure ModelStructure { get; set; }

        public virtual TrainingCase TrainingCase { get; set; }
    }
}
