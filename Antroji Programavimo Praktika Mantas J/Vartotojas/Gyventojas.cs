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

        //Navigatorius
        public VartotojuGrupe VartotojuGrupe { get; set; }
    }
}
