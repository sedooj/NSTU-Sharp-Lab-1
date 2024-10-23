namespace Lab1
{
    public class Appliance
    {
        public string Brand { get; }

        public double Price { get; }

        public Appliance(string brand = "", double price = 0.0)
        {
            Brand = brand;
            Price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"\nБренд: {Brand}, Цена: {Price}");
        }
    }
}

namespace Lab1
{
    public class ApplianceBuilder
    {
        private string _brand = "";
        private double _price = 0.0;

        public ApplianceBuilder SetBrand(string brand)
        {
            if (brand.Length >= 3)
            {
                _brand = brand;
            }

            return this;
        }

        public ApplianceBuilder SetPrice(double price)
        {
            _price = price;
            return this;
        }

        public Appliance Build()
        {
            return new Appliance(_brand, _price);
        }
        
    }
}