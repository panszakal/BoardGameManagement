using GameMngmt.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using GameMngmt.Models;

namespace GameMngmt.BusinessLayer
{
    public class GameUtils
    {
        public IList<Game> GetListOfGames()
        {
            var result = new GameRepository().GetResponse("game");
            result.EnsureSuccessStatusCode();

            if (result.IsSuccessStatusCode)
            {
                var readAsync = result.Content.ReadAsAsync<IList<Game>>();
                readAsync.Wait();
                
                return readAsync.Result;
            }
            else
            {
                return null;
            }
        }

        public Game GetGame(int id)
        {
            var result = new GameRepository().GetResponse("game/" + id);
            result.EnsureSuccessStatusCode();

            if (result.IsSuccessStatusCode)
            {
                var readAsync = result.Content.ReadAsAsync<Game>();
                readAsync.Wait();

                return readAsync.Result;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteGame(int id)
        {
            using (var client = new HttpClient())
            {
                var result = new GameRepository().DeleteResponse("game/" + id);

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IList<GameHistory> GetGameHistory(int id)
        {
            var game = GetGame(id);

            if (game != null)
            {
                var result = new GameRepository().GetResponse("gamehistory/" + id);

                if (result.IsSuccessStatusCode)
                {
                    var readAsync = result.Content.ReadAsAsync<IList<GameHistory>>();
                    readAsync.Wait();

                    return readAsync.Result;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}

