using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas
{
    public class Administratorius : Naudotojas
    {
        public bool adm_vyriausiasis {  get; set; }

        //Konstructoriai
        public Administratorius() { }
        public Administratorius(int naud_ID, string naud_vardas, string naud_pavarde, string naud_slaptazodis, string naud_prisijungimoVardas, string naud_elPastas, string naud_telNumeris,
        bool adm_vyriausiasis)
        : base(naud_ID, naud_vardas, naud_pavarde, naud_slaptazodis, naud_prisijungimoVardas, naud_elPastas, naud_telNumeris, "Administratorius")
        {
            this.adm_vyriausiasis = adm_vyriausiasis;
        }
    }
}