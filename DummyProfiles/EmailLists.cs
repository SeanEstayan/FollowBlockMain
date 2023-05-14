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
            FolNam.Add(Sean);

            ProfileLists Lorrea = new ProfileLists();
            Lorrea.email = "Lorrea@Follow";
            Lorrea.name = "Lorrea";
            FolNam.Add(Lorrea);

            ProfileLists Danica = new ProfileLists();
            Danica.email = "Danica@Follow";
            Danica.name = "Danica";
            FolNam.Add(Danica);

            ProfileLists Claris = new ProfileLists();
            Claris.email = "Claris@Follow";
            Claris.name = "Claris";
            FolNam.Add(Claris);
        }
    }
}
