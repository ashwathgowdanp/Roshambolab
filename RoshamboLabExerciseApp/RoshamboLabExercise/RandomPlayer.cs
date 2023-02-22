using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLabExercise
{
    public class RandomPlayer : Player
    {
        
        public override string GenerateRoshambo()
        {
            Random random = new Random();

            Type type = typeof(Roshambo);
            Array values = type.GetEnumValues();
            int index = random.Next(values.Length);

            Roshambo value = (Roshambo)values.GetValue(index);
            return value.ToString();


        }
    }
}
