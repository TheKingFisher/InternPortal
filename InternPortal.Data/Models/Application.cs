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
    public partial class Application
    {
        public int ApplicationId { get; set; } // ApplicationId (Primary key)
        public int UserId { get; set; } // UserId
        public System.DateTime? ApplicationStartDate { get; set; } // ApplicationStartDate
        public System.DateTime? ApplicationCompleteDate { get; set; } // ApplicationCompleteDate
        public int? ApplicationStatus { get; set; } // ApplicationStatus

        // Reverse navigation

        /// <summary>
        /// Child Answers where [Answers].[ApplicationId] point to this entity (FK_Answers_Application)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Answer> Answers { get; set; } // Answers.FK_Answers_Application

        // Foreign keys

        /// <summary>
        /// Parent User pointed by [Application].([UserId]) (FK_Application_User)
        /// </summary>
        public virtual User User { get; set; } // FK_Application_User

        public Application()
        {
            Answers = new System.Collections.Generic.List<Answer>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
