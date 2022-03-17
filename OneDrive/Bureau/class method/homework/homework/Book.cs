using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    internal class Book : Product
    {     
        public string Genre;
        public Book(int no, string name, double price, int count, string genre) : base(no, name, price, count)
        {
            Genre = genre; 
        }
        public void GetInfo()
        {
            Console.WriteLine($"Number : {No}\n" +
               $"Name :{Name}\n" +
               $"Price :{Price}\n" +
               $"Count : {Count}\n" +
               $"Genre :{Genre}\n");
        }
    }
}
