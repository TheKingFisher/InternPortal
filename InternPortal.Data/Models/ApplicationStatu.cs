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

    // ApplicationStatus
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class ApplicationStatu
    {
        public int ApplicationStatusId { get; set; } // ApplicationStatusId (Primary key)
        public string Status { get; set; } // Status (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Applications where [Application].[ApplicationStatus] point to this entity (FK_Application_ApplicationStatus)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Application> Applications_ApplicationStatus { get; set; } // Application.FK_Application_ApplicationStatus
        /// <summary>
        /// Child Applications where [Application].[ApplicationStatus] point to this entity (FK_dbo.Application_dbo.ApplicationStatus_ApplicationStatus)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Application> Applications1 { get; set; } // Application.FK_dbo.Application_dbo.ApplicationStatus_ApplicationStatus

        public ApplicationStatu()
        {
            Applications_ApplicationStatus = new System.Collections.Generic.List<Application>();
            Applications1 = new System.Collections.Generic.List<Application>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
