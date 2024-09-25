namespace Lab1;

public class Microwave : Appliance
{
    public int Power { get; set; }

    public float Capacity { get; set; }

    public Microwave(string brand = "", float price = 0.0f, int power = 700, float capacity = 20.0f)
        : base(brand, price)
    {
        Power = power;
        Capacity = capacity;
    }

    public override void PrintInfo()
    {
        Console.WriteLine(
            $"\nМикроволновая печь:\nБренд: {Brand}\nЦена: {Price}\nМощность: {Power} Ватт\nВместимость: {Capacity} Л.\n");
    }
}