namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingCaseNumberLastUsed")]
    public partial class TrainingCaseNumberLastUsed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlanningModelID { get; set; }

        public int LastTrainingCaseNr { get; set; }
    }
}
