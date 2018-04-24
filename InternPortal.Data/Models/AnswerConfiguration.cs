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

    // Answers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class AnswerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Answer>
    {
        public AnswerConfiguration()
            : this("dbo")
        {
        }

        public AnswerConfiguration(string schema)
        {
            ToTable("Answers", schema);
            HasKey(x => x.AnswerId);

            Property(x => x.AnswerId).HasColumnName(@"AnswerId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ApplicationId).HasColumnName(@"ApplicationId").HasColumnType("int").IsRequired();
            Property(x => x.QuestionId).HasColumnName(@"QuestionId").HasColumnType("int").IsRequired();
            Property(x => x.OptionId).HasColumnName(@"OptionId").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Answer1).WithOptional(b => b.Answer2).WillCascadeOnDelete(false); // FK_Answers_Answers
            HasRequired(a => a.Application).WithMany(b => b.Answers).HasForeignKey(c => c.ApplicationId).WillCascadeOnDelete(false); // FK_Answers_Application
            HasRequired(a => a.Question).WithMany(b => b.Answers).HasForeignKey(c => c.QuestionId).WillCascadeOnDelete(false); // FK_Answers_Question
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>