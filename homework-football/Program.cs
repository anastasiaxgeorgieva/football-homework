using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework_football.Models;

namespace homework_football
{
    class Program
    {
        static void PlayGame(Game game)
        {
            Console.WriteLine($"The game between {game.Team1.Name} and {game.Team2.Name} has started");

            Console.WriteLine("A goal is scored:");
            FootballPlayer footballPlayer = game.Team1.Players.Find(x => x.Name == "Bernando Silva");
            Goal goal1 = new Goal(footballPlayer, 23);
            game.AddGoal(goal1);

            Console.WriteLine("A goal is scored:");
            Goal goal2 = new Goal(footballPlayer, 37);
            game.AddGoal(goal2);

            Console.WriteLine("A goal is scored:");
            FootballPlayer footballPlayer2 = game.Team1.Players.Find(x => x.Name == "Akanji");
            Goal goal3 = new Goal(footballPlayer2, 76);
            game.AddGoal(goal3);

            Console.WriteLine("A goal is scored:");
            FootballPlayer footballPlayer3 = game.Team1.Players.Find(x => x.Name == "Alvarez");
            Goal goal4 = new Goal(footballPlayer3, 90);
            game.AddGoal(goal4);

            Console.WriteLine("The game has ended");
            game.GetReasult();

        }

        static void Main(string[] args)
        {
            Console.WriteLine($"                   MATCH DAY ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("   Champions League - Semi-finals, 2nd leg");

            Coach coach1 = new Coach("Pep Guardiola", 53);
            Team team1 = new Team("Man City", coach1);
            team1.AddPlayer(new Goalkeeper("Ederson", 31, 29, 188));
            team1.AddPlayer(new Defender("Walker", 2, 32, 178));
            team1.AddPlayer(new Defender("Ruben Diaz", 3, 29, 177));
            team1.AddPlayer(new Defender("Akanji", 25, 27, 187));
            team1.AddPlayer(new Midfield("Bernando Silva", 20, 28, 173));
            team1.AddPlayer(new Defender("Stones", 5, 28, 188));
            team1.AddPlayer(new Midfield("Rodri", 16, 26, 183));
            team1.AddPlayer(new Midfield("Rodri", 16, 26, 183));
            team1.AddPlayer(new Midfield("Gundogan", 8, 32, 180));
            team1.AddPlayer(new Midfield("Grealish", 10, 27, 178));
            team1.AddPlayer(new Midfield("Alvarez", 9, 22, 188));
            

            Coach coach2 = new Coach("Carlo Ancelotti", 63);
            Team team2 = new Team("Real Madrid", coach2);
            team2.AddPlayer(new Goalkeeper("Cortois", 1, 23, 188));
            team2.AddPlayer(new Defender("Alaba", 4, 21, 178));
            team2.AddPlayer(new Defender("Eder Militao", 3, 28, 177));
            team2.AddPlayer(new Defender("Carvajal", 2, 27, 187));
            team2.AddPlayer(new Midfield("Kroos", 8, 28, 173));
            team2.AddPlayer(new Defender("Velverde", 15, 28, 188));
            team2.AddPlayer(new Midfield("Benzema", 9, 26, 183));
            team2.AddPlayer(new Midfield("Vinicius Junior", 20, 29, 183));
            team2.AddPlayer(new Midfield("Rodrygo", 21, 30, 180));
            team2.AddPlayer(new Midfield("Camavinga", 12, 29, 178));
            team2.AddPlayer(new Midfield("Mendy", 24, 23, 188));

            Referee referee = new Referee("Szymon Marciniak", 48);
            Referee assistantReferee1 = new Referee("Paweł Sokolnicki", 50);
            Referee assistantReferee2 = new Referee("Tomasz Listkiewicz", 44);

            Game game = new Game(team1, team2);
            game.AddReferee(referee);
            game.AddAssistantReferees(assistantReferee1, assistantReferee2);

            PlayGame(game);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Type GET INFO for information about this match");
            Console.WriteLine("To stop - type END");
            string input = Console.ReadLine();
            while (input != "END")
            {
                switch (input)
                {
                    case "GET INFO":
                        Console.WriteLine("For info about Team 1 - TEAM 1 and for Team 2 - TEAM 2");
                        Console.WriteLine("For info about the referees type R");
                        string input2 = Console.ReadLine();
                        switch (input2)
                        {
                            case "TEAM 1": team1.Info(); break;
                            case "TEAM 2": team2.Info(); break;
                            case "R": 
                                Console.WriteLine($"Referee: {game.Referee.Name}");
                                Console.WriteLine($"Assistant referee: {game.AssistantReferees[0].Name}");
                                Console.WriteLine($"Assistant referee: {game.AssistantReferees[1].Name}");
                                break;
                            default: Console.WriteLine("Invalid input"); break;
                        }
                        break;
                    default: Console.WriteLine("Invalid input"); break;
                }

                input = Console.ReadLine();
            }

        }
    }
}
