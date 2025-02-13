
Player one = new();

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
one.SetName();

System.Console.WriteLine($"I see. Your name is {one.GetName()}");
System.Console.WriteLine("Now are you ready to start your journey, trying to escape from The Basement? (Press enter to start)");
Console.Clear();

one.Displaystats();

Item sword = new()
{
    Name = "Sword",
    Dmgchange = 10
};

one.Inventory.Items.Add(sword);

one.Inventory.Display();

// System.Console.WriteLine($"{sword.Name}");


// int oo = one.Setstatchange();
// System.Console.WriteLine(oo);

Console.ReadLine();