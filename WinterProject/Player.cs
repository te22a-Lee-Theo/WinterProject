public class Player: Character
{
    public Player()
    {
        Name = "";
        Health = 100;

    }
    public List<Items> Items = new();

    public void Displaystats()
    {
        System.Console.WriteLine($"Name: {Name} || Damage: {Mindmg} || Health: {Health} || Speed: {Speed}");
    }

    public void Setstatchange()
    {
        
    }
    
    public void Attack()
    {

    }
    public void Parry()
    {

    }
    public void Display()
    {
        if (Items.Count == 0)
        {
            System.Console.WriteLine("Your inventory is empty");
        }
        else
        {
            System.Console.WriteLine("Your items:");
            for (int i = 0; i < Items.Count; i++)
            {
                System.Console.WriteLine($"{i+1}. {Items[i].Name}");
            }
        }
    }
    public void SetName()
    {
        Name = Console.ReadLine();

        while (string.IsNullOrEmpty(Name))
        {
            System.Console.WriteLine("You're not getting away without giving me your name");
            Name = Console.ReadLine();
        }
    }

    public string GetName()
    {
        return Name;
    }
}
