using System;

namespace homework
{
    internal class Program
    {    

        static void Main(string[] args)
        {
            Console.WriteLine("Please write how many phones do you need?");
            int genre = int.Parse(Console.ReadLine());
            Product[] products = new Product[genre];
            {
                Console.WriteLine("Please enter the Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the Price:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Count:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Number:");
                int No = int.Parse(Console.ReadLine());
                products[1] = new Product(No, name, price, count)
                {
                    No = No,
                    Name = name,
                    Price = price,
                    Count = count,
                };
                // phones[1].Ram = ram;
                // phones[1].Model = model;
                // phones[1].Storage = storage
            }
            Console.WriteLine("Properties of phones");
            foreach (var item in products) ;
            {
                //item.GetInfo();
            }
            
        }
        static int GetInputCount(int book, int min, int max)
        {
            int input;
            do
            {
                Console.WriteLine(book);
                input = int.Parse(Console.ReadLine());
            } while (input > min || input < max);
            return input;
        }
           
    }
}
