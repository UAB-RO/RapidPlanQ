namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingCase")]
    public partial class TrainingCase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrainingCase()
        {
            ExtractedDatas = new HashSet<ExtractedData>();
        }

        public int ID { get; set; }

        public int ModelID { get; set; }

        public int TrainingCaseNumber { get; set; }

        public Guid PlanUID { get; set; }

        public float TargetDose { get; set; }

        public bool IsActive { get; set; }

        public bool UsedInLastTraining { get; set; }

        [Required]
        [StringLength(255)]
        public string AddedByUser { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime AddedDateTime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] HstryTimeStamp { get; set; }

        [Required]
        [StringLength(255)]
        public string HstryUserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime HstryDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtractedData> ExtractedDatas { get; set; }

        public virtual PlanningModel PlanningModel { get; set; }
    }
}
