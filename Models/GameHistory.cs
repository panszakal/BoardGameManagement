using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class GameHistory : Base
    {
        public int GameID { get; set; }

        public DateTime GameDateTime { get; set; }

        public string Source { get; set; }
    }
}
