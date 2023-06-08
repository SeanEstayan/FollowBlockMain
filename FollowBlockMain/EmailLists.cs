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


        void Emlist()
        {

            ProfileLists Sean = new ProfileLists();
            Sean.email = "Sean@Follow";
            Sean.pas = "sean123";
            FolNam.Add(Sean);

            ProfileLists Lorrea = new ProfileLists();
            Lorrea.email = "Lorrea@Follow";
            Lorrea.pas = "lorrea123";
            FolNam.Add(Lorrea);

            ProfileLists Danica = new ProfileLists();
            Danica.email = "Danica@Follow";
            Danica.pas = "danica123";
            FolNam.Add(Danica);

            ProfileLists Claris = new ProfileLists();
            Claris.email = "Claris@Follow";
            Claris.pas = "claris123";
            FolNam.Add(Claris);

            ProfileLists New = new ProfileLists();


        }

        void Profl()
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
    }
}
