

Orchestrate();

int GetInput()
{
    int sides = 0;
    bool isInt = false;
    while(!isInt)
    {
        Console.WriteLine("How many sided die would you like? \n");
        isInt = int.TryParse(Console.ReadLine(), out sides);
        if (!isInt)
        {
            Console.WriteLine("That is not a valid integer, try again... \n");
        }
    }
    return sides;
}

static int Roll(int sides)
{
    Random dice = new Random();
    return dice.Next(1, sides + 1);
}

static string ForSixSided(int rollOne, int rollTwo)
{
    switch(rollOne + rollTwo)
    {
        case 2:
            return "Snake Eyes";
        case 3:
            return "Ace Deuce";
        case 12:
            return "Box Cars";
        case 7:
            return "Win";
        case 11:
            return "Win";
        default:
            return "";
           
    }
}

static string ForThreeSided(int rollOne, int rollTwo)
{
    switch(rollOne + rollTwo)
    {
        case 2:
            return "TouchDown!";
        case 3:
            return "7 yard penalty for steroid use!";
        case 6:
            return "OVER THE LINE! MARK IT ZERO!";
        default:
            return "";
    }
}

void Orchestrate()
{
    Console.WriteLine("Welcome to Ceasar Sportsball Casino, where you can lose all of your rent money from your phone while taking a dump! \n");
    int sides = GetInput();
    int rollOne;
    int rollTwo;
    bool isPlay = true;
    Console.WriteLine($"Alrighty you chose {sides} \n");
    while (isPlay)
    {
        Console.WriteLine("press <r> to roll! \n");
        if(Console.ReadLine().ToLower().Trim() != "r")
        {
            Console.WriteLine("You can't do that here! The brothel is across the street!");
            continue;
        }
        rollOne = Roll(sides);
        rollTwo = Roll(sides);
        
        string game = sides == 3 ? ForThreeSided(rollOne, rollTwo) : sides == 6 ? ForSixSided(rollOne, rollTwo) : "Yay!";
        Console.WriteLine($"You rolled a {rollOne} and {rollTwo} for a total of {rollOne + rollTwo}... {game}  \n");
        Console.WriteLine("Would you like to try your luck again? <y> or <n> ?  \n");
        isPlay = Console.ReadLine().Trim().ToLower() == "y";
    }
    Console.WriteLine("Alright, go take out a loan so you can come back and gamble more stupid!  \n");
    Environment.Exit(0);
    

}
