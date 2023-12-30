using System;

namespace mycs_project
{

    class Program
    {
        static void Main()
        {
            // TYPES FOR NUMBER

            int num = 9990;
            // byte num = 255;
            // short num = -3500;
            // long num = 999999999;

            // float num = 5.890f;
            // num = -888888.89767f;
            // double num = 454455.237799999d;

            // TYPE FOR string

            string word = "look ";
            // char symbol = 'l';

           // Bollean true or false

            // bool isAlive = true;
            // bool isHappy = false;

            Console.WriteLine(word  +  num);

            // Console.ReadLine();

             // Practice

            int number1, number2 = 563;

            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number2 * number1);
        }
    }

}