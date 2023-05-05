using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name)

        {
            this.name = name;
        }

        public override void ChooseGesture()
        {
            Random random = new Random();
            int computerChoice = random.Next(gestures.Count);                         //is this the proper way to pull random gesture from string? stepping through it it looks like the terminal and value are single digit numbers
            chosenGesture = gestures[computerChoice];

            Console.WriteLine($"Computer plays: {chosenGesture}");
            return;


        }
    }
}
