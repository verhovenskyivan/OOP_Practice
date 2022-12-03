using System;
using System.Net.Http.Headers;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double square1 = calc.CalcTriangleSquare(10, 20);
            double square2 =calc.CalcTriangleSquare(10, 20, 30);

            Console.WriteLine($"Square1={square1}. Square2={square2}");
        }
    }
}