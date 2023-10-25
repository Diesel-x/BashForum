using BashForum.Data;
using BashForum.Models;
using Microsoft.EntityFrameworkCore;
using Thread = BashForum.Models.Thread;

namespace BashForum.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }

        public DbSet<Thread> Courses { get; set; }
        public DbSet<Comment> Enrollments { get; set; }
        public DbSet<User> Students { get; set; }

    }
}
