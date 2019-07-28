using IServices;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbServices
{
    public class DbGameService : IGameService
    {
        private readonly BoardGameContext context;

        public DbGameService(BoardGameContext context)
        {
            this.context = context;
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
            return context.Games.ToList();
        }

        public Game Get(int id)
        {
            return context.Games.FirstOrDefault(g => g.ID == id);
        }

        public IList<Game> GetLimitedListOfGames(int count)
        {
            return context.Games.Take(count).ToList();
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
