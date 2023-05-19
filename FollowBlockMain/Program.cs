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
            LogIn login = new LogIn();
            do
            {
                string input;
                input = fmenu.Welcome();

                switch (input) 
                {
                    case "1":
                        string acc, pas;

                        acc = login.Email();
                       


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
