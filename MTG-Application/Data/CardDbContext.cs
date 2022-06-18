using Microsoft.EntityFrameworkCore;
using MTG_Application.Models;

namespace MTG_Application.Data
{
    public class CardDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public CardDbContext(DbContextOptions<CardDbContext> options)
            : base(options)
        {
        }
    }
}
