using System;
using System.Threading;

namespace BootSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Boot();
        }

        static void Boot()
        {

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\t\t Boot Sequence");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");

            Thread.Sleep(1000);
            Console.WriteLine("\t\t\t\t System Boot...");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Thread.Sleep(1000);
            Console.WriteLine("Doing fancy computer stuff that you wouldn't understand.");
            Thread.Sleep(2000);
            Console.WriteLine("Finishing the fancy computer stuff that a lower lifeform wouldn't understand.");
            Thread.Sleep(3000);
            Console.WriteLine("System Boot complete.");
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\t\t Welcome to Stuff");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

        }

        static void StartMenu()
        {

            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\t\t Main Menu");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("This is where all the fun happens.");
            Console.WriteLine("Please  select one of the options provided below.\n");

            Console.WriteLine("1. Google");
            Console.WriteLine("2. Make a beat");
            Console.WriteLine("3. Text to speech");
            Console.WriteLine("4. Search files\n");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Google();
                    break;

                case 2:
                    Beat();
                    break;

                case 3:
                    Speak();
                    break;

                case 4:
                    Explore();
                    break;
            }

        }

        static void Google()
        {


        }

        static void Beat()
        {


        }

        static void Speak()
        {


        }

        static void Explore()
        {


        }
    }
}
