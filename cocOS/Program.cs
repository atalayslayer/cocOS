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
        static bool whatsapp = false;





        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Hey Yo Man! Welcome to my cocOS!");
            Console.WriteLine("Say Something!");








            while (cevap != "exit")
            {
                cevap = Console.ReadLine();
                if(cevap == "exit")
                {
                    break;
                }



                if (cevap == "whatsapp" && !whatsapp)
                {
                    Console.WriteLine("Hello Human! You Wanna Kill Yourself ha?");
                    whatsapp = true;

                }
                if (cevap != "whatsapp" && !whatsapp)
                {
                    Console.WriteLine("Hey niggah! Just whatsapp, okay!");

                }

                else if (cevap != "no" && cevap != "yes" && whatsapp)
                {
                    Console.WriteLine("You can use simple answers for example: 'no' 'yes' 'why'. You got it?");

                }

                else if (cevap == "no" && whatsapp)
                {
                    Console.WriteLine("Hmm, I thought so, too!");
                }

                else if (cevap == "yes" && whatsapp)
                {
                    Console.WriteLine("Wow, I think you're crazy!");
                }

            }
            int question = 1;
            cevap = "";
            while (cevap != "exit")
            {
                if (question == 1)
                {
                    Console.WriteLine("Write Down 'exit' again you dipshit");
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
