using Lab1;

class Program
{
    static void Main()
    {
        List<Appliance> appliances = new List<Appliance>();
        DropMenu(appliances);
    }

    private static void DropMenu(List<Appliance> appliances)
    {
        int choice;

        do
        {
            Console.WriteLine("1. Добавить микроволновую печь\n2. Добавить холодильник\n3. Напечатать все приборы\n4. Выйти\nВыбранное действие: ");
            int.TryParse(Console.ReadLine(), out choice);

            if (choice == 1)
            {
                appliances.Add(CreateNewMicrowave());
            }
            else if (choice == 2)
            {
                appliances.Add(CreateNewRefrigerator());
            }
            else if (choice == 3)
            {
                Console.WriteLine();
                foreach (var appliance in appliances)
                {
                    appliance.PrintInfo();
                }
                Console.WriteLine();
            }
        } while (choice != 4);
    }
    
    private static Refrigerator CreateNewRefrigerator()
    {
        Console.WriteLine("Введите марку холодильника:");
        var brand = Console.ReadLine();
        Console.WriteLine("Введите цену холодильника:");
        double.TryParse(Console.ReadLine(), out double price);
        Console.WriteLine("Введите емкость холодильника:");
        int.TryParse(Console.ReadLine(), out int volume);
        Console.WriteLine("Есть ли у холодильника морозильная камера?(true/false):");
        bool.TryParse(Console.ReadLine(), out bool hasFreezer);
        return new RefrigeratorBuilder()
            .SetBrand(brand)
            .SetPrice(price)
            .SetVolume(volume)
            .SetHasFreezer(hasFreezer)
            .Build();
    }

    private static Microwave CreateNewMicrowave()
    {
        Console.WriteLine("Введите марку микроволновки:");
        var brand = Console.ReadLine();
        Console.WriteLine("Введите цену микроволновки:");
        double.TryParse(Console.ReadLine(), out double price);
        Console.WriteLine("Введите мощность микроволновки:");
        int.TryParse(Console.ReadLine(), out int power);
        Console.WriteLine("Введите цвет микроволновки:");
        var color = Console.ReadLine();
        return new MicrowaveBuilder()
            .SetBrand(brand)
            .SetPrice(price)
            .SetPower(power)
            .SetColor(color)
            .Build();
    }

}

