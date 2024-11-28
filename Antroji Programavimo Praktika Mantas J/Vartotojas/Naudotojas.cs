using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas
{
    public abstract class Naudotojas
    {
        public int naud_ID {  get; set; }
        public string naud_vardas { get; set; }
        public string naud_pavarde { get; set; }
        public string naud_slaptazodis { get; set; }
        public string naud_prisijungimoVardas { get; set; }
        public string naud_elPastas { get; set; }
        public string naud_telNumeris { get; set; }
        public string naud_tipas { get; set; }

        //Konstruktoriai

        public Naudotojas() { }

    }
}
