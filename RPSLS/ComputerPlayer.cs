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
            int computerChoice = random.Next(gestures.Count);                         
            chosenGesture = gestures[computerChoice];

            Console.WriteLine($"Player Two plays: {chosenGesture}");
            return;


        }
    }
}
