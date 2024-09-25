using Lab1;

class Program
{
    static void Main()
    {
        List<Appliance> appliances = new List<Appliance>();
        int choice;

        do
        {
            Console.WriteLine("1. Добавить микроволновую печь\n2. Добавить холодильник\n3. Напечатать все приборы\n4. Выйти");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Введите марку, цену, мощность, ёмкость через пробел: ");
                var input = Console.ReadLine().Split(' ');
                string brand = input[0];
                float price = float.Parse(input[1]);
                int power = int.Parse(input[2]);
                float capacity = float.Parse(input[3]);
                appliances.Add(new Microwave(brand, price, power, capacity));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите марку, цену, объем, Наличие морозильной камеры (1/0) через пробел: ");
                var input = Console.ReadLine().Split(' ');
                string brand = input[0];
                float price = float.Parse(input[1]);
                int volume = int.Parse(input[2]);
                bool hasFreezer = int.Parse(input[3]) == 1;
                appliances.Add(new Refrigerator(brand, price, volume, hasFreezer));
            }
            else if (choice == 3)
            {
                foreach (var appliance in appliances)
                {
                    appliance.PrintInfo();
                }
            }
        } while (choice != 4);
    }
}

