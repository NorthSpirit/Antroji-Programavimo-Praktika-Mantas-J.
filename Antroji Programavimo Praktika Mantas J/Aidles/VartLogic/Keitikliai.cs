using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic
{
    public interface changerGeneric
    {
        void changevalue(MyDBContext context, Naudotojas naudotojasSelected, string toChange);
    }
    public class changerGyventojas
    {
        /*
        public string naud_vardas { get; set; }
        public string naud_pavarde { get; set; }
        public string naud_slaptazodis { get; set; }
        public string naud_elPastas { get; set; }
        public string naud_telNumeris { get; set; }
        public string gyv_gyvenimojiVieta { get; set; }
        public string gyv_gimimoData { get; set; }
        public decimal gyv_permoka { get; set; }
        public int? gyv_vartGID { get; set; }
        */
        void changevalue(MyDBContext context, Naudotojas naudotojasSelected, string toChange)
        {

        }
    }
    public class changerVadybininkas
    {
        /*
        public string naud_vardas { get; set; }
        public string naud_pavarde { get; set; }
        public string naud_slaptazodis { get; set; }
        public string naud_elPastas { get; set; }
        public string naud_telNumeris { get; set; }
        public int? vady_vartGID {  get; set; }
        */
        void changevalue(MyDBContext context, Naudotojas naudotojasSelected, string toChange)
        {

        }
    }

}
