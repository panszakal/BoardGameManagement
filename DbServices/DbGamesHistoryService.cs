using IServices;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbServices
{
    class DbGamesHistoryService : IGameHistoryService
    {
        private readonly BoardGameContext context;

        public DbGamesHistoryService(BoardGameContext context)
        {
            this.context = context;
        }

        public void Add(IList<GameHistory> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(GameHistory entity)
        {
            throw new NotImplementedException();
        }

        public IList<GameHistory> Get()
        {
            return context.GamesHistory.ToList();
        }

        public GameHistory Get(int id)
        {
            return context.GamesHistory.FirstOrDefault(g => g.GameID == id);
        }

        public IList<GameHistory> GetHistoryForGame(int id)
        {
            return context.GamesHistory.Where(g => g.GameID == id).OrderByDescending(g => g.GameDateTime).Take(10).ToList();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(GameHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
