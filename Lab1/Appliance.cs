namespace Lab1;

public abstract class Appliance
{
    public string Brand { get; set; }
    public float Price { get; set; }

    protected Appliance(string brand = "", float price = 0.0f)
    {
        Brand = brand;
        Price = price;
    }

    public abstract void PrintInfo();
}