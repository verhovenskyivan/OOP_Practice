using System;
using System.Net.Http.Headers;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            ModelXTerminal terminal = new ModelXTerminal("123");
            terminal.Connect();

            Console.ReadLine();
        }

        static void Do(object obj)
        {
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                //
            }

            PointRef pr1 = obj as PointRef;
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {

            }
        }
        static void NullableTypes()
        {
            PointVal? pv = null;
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }
            else
            {
                //
            }

            PointVal pv3 = pv.GetValueOrDefault();

            PointRef c = null;
            Console.WriteLine(c.X);
        }
        static void Swap( ref int a, ref int b) 
        {
            Console.WriteLine($"Original a=P{a}, b={b}");

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a=P{a}, b={b}");
        }

        static void AddNumbers(List<int> numbers) 
        {
            numbers.Add(1);
            numbers.Add(2); 
            numbers.Add(3);
        }
        static void ValRefTypes(string args)
        { 
            EvilStruct es1= new EvilStruct();
            es1.PointRef = new PointRef() { X = 1, Y = 2 };

            EvilStruct es2 = es1;

            Console.WriteLine($"es1.PointRef.X={es1.PointRef.X},es1.PointRef.Y={es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X={es2.PointRef.X},es2.PointRef.Y={es2.PointRef.Y}");

            es2.PointRef.X = 42;
            es2.PointRef.Y = 45;

            Console.WriteLine($"es1.PointRef.X={es1.PointRef.X},es1.PointRef.Y={es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X={es2.PointRef.X},es2.PointRef.Y={es2.PointRef.Y}");

            PointVal a;
            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7; 
            b.Y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("After structs");

            PointRef c = new PointRef();

            c.X = 1;
            c.Y = 2;

            PointRef d = c;
            d.X = 3;
            d.Y = 5;

            c.LogValues();
            d.LogValues();
                       
        }      
    }
}