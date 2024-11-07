using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Grupes
{
    public class VartotojuGrupe
    {
        public int VartG_ID {  get; set; }
        public string VartG_pavadinimas { get; set; }
        public string VartG_adresas {  get; set; }

        //Konstrutoriai

        public VartotojuGrupe() { }

        public VartotojuGrupe(int vartG_ID, string vartG_pavadinimas, string vartG_adresas)
        {
            VartG_ID = vartG_ID;
            VartG_pavadinimas = vartG_pavadinimas;
            VartG_adresas = vartG_adresas;
        }
    }
}
