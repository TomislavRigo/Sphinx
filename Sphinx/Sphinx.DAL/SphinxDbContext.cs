using Microsoft.EntityFrameworkCore;
using Sphinx.DAL.Entities;

namespace Sphinx.DAL
{
    public class SphinxDbContext : DbContext
    {
        public SphinxDbContext()
        {

        }
        public DbSet<QuestionEntity> QuestionEntities { get; set; }
        public DbSet<DificultyEntity> DificultyEntities { get; set; }
        public DbSet<CategoryEntity> CategoryEntities { get; set; }
        //public DbSet<UserEntity> UserEntities { get; set; }
        public DbSet<UserQuestionLink> UserQuestionLinks { get; set; }
    }
}
