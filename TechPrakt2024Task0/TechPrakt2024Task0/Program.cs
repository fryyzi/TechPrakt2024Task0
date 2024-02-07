using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPrakt2024Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть перше число: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Ведіть дурге число: ");
            int number_2 = int.Parse(Console.ReadLine());
            
            int sum = number + number_2;

            Console.WriteLine($"Сума чисел буде: {sum}");
        }
    }
}
