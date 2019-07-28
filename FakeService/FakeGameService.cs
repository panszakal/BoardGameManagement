using IServices;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeService
{
    public class FakeGameService : IGameService
    {
        private IList<Game> _games = new List<Game>();

        public FakeGameService(Generator generator)
        {
            _games = generator.Games;
        }

        public void Add(IList<Game> entities)
        {
            throw new NotImplementedException();
        }

        public void Add(Game entity)
        {
            throw new NotImplementedException();
        }

        public IList<Game> Get()
        {
            return _games;
        }

        public Game Get(int id)
        {
            return _games.SingleOrDefault(g => g.ID == id);
        }

        public IList<Game> GetLimitedListOfGames(int count)
        {
            return _games.Take(count).ToList();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
