using System;

namespace EX05Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lommeregner");
            Console.WriteLine("Skriv det første tal.");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skriv + for at lægge sammen.");
            Console.WriteLine("Skriv - for at trække fra.");
            Console.WriteLine("Skriv * for at gange.");
            Console.WriteLine("Skriv / for at dividere.");
            Console.WriteLine("Skriv % for modulo.");
            string z = Console.ReadLine();
            Console.WriteLine("Skriv det andet tal.");
            double b = Convert.ToDouble(Console.ReadLine());

            if (z == "+")
            {
                Console.WriteLine("Svar: {0}", a + b);
            }
            if (z == "-")
            {
                Console.WriteLine("Svar: {0}", a - b);
            }
            if (z == "*")
            {
                Console.WriteLine("Svar: {0}", a * b);
            }
            if (z == "/")
            {
                Console.WriteLine("Svar: {0}", a / b);
            }
            if (z == "%")
            {
                Console.WriteLine("Svar: {0}", a % b);
            }
        }
    }
}
