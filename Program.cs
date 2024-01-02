using System;
using System.IO;

namespace mycs_project
{

    class Program
    {
        static void Main()
        {
            // Console.WriteLine("Type something: ");
            // string text = Console.ReadLine();
            // using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
            // {
            //  byte[] ary = System.Text.Encoding.Default.GetBytes(text);

            //  stream.Write(ary, 0, ary.Length);
            // }

            string txt = "Hello dears!";
            using (FileStream stream = new FileStream("text.txt", FileMode.OpenOrCreate))
            {
                byte[] arrtxt = System.Text.Encoding.Default.GetBytes(txt);
                stream.Write(arrtxt, 0, txt.Length);
            }

            //   using(FileStream stream1 = File.OpenRead("info.txt")) {
            //    byte[] arr = new byte[stream1.Length];
            //    stream1.Read(arr, 0, arr.Length);

            //    string textFromFile = System.Text.Encoding.Default.GetString(arr);
            //    Console.WriteLine(textFromFile);
            //   }

            using (FileStream stream = File.OpenRead("text.txt"))
            {
                byte[] newarr = new byte[stream.Length];
                stream.Read(newarr, 0, newarr.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(newarr);
                Console.WriteLine(textFromFile);

       
     }

        }
    }
}