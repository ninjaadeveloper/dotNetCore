using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserManagement.Areas.Identity.Data;

namespace UserManagement.Areas.Identity.Data;

public class UserDBContext : IdentityDbContext<UserManagementClass>
{
    public UserDBContext(DbContextOptions<UserDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new UserManagementIdentityConfiguration());
    }
}

internal class UserManagementIdentityConfiguration : IEntityTypeConfiguration<UserManagementClass>
{
    public void Configure(EntityTypeBuilder<UserManagementClass> builder)
    {
        builder.Property(x => x.fname).HasMaxLength(120);
        builder.Property(x => x.lname).HasMaxLength(120);
    }
}