using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbServices
{
    public class BoardGameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<GameHistory> GamesHistory { get; set; }

        public BoardGameContext()
            : base("name=GameMngmtContext")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
