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
    }
}
