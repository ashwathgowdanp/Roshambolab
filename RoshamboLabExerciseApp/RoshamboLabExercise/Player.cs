using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLabExercise
{
    public abstract class Player
    {
        public string? Name;
        public string? RoshamboValue;        

        public abstract string GenerateRoshambo();
        

    }
}
