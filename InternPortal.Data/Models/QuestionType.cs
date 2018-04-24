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

    // QuestionTypes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class QuestionType
    {
        public int QuestionTypeId { get; set; } // QuestionTypeId (Primary key)
        public string QuestionType_ { get; set; } // QuestionType (length: 100)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) QuestionType pointed by [Question].[QuestionId] (FK_Question_QuestionTypes)
        /// </summary>
        public virtual Question Question { get; set; } // Question.FK_Question_QuestionTypes

        public QuestionType()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
