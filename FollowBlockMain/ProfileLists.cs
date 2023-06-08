using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBlockMain
{
    public class ProfileLists
    {
        public string email;
        public string pas;
    }

    public class TimeLine
    {
        public string posts;
    }

    public class Profiles
    {
        public string proname;
        public string prosname;
        public int following;
        public int followers;
        public int blocked;
    }

    public class Follow { 
    public string follow;
    }

    public class Block {
        public string block;
    }
}
