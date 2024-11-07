using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos
{
    public class Mokejimas
    {
        //Seni paslaugos
        public string mok_pavadinimas { get; set; }
        public string mok_matovienetas { get; set; }
        public float mok_ikainis { get; set; }

        public int mok_ID {  get; set; }
        public int mok_vartotojoID { get; set; }
        public float mok_kiekis {  get; set; }
        public DateTime mok_terminoPradzia { get; set; }
        public DateTime mok_terminoPabaiga { get; set; }
        public decimal mok_pilnaKaina {  get; set; }
        public decimal mok_likutis { get; set; }

        //Navigacija
        public Gyventojas Gyventojas { get; set; }

        //Konstruktoriai

        public Mokejimas() { }

        public Mokejimas(string mok_pavadinimas, string mok_matovienetas, float mok_ikainis, int mok_ID, int mok_vartotojoID, float mok_kiekis, DateTime mok_terminoPradzia, DateTime mok_terminoPabaiga, decimal mok_pilnaKaina, decimal mok_likutis)
        {
            this.mok_pavadinimas = mok_pavadinimas;
            this.mok_matovienetas = mok_matovienetas;
            this.mok_ikainis = mok_ikainis;
            this.mok_vartotojoID = mok_vartotojoID;
            this.mok_kiekis = mok_kiekis;
            this.mok_terminoPradzia = mok_terminoPradzia;
            this.mok_terminoPabaiga = mok_terminoPabaiga;
            this.mok_pilnaKaina = pasl_countPilnaKaina(mok_kiekis, mok_ikainis);
            this.mok_likutis = pasl_countPilnaKaina(mok_kiekis, mok_ikainis);
        }

        //Metodai

        private decimal pasl_countPilnaKaina(float kiekis, float kaina)
        {
            decimal apvalinta = (decimal)(kiekis * kaina);
            if (apvalinta < 0) apvalinta = 0;
            return apvalinta;
        }

        public void pasl_handleNegativeLikutis(decimal mok_Likutis, decimal mokamaSuma, decimal permoka)
        {
            decimal currentpermoka;
            if (mok_Likutis < mokamaSuma)
            {
                currentpermoka = mokamaSuma - mok_Likutis;
                permoka += currentpermoka;
                mok_Likutis = 0;

            }
            else
            {
                mok_Likutis -= mokamaSuma;
            }
        }

    }
}
