public class Product
{
    private int item;
    private string name;
    private decimal quantity;
    private string unit;
    private decimal price;
    private decimal itemTotal;
    private decimal total;

    public int Item { get => item; set => item = value; }
    public int Name { get => name; set => name = value; }
    public int Quantity { get => quantity; set => quantity = value; }
    public int Unit { get => unit; set => unit = value; }
    public int Price { get => price; set => price = value; }
    public int ItemTotal { get => itemTotal; set => itemTotal = value; }
    public int Total { get => total; set => total = value; }
}