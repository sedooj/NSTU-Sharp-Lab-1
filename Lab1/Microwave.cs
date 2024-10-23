namespace Lab1
{
    public class Microwave : Appliance
    {
        public Microwave(int power, string color, string brand = "", double price = 0) : base(brand, price)
        {
            Power = power;
            Color = color;
        }

        public int Power { get; }

        public string Color { get; }

        public override void PrintInfo()
        {
            Console.WriteLine($"[Микроволновка фирмы {Brand}]:\n  Цена: {Price}₽, Мощность: {Power} Вт., Цвет: {Color}");
        }
    }

    public class MicrowaveBuilder
    {
        private string _brand = "";
        private double _price = 0.0;
        private int _power = 0;
        private string _color = "";

        public MicrowaveBuilder SetBrand(string brand)
        {
            if (brand.Length > 0)
            {
                _brand = brand;
            }

            return this;
        }

        public MicrowaveBuilder SetPrice(double price)
        {
            _price = price;
            return this;
        }

        public MicrowaveBuilder SetPower(int power)
        {
            if (power >= 0)
            {
                _power = power;
            }

            return this;
        }

        public MicrowaveBuilder SetColor(string color)
        {
            if (!string.IsNullOrEmpty(color))
            {
                _color = color;
            }

            return this;
        }

        public Microwave Build()
        {
            return new Microwave(_power, _color, _brand, _price);
        }
    }
}