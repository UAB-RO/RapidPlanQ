namespace PlanningModelQ
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModelClassification")]
    public partial class ModelClassification
    {
        public int ID { get; set; }

        public int ModelID { get; set; }

        public Guid ClassificationUID { get; set; }

        public virtual PlanningModel PlanningModel { get; set; }
    }
}
