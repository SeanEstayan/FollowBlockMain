using System;
using System.Collections.Generic;
using DummyProfiles;

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

        public string LogIn() {

            EmailLists eml = new EmailLists();

			Console.WriteLine("Email: ");
			string mail = Console.ReadLine();

            if (mail.Equals(eml.Profil(Sean.email)) {

                return mail;
            }

            
		}
    }
}
