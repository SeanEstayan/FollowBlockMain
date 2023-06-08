using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBlockMain
{
    public class EmailLists
    {
        public List<ProfileLists> FolNam = new List<ProfileLists>();
        public List<Profiles> Prol = new List<Profiles>();
        public List<string> Sfeed = new List<string>();
        public List<string> Lfeed = new List<string>();
        public List<string> Dfeed = new List<string>();
        public List<string> Cfeed = new List<string>();
        public List<string> Nfeed = new List<string>();
        public List<string> SBList = new List<string>();
        public List<string> LBList = new List<string>();
        public List<string> DBList = new List<string>();
        public List<string> CBList = new List<string>();
        public List<string> NBList = new List<string>();
        public List<string> SFList = new List<string>();
        public List<string> LFList = new List<string>();
        public List<string> DFList = new List<string>();
        public List<string> CFList = new List<string>();
        public List<string> NFList = new List<string>();


        void AddEmail(ProfileLists fileli)
        {
            FolNam.Add(fileli);
        }

        void Profl(Profiles selif)
        {
            Profiles SeanP = new Profiles();
            SeanP.proname = "Sean";
            SeanP.prosname = "Estayan";
            SeanP.following = 1;
            SeanP.followers = 0;
            SeanP.blocked = 1;
            Prol.Add(SeanP);

            Profiles LorreaP = new Profiles();
            LorreaP.proname = "Lorrea";
            LorreaP.prosname = "Hugo";
            LorreaP.following = 1;
            LorreaP.followers = 0;
            LorreaP.blocked = 1;
            Prol.Add(LorreaP);

            Profiles DanicaP = new Profiles();
            DanicaP.proname = "Danica";
            DanicaP.prosname = "Cabrera";
            DanicaP.following = 1;
            DanicaP.followers = 0;
            DanicaP.blocked = 1;
            Prol.Add(DanicaP);

            Profiles ClarisP = new Profiles();
            ClarisP.proname = "Claris";
            ClarisP.prosname = "Batacandolo";
            ClarisP.following = 1;
            ClarisP.followers = 0;
            ClarisP.blocked = 1;
            Prol.Add(ClarisP);

        }

        void AddFollow()
        {
            SFList.Add("Kyla");
            LFList.Add("Kyla");
            DFList.Add("Kyla");
            CFList.Add("Kyla");

            SBList.Add("Cai");
            LBList.Add("Cai");
            DBList.Add("Cai");
            CBList.Add("Cai");
        }
    }
}
