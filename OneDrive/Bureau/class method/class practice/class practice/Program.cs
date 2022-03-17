using System;

namespace class_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write how many laptops do you need?");
            int type_count = int.Parse(Console.ReadLine());
            Notebook[] notebooks = new Notebook[type_count];
          
            {
                Console.WriteLine("Please enter the Brand:");
                string brandName = Console.ReadLine();
                Console.WriteLine("Please enter the Model:");
                string model = Console.ReadLine();
                Console.WriteLine("Please enter the Ram:");
                int ram = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the size of storage:");
                int storage = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Price:");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the count:");
                int count = int.Parse(Console.ReadLine());
                notebooks[1] = new Notebook(brandName, price, count)
                {
                    Model = model,
                    Storage = storage,
                    Ram = ram,
                };
                // notebooks[i].Ram = ram;
                // notebooks[i].Model = model;
                // notebooks[i].Storage = storage
            }
            Console.WriteLine("List of notebboks");
            foreach (var item in notebooks)
            {
                item.GetInfo();
            }

        }
        static int GetInputCount(string name, int min, int max)
        {
            int input;
            do
            {
                Console.WriteLine(name);
                input = int.Parse(Console.ReadLine());
            } while (input > min || input < max);  
            return input;
        }
    }
}

