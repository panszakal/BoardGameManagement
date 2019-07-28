using IServices;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeService
{
    public class FakeGameHistoryService : IGameHistoryService
    {
        private IList<GameHistory> _gamesHistory = new List<GameHistory>();

        public FakeGameHistoryService(Generator generator)
        {
            _gamesHistory = generator.GamesHistory;
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
            return _gamesHistory;
        }

        public GameHistory Get(int id)
        {
            return _gamesHistory.SingleOrDefault(g => g.ID == id);
        }

        public IList<GameHistory> GetHistoryForGame(int id)
        {
            return _gamesHistory.Where(g => g.GameID == id).OrderByDescending(g => g.GameDateTime).Take(10).ToList();
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
