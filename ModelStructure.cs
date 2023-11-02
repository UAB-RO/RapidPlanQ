namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModelStructure")]
    public partial class ModelStructure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModelStructure()
        {
            ExtractedDatas = new HashSet<ExtractedData>();
            StructureCodes = new HashSet<StructureCode>();
        }

        public int ID { get; set; }

        public int ModelID { get; set; }

        public int StructureType { get; set; }

        public Guid StructureUID { get; set; }

        [Required]
        [StringLength(255)]
        public string StructureName { get; set; }

        public string PlanningObjective { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] HstryTimeStamp { get; set; }

        [Required]
        [StringLength(255)]
        public string HstryUserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime HstryDateTime { get; set; }

        public Guid TrainingReference { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtractedData> ExtractedDatas { get; set; }

        public virtual PlanningModel PlanningModel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StructureCode> StructureCodes { get; set; }
    }
}
