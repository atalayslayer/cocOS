using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocOS
{
    class Program
    {

        
        static string cevap = "";





        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hey Yo Man! Welcome to my cocOS!");
            Console.WriteLine("Say Something!");









                cevap = Console.ReadLine();

                if (cevap != "whatsapp")
                {
                    Console.WriteLine("Hey niggah! Just whatsapp, okay!");
                }

                else
                {
                    Console.WriteLine("Hello Human! You Wanna Kill Yourself ha?");

                }

                cevap = Console.ReadLine();

                if (cevap != "no")
                {
                    Console.WriteLine("You can use simple answers for example: 'no' 'yes' 'why'. You got it?");

                }

                else
                {
                    Console.WriteLine("Hmm, I thought so, too!");
                }

                cevap = Console.ReadLine();

                if (cevap != "yes")
                {
                    Console.WriteLine("You can use simple answers for example: 'no' 'yes' 'why'. You got it?");
                }

                else
                {
                    Console.WriteLine("Wow, I think you're crazy!");
                }
            int question = 1;
            while(cevap != "exit")
            {
                if (question == 1)
                {
                    Console.WriteLine("Write Down 'exit' you dipshit");
                    cevap = Console.ReadLine().ToLower();
                    question++;
                }
                else if (question == 2)
                {
                    Console.WriteLine("Why you are not writing 'exit' you ...");
                    cevap = Console.ReadLine().ToLower();
                    question++;
                }
                else if (question == 3)
                {
                    Console.WriteLine("Please Write 'exit' im tired");
                    cevap = Console.ReadLine().ToLower();
                    question++;
                }
                else
                {
                    Console.WriteLine("Yes Finally I can Shut Myself Down What you gonna say about it");
                    cevap = Console.ReadLine().ToLower();
                    break;
                }
            }
        }
    }
}
