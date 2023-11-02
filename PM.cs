namespace PlanningModelQ
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PM : DbContext
    {
        public PM(string server = "ariaserver", string database = "PlanningModelLibrary")
            : base($"data source={server};initial catalog={database};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<AttachedDatasheet> AttachedDatasheets { get; set; }
        public virtual DbSet<CalculationLog> CalculationLogs { get; set; }
        public virtual DbSet<Culture> Cultures { get; set; }
        public virtual DbSet<DBHistory> DBHistories { get; set; }
        public virtual DbSet<ExtractedData> ExtractedDatas { get; set; }
        public virtual DbSet<ModelClassification> ModelClassifications { get; set; }
        public virtual DbSet<ModelPublishLog> ModelPublishLogs { get; set; }
        public virtual DbSet<ModelStructure> ModelStructures { get; set; }
        public virtual DbSet<PlanningModel> PlanningModels { get; set; }
        public virtual DbSet<StructureCode> StructureCodes { get; set; }
        public virtual DbSet<TrainingCase> TrainingCases { get; set; }
        public virtual DbSet<TrainingCaseNumberLastUsed> TrainingCaseNumberLastUseds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Culture>()
                .HasMany(e => e.PlanningModels)
                .WithRequired(e => e.Culture1)
                .HasForeignKey(e => e.Culture)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExtractedData>()
                .Property(e => e.HstryTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<ModelStructure>()
                .Property(e => e.HstryTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<ModelStructure>()
                .HasMany(e => e.ExtractedDatas)
                .WithRequired(e => e.ModelStructure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ModelStructure>()
                .HasMany(e => e.StructureCodes)
                .WithRequired(e => e.ModelStructure)
                .HasForeignKey(e => e.StructureID);

            modelBuilder.Entity<PlanningModel>()
                .Property(e => e.HstryTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<PlanningModel>()
                .HasMany(e => e.AttachedDatasheets)
                .WithRequired(e => e.PlanningModel)
                .HasForeignKey(e => e.ModelID);

            modelBuilder.Entity<PlanningModel>()
                .HasMany(e => e.CalculationLogs)
                .WithRequired(e => e.PlanningModel)
                .HasForeignKey(e => e.ModelID);

            modelBuilder.Entity<PlanningModel>()
                .HasMany(e => e.ModelClassifications)
                .WithRequired(e => e.PlanningModel)
                .HasForeignKey(e => e.ModelID);

            modelBuilder.Entity<PlanningModel>()
                .HasMany(e => e.ModelStructures)
                .WithRequired(e => e.PlanningModel)
                .HasForeignKey(e => e.ModelID);

            modelBuilder.Entity<PlanningModel>()
                .HasMany(e => e.TrainingCases)
                .WithRequired(e => e.PlanningModel)
                .HasForeignKey(e => e.ModelID);

            modelBuilder.Entity<TrainingCase>()
                .Property(e => e.HstryTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<TrainingCase>()
                .HasMany(e => e.ExtractedDatas)
                .WithRequired(e => e.TrainingCase)
                .WillCascadeOnDelete(false);
        }
    }
}
