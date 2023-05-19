using DummyProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DummyProfiles;

namespace Display
{
    public class LogIn
    {
        public string Email()
        {
            string mail;
            string pass;

            EmailLists eml = new EmailLists();

            Console.WriteLine("Email: ");
            mail = Console.ReadLine();

            if (mail.Equals(eml.Profil))
            {
                pass = Password();

                if (pass.Equals(eml.Profil))
                {

                }
            }


        }

        static string Password() {
            Console.WriteLine("Password: ");
            string word = Console.ReadLine();

            return word;
        }
    }
}
