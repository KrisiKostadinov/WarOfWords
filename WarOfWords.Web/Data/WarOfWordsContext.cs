using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorOfWords.Web.DataModels;

namespace WorOfWords.Web.Data
{
    public class WarOfWordsContext : IdentityDbContext<WarOfWordsUser>
    {
        public WarOfWordsContext(DbContextOptions<WarOfWordsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
