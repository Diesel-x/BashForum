using BashForum.Areas.Identity.Data;
using BashForum.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BashForum.Data;

public class BashForumContext : IdentityDbContext<BashForumUser>
{
    public DbSet<Models.Thread> Threads { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<BashForumUser> Users { get; set; }

    public BashForumContext(DbContextOptions<BashForumContext> options) : base(options)
    {
    }
}
