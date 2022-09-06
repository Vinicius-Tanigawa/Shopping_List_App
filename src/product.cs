public class Product
{
    //private int item; Pode pegar sujeira de memória
    private decimal itemTotal;
    private decimal total;

    unsafe static void input (int* item, string* name, decimal* quantity, string* unit, decimal* price)
    {
        *item++;
        Console.WriteLine("Item " + *item);
        Console.WriteLine("Insert the name of the product: ");
        string *name = Console.ReadLine();
        Console.WriteLine("Inform the quantity of the product: ");
        decimal *quantity = Console.ReadLine();
        Console.WriteLine("Inform the unit of measure of the quantity: ");
        string *unit = Console.ReadLine();
        Console.WriteLine("Inform the price of the product: ");
        decimal *price = Console.ReadLine();
    }
    unsafe static void Main()
    {
        int item = 0;
        string name, unit;
        decimal quantity, price;
        bool exit;
        do
        {
            input(&item, &name, &quantity, &unit, &price);
        } while(exit = false);
    }
    public decimal ItemTotal { get => itemTotal; set => itemTotal = value; }
    public decimal Total { get => total; set => total = value; }

}