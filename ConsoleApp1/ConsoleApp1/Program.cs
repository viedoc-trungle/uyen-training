using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num1;// Biến chứa số nhập vào từ bàn phím
            int num2;

            Console.Write("So thu 1: ");
            num1 = int.Parse(Console.ReadLine()); 

            Console.Write("So thu 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Tong 2 so la: ");
            Console.WriteLine(num1 + num2);

            Console.ReadKey();
        }
    }
}
