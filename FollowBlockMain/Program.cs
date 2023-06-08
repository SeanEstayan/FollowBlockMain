using System;
using System.Linq;

namespace FollowBlockMain
{
    class Program
    {

        static List<string> Sfeed = new List<string>();
        static List<string> Lfeed = new List<string>();
        static List<string> Dfeed = new List<string>();
        static List<string> Cfeed = new List<string>();
        static List<string> Nfeed = new List<string>();
        static List<string> SBList = new List<string>();
        static List<string> LBList = new List<string>();
        static List<string> DBList = new List<string>();
        static List<string> CBList = new List<string>();
        static List<string> NBList = new List<string>();
        static List<string> SFList = new List<string>();
        static List<string> LFList = new List<string>();
        static List<string> DFList = new List<string>();
        static List<string> CFList = new List<string>();
        static List<string> NFList = new List<string>();
        static int i;
        static void Main(string[] args)
        {

            SFList.Add("Kyla");
            LFList.Add("Kyla");
            DFList.Add("Kyla");
            CFList.Add("Kyla");

            SBList.Add("Cai");
            LBList.Add("Cai");
            DBList.Add("Cai");
            CBList.Add("Cai");

            //Profiles NewP = new Profiles();

            Fmenu fmenu = new Fmenu();
            ProfileLists plist = new ProfileLists();
            LogIn login = new LogIn();
            EmailLists elist = new EmailLists();

            do
            {
                string input;
                input = fmenu.Welcome();

                switch (input)
                {
                    case "1":
                        string pass, emil, chr;
                        int sum;

                        Console.WriteLine("\n===LOG IN===");
                        Console.Write("Email: ");
                        emil = Console.ReadLine();
 
                        if (emil.Equals(elist.Sean.email))
                            {
                            pass = login.Password();

                            if (pass == fol.pas)
                            {
                                do {

                                    fmenu.ShowProfile(elist.Prol.);
                                    chr = fmenu.Screen();

                                    switch (chr)
                                    {

                                        case "1":

                                            for (i = 0; i < SFList.Count; i++)
                                            {
                                                Console.WriteLine(SFList[i]);

                                            }

                                            break;

                                        case "2":

                                            for (i = 0; i < SBList.Count; i++)
                                            {
                                                Console.WriteLine(SBList[i]);

                                            }

                                            break;

                                        case "3":

                                            Console.WriteLine("Search: ");
                                            var search = Console.ReadLine();
                                       //     var tosearch = prol.Find(x => x.proname == search);
                                       //     tosearch = prol.Find(x => x.prosname == search);

                                            Console.WriteLine("Do you wish to follow/block? type F / B");
                                            string fb = Console.ReadLine().ToLower();



                                    /*        switch (fb)
                                            {
                                                case "f":

                                                    if (!SFList.Contains(tosearch.proname)) { SFList.Add($"{tosearch.proname} {tosearch.prosname}");
                                                        sum = tosearch.following + 1;
                                                        SeanP.following = sum; }

                                                    else { Console.WriteLine("Already Following"); } break;


                                                case "b":
                                                    if (!SBList.Contains(tosearch.proname))
                                                    {
                                                        SBList.Add($"{tosearch.proname} {tosearch.prosname}");
                                                        sum = tosearch.blocked + 1;
                                                        SeanP.blocked = sum;
                                                    }

                                                    else { Console.WriteLine("Already Following"); } break;


                                            }*/
                                            break;
                                    }
                                } while (chr != "x");
                            }                  
                }
                                break;
                  case "2":
                        Console.WriteLine("~~~SIGN UP~~~");

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
