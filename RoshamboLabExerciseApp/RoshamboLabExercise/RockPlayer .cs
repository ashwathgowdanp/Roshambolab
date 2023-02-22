using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLabExercise
{
    public class RockPlayer : Player
    {

        public override string GenerateRoshambo()
        {
            Roshambo roshamboVal = Roshambo.rock;
            return roshamboVal.ToString();
            
        }
    }
}
