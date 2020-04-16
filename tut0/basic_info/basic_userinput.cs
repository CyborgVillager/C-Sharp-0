using System;


namespace basic_info
{
    class basic_userinput
    {
        static void New(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(name + " welcome to CS m8 ");
            Console.ReadKey();


        }
       
    }
}
