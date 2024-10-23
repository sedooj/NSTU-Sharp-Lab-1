namespace Lab1;

public class Refrigerator : Appliance
{
    public Refrigerator(string brand = "", double price = 0, int volume = 0, bool hasFreezer = false) : base(brand, price)
    {
        Volume = volume;
        HasFreezer = hasFreezer;
    }

    public int Volume { get; }
    public bool HasFreezer { get; }

    public override void PrintInfo()
    {
        Console.WriteLine($"[Холодильник фирмы {Brand}]:\n    Цена: {Price}₽, Объем: {Volume} л., Есть морозилка: {(HasFreezer ? "Да" : "Нет")}");
    }
}

public class RefrigeratorBuilder
{
    private string _brand = "";
    private double _price = 0.0;
    private int _volume = 0;
    private bool _hasFreezer = false;

    public RefrigeratorBuilder SetBrand(string brand)
    {
        _brand = brand;
        return this;
    }

    public RefrigeratorBuilder SetPrice(double price)
    {
        _price = price;
        return this;
    }

    public RefrigeratorBuilder SetVolume(int volume)
    {
        if (volume >= 0)
        {
            _volume = volume;
        }

        return this;
    }

    public RefrigeratorBuilder SetHasFreezer(bool hasFreezer)
    {
        _hasFreezer = hasFreezer;
        return this;
    }

    public Refrigerator Build()
    {
        return new Refrigerator(_brand, _price, _volume, _hasFreezer);
    }
}