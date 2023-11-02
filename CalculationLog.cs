namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CalculationLog")]
    public partial class CalculationLog
    {
        public int ID { get; set; }

        public int ModelID { get; set; }

        [Required]
        public string LogData { get; set; }

        [Required]
        [StringLength(50)]
        public string LogDataVersion { get; set; }

        public virtual PlanningModel PlanningModel { get; set; }
    }
}
