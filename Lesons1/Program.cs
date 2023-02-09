using System;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Class1 bot = new Class1();
            bot.setValues("killer", 1000, new byte[] { 0, 0, 10 });
            bot.printValues();
            Killer kiler = new Killer("killer2", 2000, new byte[] { 2, 0, 20 },100);
            kiler.printValues();
            Class1 bot1 = new Class1("Bot");
            bot1.Weight = -100;
            System.Console.WriteLine(bot1.Weight);
         
        }
               
    }
}
