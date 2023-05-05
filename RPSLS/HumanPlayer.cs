using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {

        public HumanPlayer(string name) : base(name)

        {
            this.name = name;
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose One:\n Rock \n Paper \n Scissors \n Lizard \n Spock");
            //Console.WriteLine(gestures);
            chosenGesture = Console.ReadLine();
            return;
        }
        

    }
}
