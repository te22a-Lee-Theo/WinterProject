public class Player: Character
{
    public Inventory Inventory;
    public Player()
    {
        Name = "";
        Health = 100;

        Inventory = new();

        Item Shield = new()
        {
            Name = "Shield",
            Healthchange = 10
        };

        Inventory.Items.Add(Shield);



    }

    public void Displaystats()
    {
        System.Console.WriteLine($"Name: {Name} || Damage: {Mindmg} || Health: {Health} || Speed: {Speed}");
    }

    // public int Setstatchange()
    // {
        // int omo = Inventory.Getdmgchange();
        // System.Console.WriteLine(omo);
        // return omo;
    // }
    
    public void Attack()
    {

    }
    public void Parry()
    {

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
