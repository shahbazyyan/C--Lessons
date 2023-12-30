using System;

namespace mycs_project
{

    class Program
    {
        static void Main()
        {
            //  float user_data;
            //  user_data = Convert.ToDouble(Console.ReadLine());
            // float user_data = float.Parse(Console.ReadLine());

            // float res;
            // res = user_data * 55.258f;
            // res = user_data / 11f;
            // res = user_data + 55f;
            // res = user_data - 888f;
            // res = user_data % 3f;
            // res++;
            // res -= 10;


            // Console.WriteLine("Result " + res);


            // System.Console.WriteLine(Math.PI);
            // System.Console.WriteLine(Math.E);
            // System.Console.WriteLine(Math.Abs(-20));
            // System.Console.WriteLine(Math.Ceiling(4.12f));
            // System.Console.WriteLine(Math.Floor(4.56f));
            // System.Console.WriteLine(Math.Round(4.5));
            // System.Console.WriteLine(Math.Min(5, 99));
            // System.Console.WriteLine(Math.Max(335, 678));
            // System.Console.WriteLine(Math.Pow(5, 3));

             System.Console.WriteLine("Type a radius circle");
             double radius = Convert.ToDouble(Console.ReadLine());
             double area = Math.PI * Math.Pow(radius, 2);

             Console.WriteLine("Are circle with {0} radius is equal to {1}:", radius, area);

            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());

            int minmax = Math.Max(num, num1);

            Console.WriteLine(minmax);
        }
    }

}