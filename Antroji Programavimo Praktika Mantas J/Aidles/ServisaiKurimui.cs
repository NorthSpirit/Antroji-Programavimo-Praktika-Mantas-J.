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
    public class GyventojasService
    {
        public static string CreateGyventojas(MyDBContext context)
        {
            return "ThisISBULLSHIT!";
        }
    }
    public class PaslaugaCreationService
    {
        public static string CreatePaslauga(MyDBContext context, string pavadinimas, string matoVienetas, string ikainisText, int IDSelected)
        {
            float parsedIkainis;
            if (float.TryParse(ikainisText, out parsedIkainis))
            {
                Paslauga naujaPaslauga = new Paslauga
                {
                    pasl_pavadinimas = pavadinimas,
                    pasl_matovienetas = matoVienetas,
                    pasl_ikainis = parsedIkainis,
                    pasl_vartGID = IDSelected
                };
                context.Paslaugos.Add(naujaPaslauga);
                context.SaveChanges();
                return "Mokestis sukurtas.";
            }
            else
            {
                return "KLAIDA: ikainis turi būti nurodytas skaičiumi.";
            }
        }
    }
    public class VartGrupeCreationService
    {
        public static string CreateVartGrupe(MyDBContext context, string pavadinimas, string adresas)
        {
            VartotojuGrupe naujaGrupe = new VartotojuGrupe
            {
                VartG_adresas = adresas,
                VartG_pavadinimas = pavadinimas
            };
            context.vartotojuGrupes.Add(naujaGrupe);
            context.SaveChanges();
            return "Nauja grupė sukurta.";
        }
    }
    public class GyventojasCreationService
    {
        public static string CreateGyventojas(MyDBContext context, string vardas, string pavarde, string elPastas, string telNr, string vieta, string data)
        {
            DateTime naujaData;
            if (DateTime.TryParse(data, out naujaData))
            {
                Gyventojas naujasGyventojas = new Gyventojas
                {
                    naud_tipas = "Gyventojas",
                    naud_vardas = vardas,
                    naud_pavarde = pavarde,
                    naud_slaptazodis = pavarde,
                    naud_prisijungimoVardas = vardas,
                    naud_elPastas = elPastas,
                    naud_telNumeris = telNr,
                    gyv_gyvenimojiVieta = vieta,
                    gyv_gimimoData = data,
                    gyv_permoka = 0,
                    gyv_vartGID = null
                };
                context.Naudotojai.Add(naujasGyventojas);
                context.SaveChanges();
                naujasGyventojas.naud_prisijungimoVardas = naujasGyventojas.naud_vardas + naujasGyventojas.naud_ID;
                context.SaveChanges();
                return "Gyventojas sukurtas.";
            }
            else
            {
                return "Įveskite tinkamą datą (yyyy-MM-dd)";
            }
        }
    }
    public class VadybininkasCreationService
    {
        public static string CreateVadybininkas(MyDBContext context, string vardas, string pavarde, string elPastas, string telNr)
        {
            Vadybininkas naujasGyventojas = new Vadybininkas
            {
                naud_tipas = "Vadybininkas",
                naud_vardas = vardas,
                naud_pavarde = pavarde,
                naud_slaptazodis = pavarde,
                naud_prisijungimoVardas = vardas,
                naud_elPastas = elPastas,
                naud_telNumeris = telNr,
                vady_vartGID = null
            };
            context.Naudotojai.Add(naujasGyventojas);
            context.SaveChanges();
            naujasGyventojas.naud_prisijungimoVardas = naujasGyventojas.naud_vardas + naujasGyventojas.naud_ID;
            context.SaveChanges();
            return "Vadybininkas sukurtas.";
        }
    }
}
