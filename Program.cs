using System;
using System.IO;

namespace mycs_project
{

    class Program
    {
        static void Main()
        {

            // try
            // {
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine(num);
            // }
            // catch (FormatException)
            // {
            //     Console.WriteLine("Something went wrong!");
            // }

            try
            {
                int a = 5, b = 0, res;
                Console.WriteLine("Type number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type second number");
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("Res: " + res);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Something went wrong!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong!");
            } finally {
                Console.WriteLine("Finaaaly!");
            }

        }
    }
}