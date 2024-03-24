using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TalkBooksBlog.Models.Comment;
using TalkBooksBlog.Models.Post;

namespace TalkBooksBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
