using System;

namespace basic_info
{
    class Asci_name_input
    {
        static void Asciname(string[] args)
        {
            Console.WriteLine("What is your NAme?");
            string name = Console.ReadLine();
            int ascicode = Console.Read();
            Console.WriteLine("Your ascicode for " + name + " is " + ascicode);
            Console.ReadKey();

        }

    }


}

    