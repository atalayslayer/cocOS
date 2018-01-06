using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocOS
{
    class Program
    {

        
        static string cevap = "whatsapp";
        static string cevap1 = "no";
        static string cevap2 = "yes";
        static string cevap3 = "why?";





        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hey Yo Man! Welcome to my cocOS!");
            Console.WriteLine("Say Something!");








            while (cevap != "exit" || cevap1 != "exit" || cevap2 != "exit" || cevap3 != "exit")
            {
                cevap = Console.ReadLine();

                if (cevap != "whatsapp")
                {
                    Console.WriteLine("Hey niggah! Just whatsapp, okay!");
                }

                else
                {
                    Console.WriteLine("Hello Human! You Wanna Kill Yourself ha?");

                }

                cevap1 = Console.ReadLine();

                if (cevap1 != "no")
                {
                    Console.WriteLine("You can use simple answers for example: 'no' 'yes' 'why'. You got it?");

                }

                else
                {
                    Console.WriteLine("Hmm, I thought so, too!");
                }

                cevap2 = Console.ReadLine();

                if (cevap2 != "yes")
                {
                    Console.WriteLine("You can use simple answers for example: 'no' 'yes' 'why'. You got it?");
                }

                else
                {
                    Console.WriteLine("Wow, I think you're crazy!");
                }












            }
        }
    }
}
