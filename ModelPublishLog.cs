namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModelPublishLog")]
    public partial class ModelPublishLog
    {
        public int ID { get; set; }

        public Guid ModelUID { get; set; }

        [StringLength(255)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(255)]
        public string Action { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Time { get; set; }

        [Required]
        [StringLength(255)]
        public string User { get; set; }
    }
}
