// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace InternPortal.Data.Models
{

    // Application
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class ApplicationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Application>
    {
        public ApplicationConfiguration()
            : this("dbo")
        {
        }

        public ApplicationConfiguration(string schema)
        {
            ToTable("Application", schema);
            HasKey(x => x.ApplicationId);

            Property(x => x.ApplicationId).HasColumnName(@"ApplicationId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsRequired();
            Property(x => x.ApplicationStartDate).HasColumnName(@"ApplicationStartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ApplicationCompleteDate).HasColumnName(@"ApplicationCompleteDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ApplicationStatusId).HasColumnName(@"ApplicationStatusId").HasColumnType("int").IsOptional();
            Property(x => x.ApplicationStatus).HasColumnName(@"ApplicationStatus").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.ApplicationStatu).WithMany(b => b.Applications).HasForeignKey(c => c.ApplicationStatusId).WillCascadeOnDelete(false); // FK_dbo.Application_dbo.ApplicationStatus_ApplicationStatus
            HasRequired(a => a.User).WithMany(b => b.Applications).HasForeignKey(c => c.UserId).WillCascadeOnDelete(false); // FK_dbo.Application_dbo.User_UserId
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
