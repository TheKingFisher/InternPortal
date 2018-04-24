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

    public partial interface IInternPortalContext : IDbContext
    {
        System.Data.Entity.DbSet<Answer> Answers { get; set; } // Answers
        System.Data.Entity.DbSet<Application> Applications { get; set; } // Application
        System.Data.Entity.DbSet<ApplicationStatu> ApplicationStatus { get; set; } // ApplicationStatus
        System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        System.Data.Entity.DbSet<Message> Messages { get; set; } // Messages
        System.Data.Entity.DbSet<Question> Questions { get; set; } // Question
        System.Data.Entity.DbSet<QuestionOption> QuestionOptions { get; set; } // QuestionOptions
        System.Data.Entity.DbSet<QuestionType> QuestionTypes { get; set; } // QuestionTypes
        System.Data.Entity.DbSet<User> Users { get; set; } // User
        System.Data.Entity.DbSet<UserUpload> UserUploads { get; set; } // UserUploads

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

}
// </auto-generated>