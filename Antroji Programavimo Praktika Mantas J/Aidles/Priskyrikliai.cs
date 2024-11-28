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
    public class assignerMokestisToGyventojas
    {
        public static void assignMokestisToGyventojas(MyDBContext context, Gyventojas gyventojasSelected, Paslauga paslaugaSelected)
        {
            if (gyventojasSelected == null || paslaugaSelected == null) return;
            DateTime now = DateTime.Now;
            DateTime terminoPradzia = new DateTime(now.Year, now.Month, 1).AddMonths(1);
            DateTime terminoPabaiga = terminoPradzia.AddMonths(1).AddDays(-1);
            Mokejimas naujas = new Mokejimas
            {
                mok_ikainis = paslaugaSelected.pasl_ikainis,
                mok_matovienetas = paslaugaSelected.pasl_matovienetas,
                mok_pavadinimas = paslaugaSelected.pasl_pavadinimas,
                mok_terminoPradzia = terminoPradzia,
                mok_terminoPabaiga = terminoPabaiga,
                mok_vartotojoID = gyventojasSelected.naud_ID,
                mok_kiekis = 0,
                mok_pilnaKaina = 0,
                mok_likutis = 0,
            };
            context.Mokejimai.Add(naujas);
            context.SaveChanges();
        }
    }
    public class assignerMokestisToGyventojasMass
    {
        public static void assignMokestisToGroup(MyDBContext context, Paslauga paslaugaSelected, int? IDSelected)
        {
            if (IDSelected == null) return;

            List<Gyventojas> gyventojai = context.Naudotojai
            .OfType<Gyventojas>()
            .Where(n => n.gyv_vartGID == IDSelected)
            .ToList();

            if (paslaugaSelected != null && gyventojai.Count > 0)
            {
                DateTime now = DateTime.Now;
                DateTime terminoPradzia = new DateTime(now.Year, now.Month, 1).AddMonths(1);
                DateTime terminoPabaiga = terminoPradzia.AddMonths(1).AddDays(-1);
                foreach (Gyventojas gyventojas in gyventojai)
                {
                    Mokejimas naujas = new Mokejimas
                    {
                        mok_ikainis = paslaugaSelected.pasl_ikainis,
                        mok_matovienetas = paslaugaSelected.pasl_matovienetas,
                        mok_pavadinimas = paslaugaSelected.pasl_pavadinimas,
                        mok_terminoPradzia = terminoPradzia,
                        mok_terminoPabaiga = terminoPabaiga,
                        mok_vartotojoID = gyventojas.naud_ID,
                        mok_kiekis = 0,
                        mok_pilnaKaina = 0,
                        mok_likutis = 0,
                    };
                    context.Mokejimai.Add(naujas);
                }
                context.SaveChanges();
            }
        }
    }
 
}
