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

    // UserUploads
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class UserUploadConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserUpload>
    {
        public UserUploadConfiguration()
            : this("dbo")
        {
        }

        public UserUploadConfiguration(string schema)
        {
            ToTable("UserUploads", schema);
            HasKey(x => x.UploadId);

            Property(x => x.UploadId).HasColumnName(@"UploadId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsOptional();
            Property(x => x.ApplicationId).HasColumnName(@"ApplicationId").HasColumnType("int").IsOptional();
            Property(x => x.UploadLocation).HasColumnName(@"UploadLocation").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.UploadTitle).HasColumnName(@"UploadTitle").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.UploadDescription).HasColumnName(@"UploadDescription").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasOptional(a => a.Application).WithMany(b => b.UserUploads).HasForeignKey(c => c.ApplicationId).WillCascadeOnDelete(false); // FK_dbo.UserUploads_dbo.Application_ApplicationId
            HasOptional(a => a.User).WithMany(b => b.UserUploads).HasForeignKey(c => c.UserId).WillCascadeOnDelete(false); // FK_dbo.UserUploads_dbo.User_UserId
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
