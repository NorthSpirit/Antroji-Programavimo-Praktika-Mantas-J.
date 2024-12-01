using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
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
    public class VartGrupeUpdateService
    {
        public static string UpdateVartGrupe(MyDBContext context, string pavadinimas, string adresas, VartotojuGrupe vartotojuGrupe)
        {
            vartotojuGrupe.VartG_pavadinimas = pavadinimas;
            vartotojuGrupe.VartG_adresas = adresas;
            context.SaveChanges();
            return "Grupė pakeista";
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
        public static string UpdateVadybininkas(MyDBContext context, Vadybininkas vadybininkas, string vardas, string pavarde, string elPastas, string telNr, string paskyrosVardas)
        {
            vadybininkas.naud_vardas = vardas;
            vadybininkas.naud_pavarde = pavarde;
            vadybininkas.naud_elPastas = elPastas;
            vadybininkas.naud_telNumeris = telNr;
            vadybininkas.naud_prisijungimoVardas = paskyrosVardas;
            context.SaveChanges();
            return "Informacija pakeista";
        }
    }
    public class GyventojasUpdateService
    {
        public static string UpdateGyventojas(MyDBContext context, Gyventojas gyventojas, string vardas, string pavarde, string elPastas, string telNr, string gyvenamojiVieta, string data)
        {
            DateTime parsedData;
            if (DateTime.TryParse(data, out parsedData))
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
            else
            {
                return "Įveskite tinkamą datą (yyyy-MM-dd)";
            }
        }
        public static string UpdateGyventojas(MyDBContext context, Gyventojas gyventojas, string vardas, string pavarde, string elPastas, string telNr, string gyvenamojiVieta, string data, string permoka, string paskyrosVardas)
        {
            DateTime parsedData;
            decimal parsedPermoka;
            bool trydata = DateTime.TryParse(data, out parsedData);
            bool trypermoka = decimal.TryParse(permoka, out parsedPermoka);
            if (trydata && trypermoka)
            {
                gyventojas.naud_vardas = vardas;
                gyventojas.naud_pavarde = pavarde;
                gyventojas.naud_elPastas = elPastas;
                gyventojas.naud_telNumeris = telNr;
                gyventojas.gyv_gyvenimojiVieta = gyvenamojiVieta;
                gyventojas.gyv_gimimoData = data;
                gyventojas.gyv_permoka = parsedPermoka;
                gyventojas.naud_prisijungimoVardas = paskyrosVardas;
                context.SaveChanges();
                return "Informacija pakeista";
            }
            else
            {
                if (!trydata && trypermoka)
                {
                    return "Įveskite tinkamą datą (yyyy-MM-dd)";
                }
                else if (trydata && !trypermoka)
                {
                    return "Įveskite permoką eurais";
                }
                else
                {
                    return "Įveskite tinkamą datą (yyyy-MM-dd) ir Įveskite permoką eurais";
                }
            }
        }
        public class PasswordRestorationService
        {
            public static string restorePassword(MyDBContext context, bool canRestore, Naudotojas naudotojasSelected)
            {
                if (canRestore)
                {
                    naudotojasSelected.naud_slaptazodis = naudotojasSelected.naud_prisijungimoVardas + "TEST";
                    context.SaveChanges();
                    return "Slaptažodis pakeistas į prisijungimo vardą.";
                }
                else
                {
                    return "Tik Vyr. Administratoriai gali atstatyi slaptažodį.";
                }
            }
        }
    }
}
