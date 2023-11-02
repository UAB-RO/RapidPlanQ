namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DBHistory")]
    public partial class DBHistory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string EventType { get; set; }

        [StringLength(20)]
        public string SchemaVersion { get; set; }

        [StringLength(20)]
        public string ContentVersion { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string User { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
