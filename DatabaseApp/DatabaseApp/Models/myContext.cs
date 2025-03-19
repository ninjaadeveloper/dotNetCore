using Microsoft.EntityFrameworkCore;

namespace DatabaseApp.Models
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options) {

        }

        public DbSet<Student> tbl_students { get; set; }
    }
}
