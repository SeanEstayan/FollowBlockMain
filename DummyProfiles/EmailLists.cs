using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyProfiles
{
    public class EmailLists
    {
        public List<ProfileLists> FolNam = new List<ProfileLists>();

        public void Profil()
        {

            ProfileLists Sean = new ProfileLists();
            Sean.email = "Sean@Follow";
            Sean.name = "Sean";
            Sean.pass = "sean123";
            FolNam.Add(Sean);

            ProfileLists Lorrea = new ProfileLists();
            Lorrea.email = "Lorrea@Follow";
            Lorrea.name = "Lorrea";
            Lorrea.pass = "lorrea123";
            FolNam.Add(Lorrea);

            ProfileLists Danica = new ProfileLists();
            Danica.email = "Danica@Follow";
            Danica.name = "Danica";
            Danica.pass = "danica123";
            FolNam.Add(Danica);

            ProfileLists Claris = new ProfileLists();
            Claris.email = "Claris@Follow";
            Claris.name = "Claris";
            Claris.pass = "claris123";
            FolNam.Add(Claris);
        }
    }
}
