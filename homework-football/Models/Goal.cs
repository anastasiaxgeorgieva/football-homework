using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_football.Models
{
    public class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }

        public override string ToString()
        {
            return $"GOAL! {this.Player.ToString()} {Minute}'";
        }

        public Goal(FootballPlayer footballPlayer, int minute)
        {
            this.Player = footballPlayer;
            this.Minute = minute;
        }
    }
}
