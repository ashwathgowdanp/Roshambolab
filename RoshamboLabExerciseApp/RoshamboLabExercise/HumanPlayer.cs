using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLabExercise
{
    public class HumanPlayer : Player
    {
        public string useroption = "";

        public HumanPlayer(string useroption)
        {
            this.useroption = useroption;
        }

        public override string GenerateRoshambo()
        {
           
            if(useroption != null)
            {
                if (useroption.ToLower() == "j")
                {
                    RockPlayer rock = new RockPlayer();
                    return rock.GenerateRoshambo();
                }
                else if (useroption.ToLower() == "s")
                {
                    RandomPlayer random= new RandomPlayer();
                    return random.GenerateRoshambo();
                }
            }
            return "Wrong Option";
            
        }
    }
}
