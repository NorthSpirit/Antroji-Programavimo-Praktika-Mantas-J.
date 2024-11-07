using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas
{
    public class Vadybininkas : Naudotojas
    {
        public int? vady_vartGID {  get; set; }

        //Konstruktoriai

        //Konstructoriai

        public Vadybininkas() { }
        public Vadybininkas(int naud_ID, string naud_vardas, string naud_pavarde, string naud_slaptazodis, string naud_prisijungimoVardas, string naud_elPastas, string naud_telNumeris,
        int vady_vartGID)
        : base(naud_ID, naud_vardas, naud_pavarde, naud_slaptazodis, naud_prisijungimoVardas, naud_elPastas, naud_telNumeris, "Vadybininkas")
        {
            this.vady_vartGID = vady_vartGID;
        }

        //Navigatorius
        public VartotojuGrupe VartotojuGrupe { get; set; }
    }
}
