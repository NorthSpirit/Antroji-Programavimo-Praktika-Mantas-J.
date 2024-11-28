using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Gyventojams;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos
{
    public class GyventojoFormos
    {
        public static void atidaryti1(MyDBContext context, Gyventojas gyventojasSelected)
        {
            Forma_Gyventojams forma_Gyventojams = new Forma_Gyventojams();
            forma_Gyventojams.gyventojasSelected = gyventojasSelected;
            forma_Gyventojams.context = context;
            forma_Gyventojams.ShowDialog();
        }
        public static void atidarytiPerziura(MyDBContext context, Gyventojas gyventojasSelected)
        {
            Forma_Gyventojams_2 forma_Gyventojams_2 = new Forma_Gyventojams_2();
            forma_Gyventojams_2.gyventojasSelected = gyventojasSelected;
            forma_Gyventojams_2.context = context;
            forma_Gyventojams_2.ShowDialog();
        }
        public class VadybininkoFormos
        {
            public static void atidaryti1(MyDBContext context, Vadybininkas vadybininkasSelected)
            {
                Forma_Vadybininkams forma_Vadybininkams = new Forma_Vadybininkams();
                forma_Vadybininkams.vadybininkasSelected = vadybininkasSelected;
                forma_Vadybininkams.context = context;
                forma_Vadybininkams.ShowDialog();
            }
            public static void atidarytiPerziura(MyDBContext context, Vadybininkas vadybininkasSelected)
            {
                Forma_Vadybininkams_2 forma_Vadybininkams_2 = new Forma_Vadybininkams_2();
                forma_Vadybininkams_2.vadybininkasSelected = vadybininkasSelected;
                forma_Vadybininkams_2.context = context;
                forma_Vadybininkams_2.ShowDialog();
            }
            public static void atidarytiGyventojoPerziura(MyDBContext context, Gyventojas gyventojasSelected)
            {
                if (gyventojasSelected != null)
                {
                    Gyventojo_Perziura gyventojo_Perziura = new Gyventojo_Perziura();
                    gyventojo_Perziura.context = context;
                    gyventojo_Perziura.gyventojasSelected = gyventojasSelected;
                    gyventojo_Perziura.ShowDialog();
                }
            }
            public static void paslaugosKurimas(MyDBContext context, int? IDSelected)
            {
                if (IDSelected != null)
                {
                    int IDN = IDSelected.Value;
                    Paslaugos_Sukurimas paslaugos_Sukurimas = new Paslaugos_Sukurimas();
                    paslaugos_Sukurimas.naujas_vartGID = IDN;
                    paslaugos_Sukurimas.context = context;
                    paslaugos_Sukurimas.ShowDialog();
                }
            }
            public static void paslaugosKeitimas(MyDBContext context, Paslauga paslaugaSelected)
            {
                if (paslaugaSelected != null)
                {
                    Paslaugos_Keitimas paslaugos_Keitimas = new Paslaugos_Keitimas();
                    paslaugos_Keitimas.context = context;
                    paslaugos_Keitimas.paslaugaSelected = paslaugaSelected;
                    paslaugos_Keitimas.ShowDialog();
                }
            }
        }
        public class AdminuFormos
        {
            public static void atidaryti1(MyDBContext context, Administratorius administratoriusSelected)
            {
                Forma_Adminams forma_Adminams = new Forma_Adminams();
                forma_Adminams.administratoriusSelected = administratoriusSelected;
                forma_Adminams.context = context;
                forma_Adminams.ShowDialog();
            }
        }
    }
}
