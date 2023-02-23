using RoshamboLabExercise;

bool UserWantToConinue = true;
Validationcl.humanplayerCount = 0;
Validationcl.RandomPlayerCount = 0;
Validationcl.DrawCount = 0;

Console.WriteLine("Welcome to Rock Paper Scissors!");
Console.Write("Enter your name:");
var name = Console.ReadLine();
Console.Write("Would you like to play against The Jets or TheSharks (j/s)?:");
var UserOption = Console.ReadLine();
string cValid = Validationcl.validateuserinput(UserOption);
if (cValid != "")
{
    Console.WriteLine(cValid);
    Environment.Exit(0);
}



do
{
    
    Console.Write("Rock, Paper, or Scissors? (r/p/s):");
    var PlayCategory = Console.ReadLine();

    string PlayCategValid = Validationcl.validateuserinput(PlayCategory);
    if (PlayCategValid != "")
    {
        Console.WriteLine(PlayCategValid);
        break;
    }

    HumanPlayer human = new HumanPlayer(UserOption);
    human.Name = name;
    human.RoshamboValue = Validationcl.AssignplayCategory(PlayCategory);
    
    var result = human.GenerateRoshambo();

    Console.WriteLine($"{human.Name}:{Validationcl.AssignplayCategory(PlayCategory)}");
    Console.WriteLine($"{Validationcl.AssignOpponentVal(UserOption)}:{result}");
    var winner = Validationcl.selectwinner(Validationcl.AssignplayCategory(PlayCategory), result, Validationcl.AssignOpponentVal(UserOption));
    if ( winner != null )
    {
        if (winner == "HumanPlayer")
        {
            Console.WriteLine($"{human.Name} Wins!");
        }
        else
            Console.WriteLine(winner);
    }
    Console.WriteLine("");
    Console.Write("Play again ? (y/n): ");
    var Continue = Console.ReadLine();
    string ValidAnswer = Validationcl.validateuserinput(Continue);
    if (ValidAnswer != "")
    {
        Console.WriteLine(ValidAnswer);
        break;
    }
    if (Continue.ToLower() == "n")
    {
        Console.WriteLine($"{human.Name} won  {Validationcl.humanplayerCount} times");
        Console.WriteLine($"{Validationcl.AssignOpponentVal(UserOption)} won  {Validationcl.RandomPlayerCount} times");
        Console.WriteLine($"Draw {Validationcl.DrawCount} times");
        UserWantToConinue = false;
    }
    

}while(UserWantToConinue);

