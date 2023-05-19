using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_football.Models
{
    public class Game
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public Referee Referee { get; set; }

        public Referee[] AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string GameResult { get; set; }
        public string Winner { get; set; }

        public Game(Team team1, Team team2)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            AssistantReferees = new Referee[2];
            this.Goals = new List<Goal>();
        }

        public void AddReferee(Referee referee)
        {
            this.Referee = referee;
        }


        public void AddAssistantReferees(Referee referee1, Referee referee2)
        {
            AssistantReferees[0] = referee1;
            AssistantReferees[1] = referee2;
        }

        public void AddGoal(Goal goal)
        {
            Goals.Add(goal);
            if (Team1.Players.Contains(goal.Player))
            {
                Team1.GoalOfTheTeam++;
            }
            else if (Team2.Players.Contains(goal.Player))
            {
                Team2.GoalOfTheTeam++;
            }
            Console.WriteLine($"Goal by: {goal.Player.Name} in {goal.Minute} minute"+"\n");
        }

        public void GetReasult()
        {
            Console.WriteLine($"{Team1.Name} {Team1.GoalOfTheTeam} - {Team2.GoalOfTheTeam} {Team2.Name}");
            if (Team1.GoalOfTheTeam > Team2.GoalOfTheTeam) Console.WriteLine($"WINNER : {Team1.Name}");
            else Console.WriteLine($"WINNER : {Team2.Name}");
        }
         
        

    }
}
