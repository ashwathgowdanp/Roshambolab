using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLabExercise
{
    public class Validationcl
    {
        public static int humanplayerCount;
        public static int RandomPlayerCount;
        public static int DrawCount;
        public static string selectwinner (string firstVal, string secondVal, string useroption)
        {
            if (firstVal == secondVal)
            {
                DrawCount = DrawCount + 1;
                return "Draw";
            }
            else if (firstVal.ToLower() == "paper" )
            {
                if (secondVal.ToLower() == "scissors")
                {
                    RandomPlayerCount = RandomPlayerCount + 1;
                    return useroption + " Wins!";
                }
            }

            else if (firstVal.ToLower() == "rock")
            {
                if (secondVal.ToLower() == "paper")
                {
                    RandomPlayerCount = RandomPlayerCount + 1;
                    return useroption + " Wins!";
                }
            }

            else if (firstVal.ToLower() == "scissors")
            {
                if (secondVal.ToLower() == "rock")
                {
                    RandomPlayerCount = RandomPlayerCount + 1;
                    return useroption + " Wins!";
                }
            }
            humanplayerCount = humanplayerCount + 1;
            return "HumanPlayer";
        }

        public static string validateuserinput ( string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length != 1)
            {
                Console.WriteLine(value.Length);
                return "Please enter valid option!";
            }

            return "";
        }

        public static string AssignplayCategory(string value)
        {
            if (value.ToLower() == "r")
            {
                return "rock";
            }

            else if (value.ToLower() == "s")
            {
                return "scissors";
            }

            else if (value.ToLower() == "p")
            {
                return "paper";
            }

            return "";
        }

        public static string AssignOpponentVal(string value)
        {
            if (value.ToLower() == "j")
            {
                return "Jets";
            }

            else if (value.ToLower() == "s")
            {
                return "Sharks";
            }
            
            return "";
        }
    }
}
