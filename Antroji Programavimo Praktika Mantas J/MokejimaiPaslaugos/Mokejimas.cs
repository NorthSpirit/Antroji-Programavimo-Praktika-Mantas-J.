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

        //Metodai
        /*
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
        */
    }
}
