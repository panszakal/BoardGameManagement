using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMngmt.Models
{
    public class GameViewModel : Game
    {
        public IEnumerable<GameHistory> GamesHistory;
    }
}