using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas
{
    public class Naudotojas
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

        public Naudotojas(int naud_ID, string naud_vardas, string naud_pavarde, string naud_slaptazodis, string naud_prisijungimoVardas, string naud_elPastas, string naud_telNumeris, string naud_tipas)
        {
            this.naud_ID = naud_ID;
            this.naud_vardas = naud_vardas;
            this.naud_pavarde = naud_pavarde;
            this.naud_slaptazodis = naud_slaptazodis;
            this.naud_prisijungimoVardas = naud_prisijungimoVardas;
            this.naud_elPastas = naud_elPastas;
            this.naud_telNumeris = naud_telNumeris;
            this.naud_tipas = naud_tipas;
        }

    }
}
