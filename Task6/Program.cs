using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task6_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Retry:
            Console.WriteLine("Введите чисо 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int number2 = int.Parse(Console.ReadLine());
        RetryOperand:
            Console.WriteLine("Ведите функцию +");
            string operand = Console.ReadLine();
            int result = 0;
        }
    }
}

