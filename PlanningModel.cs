namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanningModel")]
    public partial class PlanningModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanningModel()
        {
            AttachedDatasheets = new HashSet<AttachedDatasheet>();
            CalculationLogs = new HashSet<CalculationLog>();
            ModelClassifications = new HashSet<ModelClassification>();
            ModelStructures = new HashSet<ModelStructure>();
            TrainingCases = new HashSet<TrainingCase>();
        }

        public int ID { get; set; }

        public Guid ModelUID { get; set; }

        [Required]
        [StringLength(20)]
        public string ModelVersion { get; set; }

        public byte[] ModelData { get; set; }

        [Required]
        [StringLength(255)]
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public string PlanningObjective { get; set; }

        public bool IsPublished { get; set; }

        public int Revision { get; set; }

        public bool IsVarianOwned { get; set; }

        public int Culture { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] HstryTimeStamp { get; set; }

        [Required]
        [StringLength(255)]
        public string HstryUserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime HstryDateTime { get; set; }

        [StringLength(64)]
        public string ModelSchemaVersion { get; set; }

        [StringLength(255)]
        public string RequiredLicense { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttachedDatasheet> AttachedDatasheets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalculationLog> CalculationLogs { get; set; }

        public virtual Culture Culture1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelClassification> ModelClassifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelStructure> ModelStructures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingCase> TrainingCases { get; set; }
    }
}
