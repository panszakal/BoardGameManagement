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
    [RoutePrefix("api/gameshistory")]
    public class GameHistoryController : ApiController
    {
        private readonly IGameHistoryService _gameHistoryService;

        public GameHistoryController()
            : this(new FakeGameHistoryService(new Generator()))
        {

        }

        public GameHistoryController(IGameHistoryService gameHistoryService)
        {
            _gameHistoryService = gameHistoryService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var gamesHistory = _gameHistoryService.Get();

            return Ok(gamesHistory);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var gameHistory = _gameHistoryService.GetHistoryForGame(id);

            if (gameHistory == null)
            {
                return NotFound();
            }

            return Ok(gameHistory);
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
