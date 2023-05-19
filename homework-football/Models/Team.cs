using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_football.Models
{
    public class Team
    {
        public string Name { get; private set; }
        public Coach Coach { get; private set; }
        public List<FootballPlayer> Players { get; set; }
        public double AverageAgeOfPlayers { get; set; }
        public int GoalOfTheTeam { get; set; }



        public Team(string name,Coach coach)
        {
            this.Name = name;
            this.Coach = coach;
            this.Players = new List<FootballPlayer>();
            this.AverageAgeOfPlayers = 0;
            this.GoalOfTheTeam = 0;
        }

        public void AddPlayer(FootballPlayer footballPlayer)
        {
            if (Players.Count > 22)
            {
                Console.WriteLine("The team already has 22 players.");
            }
            else
            {
                Players.Add(footballPlayer);
                AverageAgeOfPlayers += footballPlayer.Age;
            }
        }

        public void GetAverageAgeOfPlayers()
        {
            int playersCount = this.Players.Count;
            AverageAgeOfPlayers = AverageAgeOfPlayers / playersCount;
            Console.WriteLine($"Average age of the players in the team : {Math.Round(AverageAgeOfPlayers)}");
        }

        public void Info()
        {
            foreach (FootballPlayer fp in this.Players)
            {
                fp.PlayerInfo();
            }
            GetAverageAgeOfPlayers();
            Console.WriteLine($"Coach: {Coach.Name}");

        }
    }
}
