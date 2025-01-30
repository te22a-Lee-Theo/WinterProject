public class Player: Character
{
    public Player()
    {
        Name = "";
    }
    // public string Name;
    public List<Items> Items = new();


    public void Attack()
    {

    }
    public void Parry()
    {

    }
    public void Display()
    {

    }
    public string GetName()
    {
        Name = Console.ReadLine();

        while (string.IsNullOrEmpty(Name))
        {
            System.Console.WriteLine("You're not getting away without giving me your name");
            Name = Console.ReadLine();
        }

        return Name;
    }
}
