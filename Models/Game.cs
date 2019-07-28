using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Game : Base
    {
        public string GameName { get; set; }

        public int MinimumNumberOfPlayers { get; set; }

        public int MaximumNumberOfPlayers { get; set; }

        public int RecommendedAge { get; set; }
    }
}
