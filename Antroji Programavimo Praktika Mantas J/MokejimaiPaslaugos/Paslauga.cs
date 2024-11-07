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

        public Paslauga(int pasl_ID, string pasl_pavadinimas, string pasl_matovienetas, float pasl_ikainis)
        {
            this.pasl_ID = pasl_ID;
            this.pasl_pavadinimas = pasl_pavadinimas;
            this.pasl_matovienetas = pasl_matovienetas;
            this.pasl_ikainis = pasl_ikainis;
        }
        //Navigatorius
        public VartotojuGrupe VartotojuGrupe { get; set; }
    }
}
