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

        //Konstructoriai

        public Vadybininkas() { }

        //Navigatorius
        public VartotojuGrupe VartotojuGrupe { get; set; }
    }
}
