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
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Adminai;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vartotojai;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai;

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
        public class AdministratoriausFormos
        {
            public static void atidaryti1(MyDBContext context, Administratorius administratoriusSelected)
            {
                Forma_Adminams forma_Adminams = new Forma_Adminams();
                forma_Adminams.administratoriusSelected = administratoriusSelected;
                forma_Adminams.context = context;
                forma_Adminams.ShowDialog();
            }
            public static void atidarytiAdminAdmin(MyDBContext context, Administratorius administratoriusSelected)
            {
                Admin_Administratoriai admin_Administratoriai = new Admin_Administratoriai();
                admin_Administratoriai.context = context;
                admin_Administratoriai.administratoriusSelected = administratoriusSelected;
                admin_Administratoriai.ShowDialog();
            }

            //Grupes
            public static void atidarytiSukurtiGrupesAdmind(MyDBContext context)
            {
                Admin_Sukurti_Grupe admin_Sukurti_Grupe = new Admin_Sukurti_Grupe();
                admin_Sukurti_Grupe.context = context;
                admin_Sukurti_Grupe.ShowDialog();
            }
            public static void atidarytiKeistiGrupesAdmin(MyDBContext context, VartotojuGrupe vartotojuGrupeSelected)
            {
                if (vartotojuGrupeSelected != null)
                {
                    Admin_Redaguoti_Grupe admin_Redaguoti_Grupe = new Admin_Redaguoti_Grupe();
                    admin_Redaguoti_Grupe.context = context;
                    admin_Redaguoti_Grupe.vartotojuGrupeSelected = vartotojuGrupeSelected;
                    admin_Redaguoti_Grupe.ShowDialog();
                }
            }

            //Gyventojai
            public static void atidarytiGyvKurti(MyDBContext context)
            {
                Admin_Kurti_G admin_Kurti_G = new Admin_Kurti_G();
                admin_Kurti_G.context = context;
                admin_Kurti_G.ShowDialog();
            }

            public static void atidarytiGyvRedaguoti(MyDBContext context, Gyventojas gyventojasSelected, Administratorius administratoriusSelected, VartotojuGrupe vartotojuGrupeSelected)
            {
                if (gyventojasSelected != null)
                {
                    Admin_Redaguoti_G admin_Redaguoti_G = new Admin_Redaguoti_G();
                    admin_Redaguoti_G.context = context;
                    admin_Redaguoti_G.vartotojuGrupeSelected = vartotojuGrupeSelected;
                    admin_Redaguoti_G.administratoriusSelected = administratoriusSelected;
                    admin_Redaguoti_G.gyventojasSelected = gyventojasSelected;
                    admin_Redaguoti_G.ShowDialog();
                }
            }
            //Vadybininkui
            public static void atidarytiVadyRedaguoti(MyDBContext context, Vadybininkas vadybininkasSelected, Administratorius administratoriusSelected, VartotojuGrupe vartotojuGrupeSelected)
            {
                if (vadybininkasSelected != null)
                {
                    Admin_Redaguoti_Vady admin_Redaguoti_Vady = new Admin_Redaguoti_Vady();
                    admin_Redaguoti_Vady.context = context;
                    admin_Redaguoti_Vady.administratoriusSelected = administratoriusSelected;
                    admin_Redaguoti_Vady.vartotojuGrupeSelected = vartotojuGrupeSelected;
                    admin_Redaguoti_Vady.vadybininkasSelected = vadybininkasSelected;
                    admin_Redaguoti_Vady.ShowDialog();
                }
            }
            public static void atidarytiVadyKurti(MyDBContext context)
            {
                Admin_Kurti_Vady admin_Kurti_Vady = new Admin_Kurti_Vady();
                admin_Kurti_Vady.context = context;
                admin_Kurti_Vady.ShowDialog();
            }
        }
    }
}
