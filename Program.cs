using System;
using System.IO;

namespace mycs_project
{

    class Program
    {
        static void Main()
        {

            Robot bot = new Robot();

            bot.setValues("Bot", 96, new byte[] { 3, 5, 7 });
            bot.printValues();

            // bot.name = "Bot";
            // bot.weight = 96;
            // bot.cordinates = new byte[] { 3, 5, 7 };

            // Console.WriteLine(bot.name + bot.weight);

            Robot robo = new Robot();
            // robo.name = "robo";
            // robo.weight = 74;
            // robo.cordinates = new byte[] { 2, 77, 89 };
            robo.setValues("Killer", 64, new byte[] { 3, 5, 7 });
            robo.printValues();


        }
    }
}