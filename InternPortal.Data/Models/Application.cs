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
        public int? ApplicationStatusId { get; set; } // ApplicationStatusId
        public int? ApplicationStatus { get; set; } // ApplicationStatus

        // Reverse navigation

        /// <summary>
        /// Child Answers where [Answer].[ApplicationId] point to this entity (FK_dbo.Answers_dbo.Application_ApplicationId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Answer> Answers { get; set; } // Answer.FK_dbo.Answers_dbo.Application_ApplicationId
        /// <summary>
        /// Child Notes where [Note].[ApplicationId] point to this entity (FK_Note_Application)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Note> Notes { get; set; } // Note.FK_Note_Application
        /// <summary>
        /// Child UserUploads where [UserUpload].[ApplicationId] point to this entity (FK_dbo.UserUploads_dbo.Application_ApplicationId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UserUpload> UserUploads { get; set; } // UserUpload.FK_dbo.UserUploads_dbo.Application_ApplicationId

        // Foreign keys

        /// <summary>
        /// Parent ApplicationStatu pointed by [Application].([ApplicationStatusId]) (FK_dbo.Application_dbo.ApplicationStatus_ApplicationStatus)
        /// </summary>
        public virtual ApplicationStatu ApplicationStatu { get; set; } // FK_dbo.Application_dbo.ApplicationStatus_ApplicationStatus

        /// <summary>
        /// Parent User pointed by [Application].([UserId]) (FK_dbo.Application_dbo.User_UserId)
        /// </summary>
        public virtual User User { get; set; } // FK_dbo.Application_dbo.User_UserId

        public Application()
        {
            Answers = new System.Collections.Generic.List<Answer>();
            Notes = new System.Collections.Generic.List<Note>();
            UserUploads = new System.Collections.Generic.List<UserUpload>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
