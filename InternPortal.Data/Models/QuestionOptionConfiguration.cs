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

    // QuestionOption
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class QuestionOptionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<QuestionOption>
    {
        public QuestionOptionConfiguration()
            : this("dbo")
        {
        }

        public QuestionOptionConfiguration(string schema)
        {
            ToTable("QuestionOption", schema);
            HasKey(x => x.OptionId);

            Property(x => x.OptionId).HasColumnName(@"OptionId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.QuestionId).HasColumnName(@"QuestionId").HasColumnType("int").IsRequired();
            Property(x => x.OptionValue).HasColumnName(@"OptionValue").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.Question).WithMany(b => b.QuestionOptions).HasForeignKey(c => c.QuestionId).WillCascadeOnDelete(false); // FK_dbo.QuestionOption_dbo.Question_QuestionId
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
