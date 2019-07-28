using System;
using System.Collections.Generic;
using Models;

namespace IServices
{
    public interface IGameService : IEntitiesService<Game>
    {
        IList<Game> GetLimitedListOfGames(int count);
    }

    public interface IGameHistoryService : IEntitiesService<GameHistory>
    {
        IList<GameHistory> GetHistoryForGame(int id);
    }

    public interface IEntitiesService<TEntity>
    {
        IList<TEntity> Get();
        TEntity Get(int id);
        void Add(IList<TEntity> entities);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
