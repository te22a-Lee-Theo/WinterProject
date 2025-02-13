public class Inventory
{
    public List<Item> Items = new();

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
}
