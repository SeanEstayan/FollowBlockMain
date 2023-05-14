using System;
using Display;
//using Follow;
using DummyProfiles;
//using Block;
using System.Linq;

namespace FollowBlockMain
{
    class Program
    {

        static void Main(string[] args)
        {
            Fmenu fmenu = new Fmenu();
            do
            {
                string input;
                input = fmenu.Welcome();

                switch (input) 
                {
                    case "1":


                        break;
                  
                }

                if (input.ToLower() == "x")
                {
                    Console.WriteLine("Program Terminated");
                    break;
                }
            }
            while (true);
        }
    }
}
