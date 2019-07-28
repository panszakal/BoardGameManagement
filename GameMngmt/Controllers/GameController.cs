using GameMngmt.BusinessLayer;
using GameMngmt.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GameMngmt.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            IEnumerable<Game> games = new GameUtils().GetListOfGames();

            if (games == null)
            {
                games = Enumerable.Empty<Game>();
                ModelState.AddModelError(string.Empty, "Server error, empty response");
            }

            return View("Game", games);
        }

        // GET: Game/Details/5
        public ActionResult Details(int id)
        {
            var game = new GameUtils().GetGame(id);
            var history = new GameUtils().GetGameHistory(id);

            if (game != null && history != null)
            {
                var gameDetails = new GameViewModel();
                gameDetails.ID = game.ID;
                gameDetails.GameName = game.GameName;
                gameDetails.MaximumNumberOfPlayers = game.MaximumNumberOfPlayers;
                gameDetails.MinimumNumberOfPlayers = game.MinimumNumberOfPlayers;
                gameDetails.RecommendedAge = game.RecommendedAge;
                gameDetails.GamesHistory = history;

                return View(gameDetails);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server error, empty response");
                return View();
            }
        }

        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Edit/5
        public ActionResult Edit(int id)
        {
            Game game = new GameUtils().GetGame(id);

            if (game == null)
            {
                game = new Game();
                ModelState.AddModelError(string.Empty, "Server error, empty response");
            }

            return View("Details", game);
        }

        // POST: Game/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Delete/5
        public ActionResult Delete(int id)
        {
            Game game = new GameUtils().GetGame(id);

            if (game == null)
            {
                game = new Game();
                ModelState.AddModelError(string.Empty, "Server error, empty response");
            }

            return View("Delete", game);
        }

        // POST: Game/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var success = new GameUtils().DeleteGame(id);

                if (success)
                    return RedirectToAction("Index");
                else
                {
                    ModelState.AddModelError(string.Empty, "Error deleting game");
                    return View();
                }
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "Error deleting game");
                return View();
            }
        }
    }
}
