using DbServices;
using FakeService;
using IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GameMngmtWebAPI.Controllers
{
    public class GameController : ApiController
    {
        private readonly IGameService _gameService;

        public GameController() 
            : this (new FakeGameService(new Generator()))
            //: this (new DbGameService(new BoardGameContext()))
        {

        }

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var games = _gameService.Get();

            return Ok(games);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var game = _gameService.Get(id);

            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }

        public IHttpActionResult GetLimitedList(int count)
        {
            var list = _gameService.GetLimitedListOfGames(count);

            if (list == null)
            {
                return NotFound();
            }

            return Ok(list);
        }

        // POST: api/Game
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Game/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Game/5
        public void Delete(int id)
        {
        }
    }
}
