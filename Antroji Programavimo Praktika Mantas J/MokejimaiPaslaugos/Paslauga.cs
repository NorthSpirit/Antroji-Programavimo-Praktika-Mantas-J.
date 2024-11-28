using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos
{
    public class Paslauga
    {
        public int pasl_ID { get; set; }
        public string pasl_pavadinimas { get; set; }
        public string pasl_matovienetas { get; set; }
        public float pasl_ikainis { get; set; }
        public int pasl_vartGID { get; set; }

        //Konstrutoriai

        public Paslauga() { }

        //Navigatorius
        public VartotojuGrupe VartotojuGrupe { get; set; }
    }
}
