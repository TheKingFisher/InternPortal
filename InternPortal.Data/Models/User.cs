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

    // User
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.34.1.0")]
    public partial class User
    {
        public int UserId { get; set; } // UserId (Primary key)
        public string Id { get; set; } // Id (length: 128)
        public string FirstName { get; set; } // FirstName (length: 100)
        public string MiddleName { get; set; } // MiddleName (length: 100)
        public string LastName { get; set; } // LastName (length: 100)
        public string PhoneNumber { get; set; } // PhoneNumber (length: 50)
        public string Address { get; set; } // Address
        public string City { get; set; } // City (length: 100)
        public string State { get; set; } // State (length: 100)
        public string ZipCode { get; set; } // ZipCode (length: 10)
        public System.DateTime? DateOfBirth { get; set; } // DateOfBirth
        public string Gender { get; set; } // Gender (length: 50)
        public string Ethnicity { get; set; } // Ethnicity (length: 50)
        public string Email { get; set; } // Email (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child Applications where [Application].[UserId] point to this entity (FK_dbo.Application_dbo.User_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Application> Applications { get; set; } // Application.FK_dbo.Application_dbo.User_UserId
        /// <summary>
        /// Child Messages where [Message].[UserIdFrom] point to this entity (FK_dbo.Messages_dbo.User_UserIdFrom)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Message> Messages_UserIdFrom { get; set; } // Message.FK_dbo.Messages_dbo.User_UserIdFrom
        /// <summary>
        /// Child Messages where [Message].[UserIdTo] point to this entity (FK_dbo.Messages_dbo.User_UserIdTo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Message> Messages_UserIdTo { get; set; } // Message.FK_dbo.Messages_dbo.User_UserIdTo
        /// <summary>
        /// Child UserUploads where [UserUpload].[UserId] point to this entity (FK_dbo.UserUploads_dbo.User_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UserUpload> UserUploads { get; set; } // UserUpload.FK_dbo.UserUploads_dbo.User_UserId

        // Foreign keys

        /// <summary>
        /// Parent AspNetUser pointed by [User].([Id]) (FK_dbo.User_dbo.AspNetUsers_Id)
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; } // FK_dbo.User_dbo.AspNetUsers_Id

        public User()
        {
            Applications = new System.Collections.Generic.List<Application>();
            Messages_UserIdFrom = new System.Collections.Generic.List<Message>();
            Messages_UserIdTo = new System.Collections.Generic.List<Message>();
            UserUploads = new System.Collections.Generic.List<UserUpload>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
