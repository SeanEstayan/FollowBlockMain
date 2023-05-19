using System;
using System.Collections.Generic;


namespace Display
{
    public class Fmenu
    {
        public string Welcome()
        {
            Console.WriteLine("WELCOME!");
            Console.WriteLine("1 - Log In");
            Console.WriteLine("x - exit");
            string choice = Console.ReadLine();

            return choice;
        }


    }
}
