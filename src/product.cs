using System;
namespace ShoppingApp
{

    struct List
    {
        int item = 0;
        string name, unit, brand;
        decimal quantity, price, itemTotal;
        bool exit;
    }
    public class Product
    {
        //private int item; Pode pegar sujeira de memória
        private decimal itemTotal;
        private decimal total;
    
        unsafe static void input (int* item, string* name, string* brand, decimal* quantity, string* unit, decimal* price)
        {
            *item++;
            Console.WriteLine("Item " + *item);
            Console.WriteLine("Insert the name of the product: ");
            string *name = Console.ReadLine();
            Console.WriteLine("Inform the brand of the product: ");
            string *brand = Console.ReadLine();
            Console.WriteLine("Inform the quantity of the product: ");
            decimal *quantity = Console.ReadLine();
            Console.WriteLine("Inform the unit of measure of the quantity: ");
            string *unit = Console.ReadLine();
            Console.WriteLine("Inform the price of the product: ");
            decimal *price = Console.ReadLine();
            *itemTotal = (*quantity) * (*price);
            Console.WriteLine("The total price of item " + *item, " is: " + *itemTotal);
        
        }
    
        unsafe static void Main()
        {
            var list = new List [];
            int i=0;
            decimal total;
            do
            {
                input(&list[i].item, &list[i].name, &list[i].brand, &list[i].quantity, &list[i].unit, &list[i].price);
                total += list[i].itemTotal;
                i++;
            } while(exit = false);
            Console.WriteLine("The total price is: " + total);

        }
    
        public decimal ItemTotal { get => itemTotal; set => itemTotal = value; }
        public decimal Total { get => total; set => total = value; }
    
    }
}