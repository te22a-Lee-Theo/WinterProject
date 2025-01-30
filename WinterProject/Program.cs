
Character one = new Player();

string Answer;

Console.WriteLine("Welcome to The Basement");
System.Console.WriteLine("I see you too have become a victim for sacrifice");
System.Console.WriteLine("Well then. Do you remember your name? (y/n)");
Answer = Console.ReadLine().ToLower();

    if (Answer == "y")
    {
        System.Console.WriteLine("Then, mind telling me your name?");
        System.Console.WriteLine("(Enter a name)");
    }
    else if (Answer == "n")
    {
        System.Console.WriteLine("That's a shame. Feel free to choose a new one");
        System.Console.WriteLine("(Enter a name)");
    }
    else
    {
        System.Console.WriteLine("Well, whether you like it or not you don't have choise but to state your name");
        System.Console.WriteLine("(Enter a name)");
    }

string dwdw = Player.GetName();
System.Console.WriteLine(dwdw);


Console.ReadLine();