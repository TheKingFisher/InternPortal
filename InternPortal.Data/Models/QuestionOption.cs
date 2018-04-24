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

    // QuestionOptions
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class QuestionOption
    {
        public int OptionId { get; set; } // OptionId (Primary key)
        public int QuestionId { get; set; } // QuestionId
        public string OptionValue { get; set; } // OptionValue

        // Foreign keys

        /// <summary>
        /// Parent Question pointed by [QuestionOptions].([QuestionId]) (FK_QuestionOptions_Question)
        /// </summary>
        public virtual Question Question { get; set; } // FK_QuestionOptions_Question

        public QuestionOption()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>