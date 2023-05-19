using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_football
{
    public class FootballPlayer:Person
    {
        private int number;
        private double height;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }


        public FootballPlayer(string name, int number, int age, double height)
            : base(name, age)
        {
            this.Number = number;
            this.Height = height;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
        public void PlayerInfo()
        {
            Console.WriteLine($"{this.Number} {this.Name} ; Age: {this.Age} years old; Height: {this.Height}cm");
        }
    }
}
