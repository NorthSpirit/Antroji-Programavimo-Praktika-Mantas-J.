using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
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
}
