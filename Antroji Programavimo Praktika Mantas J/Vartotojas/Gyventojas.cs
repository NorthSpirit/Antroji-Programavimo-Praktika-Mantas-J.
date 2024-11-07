using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas
{
    public class Gyventojas : Naudotojas
    {
        public string gyv_gyvenimojiVieta {  get; set; }
        public string gyv_gimimoData {  get; set; }
        public decimal gyv_permoka {  get; set; }
        public int? gyv_vartGID { get; set; }

        //Konstructoriai

        public Gyventojas() { }

        public Gyventojas(int naud_ID, string naud_vardas, string naud_pavarde, string naud_slaptazodis, string naud_prisijungimoVardas, string naud_elPastas, string naud_telNumeris,
        string gyv_gyvenimojiVieta, string gyv_gimimoData, decimal gyv_permoka, int gyv_vartGID)
        : base(naud_ID, naud_vardas, naud_pavarde, naud_slaptazodis, naud_prisijungimoVardas, naud_elPastas, naud_telNumeris, "Gyventojas")
        {
            this.gyv_gyvenimojiVieta = gyv_gyvenimojiVieta;
            this.gyv_gimimoData = gyv_gimimoData;
            this.gyv_permoka = gyv_permoka;
            this.gyv_vartGID = gyv_vartGID;
        }

        //Navigatorius
        public VartotojuGrupe VartotojuGrupe { get; set; }
    }
}
