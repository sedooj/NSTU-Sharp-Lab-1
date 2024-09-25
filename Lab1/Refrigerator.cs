namespace Lab1;

public class Refrigerator : Appliance
{
    public int Volume { get; set; }
    public bool HasFreezer { get; set; }

    public Refrigerator(string brand = "", float price = 0.0f, int volume = 100, bool hasFreezer = false)
        : base(brand, price)
    {
        Volume = volume;
        HasFreezer = hasFreezer;
    }

    public override void PrintInfo()
    {
        Console.WriteLine(
            $"\nХолодильник:\nБренд: {Brand}\nЦена: {Price}\nОбъём: {Volume} Л.\nНаличие морозильной камеры: {(HasFreezer ? "есть" : "нет")}\n");
    }
}