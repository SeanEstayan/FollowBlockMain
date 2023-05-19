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
        public string Password() {
            Console.Write("Password: ");
            string word = Console.ReadLine();

            return word;
        }

    }
}
