using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Aidles
{
    public class PaslaugaUpdateService
    {
        public static string UpdatePaslauga(MyDBContext context, string pavadinimas, string matoVienetas, string ikainisText, Paslauga paslauga)
        {
            float parsedIkainis;
            if (float.TryParse(ikainisText, out parsedIkainis))
            {
                paslauga.pasl_pavadinimas = pavadinimas;
                paslauga.pasl_matovienetas = matoVienetas;
                paslauga.pasl_ikainis = parsedIkainis;
                context.SaveChanges();
                return "Mokestis pakeistas.";
            }
            else
            {
                return "KLAIDA: ikainis turi būti nurodytas skaičiumi.";
            }
        }
    }
    public class VadybininkasUpdateService
    {
        public static string UpdateVadybininkas(MyDBContext context, Vadybininkas vadybininkas, string vardas, string pavarde, string elPastas, string telNr)
        {
            vadybininkas.naud_vardas = vardas;
            vadybininkas.naud_pavarde = pavarde;
            vadybininkas.naud_elPastas = elPastas;
            vadybininkas.naud_telNumeris = telNr;
            context.SaveChanges();
            return "Informacija pakeista";
        }
    }
    public class GyventojasUpdateService
    {
        public static string UpdateGyventojas(MyDBContext context, Gyventojas gyventojas, string vardas, string pavarde, string elPastas, string telNr, string gyvenamojiVieta, string data)
        {
                gyventojas.naud_vardas = vardas;
                gyventojas.naud_pavarde = pavarde;
                gyventojas.naud_elPastas = elPastas;
                gyventojas.naud_telNumeris = telNr;
                gyventojas.gyv_gyvenimojiVieta = gyvenamojiVieta;
                gyventojas.gyv_gimimoData = data;
                context.SaveChanges();
                return "Informacija pakeista";
        }
    }
}
