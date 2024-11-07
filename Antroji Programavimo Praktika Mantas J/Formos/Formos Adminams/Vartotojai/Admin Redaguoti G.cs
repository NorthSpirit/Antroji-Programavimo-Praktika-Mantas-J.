using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vartotojai
{
    public partial class Admin_Redaguoti_G : Form
    {
        public Gyventojas gyventojasSelected { get; set; }

        string tempGymData;
        string tempPastas;
        string tempPasVardas;
        string tempPavarde;
        decimal tempPermoka;
        string tempTelNr;
        string tempVardas;
        string tempVieta;
        string tempSlaptazodis;

        private Gyventojas tempGyventojas;
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        public MyDBContext context { get; set; }
        public Administratorius administratoriusSelected { get; set; }
        private List<Mokejimas> mokejimai;
        private List<Paslauga> paslaugos;
        private Mokejimas mokejimasSelected;
        private Paslauga paslaugaSelected;
        public Admin_Redaguoti_G()
        {
            InitializeComponent();
        }

        private void Admin_Redaguoti_G_Load(object sender, EventArgs e)
        {

            tempVieta = gyventojasSelected.gyv_gyvenimojiVieta;
            tempVardas = gyventojasSelected.naud_vardas;
            tempTelNr = gyventojasSelected.naud_telNumeris;
            tempPermoka = gyventojasSelected.gyv_permoka;
            tempPavarde = gyventojasSelected.naud_pavarde;
            tempPasVardas = gyventojasSelected.naud_prisijungimoVardas;
            tempPastas = gyventojasSelected.naud_elPastas;
            tempGymData = gyventojasSelected.gyv_gimimoData;
            tempSlaptazodis = gyventojasSelected.naud_slaptazodis;
            lbl_error.Text = "";
            label1.Text = "Vartotojo ID: " + gyventojasSelected.naud_ID;
            uzpildytiLaukus();
            grupesMokesciai();
            vartotojoMokesciai();
        }
        private void uzpildytiLaukus()
        {
            tb_data.Text = gyventojasSelected.gyv_gimimoData;
            tb_elPastas.Text = gyventojasSelected.naud_elPastas;
            tb_paskyrosVardas.Text = gyventojasSelected.naud_prisijungimoVardas;
            tb_pavarde.Text = gyventojasSelected.naud_pavarde;
            tb_permoka.Text = gyventojasSelected.gyv_permoka.ToString();
            tb_telNr.Text = gyventojasSelected.naud_telNumeris;
            tb_vardas.Text = gyventojasSelected.naud_vardas;
            tb_vieta.Text = gyventojasSelected.gyv_gyvenimojiVieta;
        }
        private void pasirinktasGyvMokestis()
        {
            if (mokejimasSelected != null)
            {
                lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: " + mokejimasSelected.mok_pavadinimas;
            }
            else
            {
                lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
            }
        }
        private void pasirinkasGruMokestis()
        {
            if (paslaugaSelected != null)
            {
                lbl_pasirinktaPaslauga.Text = "Pasirinktas Grupės Mokestis: " + paslaugaSelected.pasl_pavadinimas;
            }
            else
            {
                lbl_pasirinktaPaslauga.Text = "Pasirinktas Grupės Mokestis: ";
            }
        }
        private void grupesMokesciai()
        {
            if (paslaugos != null)
            {
                paslaugos = context.Paslaugos
                .Where(n => n.pasl_vartGID == vartotojuGrupeSelected.VartG_ID)
                .ToList();
                dtgrd_grupesMokesciai.DataSource = paslaugos;

                dtgrd_grupesMokesciai.Columns["pasl_vartGID"].Visible = false;
                dtgrd_grupesMokesciai.Columns["VartotojuGrupe"].Visible = false;
                dtgrd_grupesMokesciai.Columns["pasl_pavadinimas"].HeaderText = "Paslaugos Pavadinimas";
                dtgrd_grupesMokesciai.Columns["pasl_matovienetas"].HeaderText = "Mato vienetai";
                dtgrd_grupesMokesciai.Columns["pasl_ikainis"].HeaderText = "Paslaugos ikainis (Eur.)";
                dtgrd_grupesMokesciai.Columns["pasl_ID"].HeaderText = "Paslaugos ID";
                dtgrd_grupesMokesciai.Columns["pasl_ID"].DisplayIndex = 0;
            }
        }
        private void vartotojoMokesciai()
        {
            mokejimai = context.Mokejimai
            .Where(n => n.mok_vartotojoID == gyventojasSelected.naud_ID)
            .ToList();

            dtgrd_mokejimai.DataSource = mokejimai;
            dtgrd_mokejimai.Columns["mok_vartotojoID"].Visible = false;
            dtgrd_mokejimai.Columns["gyventojas"].Visible = false;
            dtgrd_mokejimai.Columns["mok_ID"].HeaderText = "Mok. Numeris";
            dtgrd_mokejimai.Columns["mok_ID"].DisplayIndex = 0;
            dtgrd_mokejimai.Columns["mok_pavadinimas"].HeaderText = "Mok. Pavadinimas";
            dtgrd_mokejimai.Columns["mok_matovienetas"].HeaderText = "Mato vienetas";
            dtgrd_mokejimai.Columns["mok_ikainis"].HeaderText = "Vnt. Įkainis";
            dtgrd_mokejimai.Columns["mok_kiekis"].HeaderText = "Vienetų Suvartota";
            dtgrd_mokejimai.Columns["mok_pilnaKaina"].HeaderText = "Bendra Suma";
            dtgrd_mokejimai.Columns["mok_likutis"].HeaderText = "Sumos Likutis";
            dtgrd_mokejimai.Columns["mok_terminoPradzia"].HeaderText = "Termino Pradžia";
            dtgrd_mokejimai.Columns["mok_terminoPabaiga"].HeaderText = "Termino Pabaiga";
        }
        private void btn_issaugoti_Click(object sender, EventArgs e)
        {
            DateTime datatTikrinti;
            decimal skaiciusTikrininti;
            bool trydata = DateTime.TryParse(tb_data.Text, out datatTikrinti);
            bool tryint = decimal.TryParse(tb_permoka.Text, out skaiciusTikrininti);
            if (trydata && tryint)
            {
                gyventojasSelected.gyv_gimimoData = tb_data.Text;
                gyventojasSelected.naud_elPastas = tb_elPastas.Text;
                gyventojasSelected.naud_prisijungimoVardas = tb_paskyrosVardas.Text;
                gyventojasSelected.naud_pavarde = tb_pavarde.Text;
                gyventojasSelected.gyv_permoka = skaiciusTikrininti;
                gyventojasSelected.naud_telNumeris = tb_telNr.Text;
                gyventojasSelected.naud_vardas = tb_vardas.Text;
                gyventojasSelected.gyv_gyvenimojiVieta = tb_vieta.Text;
                context.SaveChanges();
            }
            else
            {
                if (!trydata && tryint)
                {
                    lbl_error.Text = "Įveskite tinkamą datą (yyyy-MM-dd)";
                }
                else if (trydata && !tryint)
                {
                    lbl_error.Text = "Įveskite permoką eurais";
                }
                else
                {
                    lbl_error.Text = "Įveskite tinkamą datą (yyyy-MM-dd) ir Įveskite permoką eurais";
                }
            }
        }

        private void dtgrd_mokejimai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = dtgrd_mokejimai.Rows[e.RowIndex];
                mokejimasSelected = (Mokejimas)pasirinktaEilute.DataBoundItem;
                pasirinktasGyvMokestis();
            }
        }

        private void dtgrd_grupesMokesciai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = dtgrd_grupesMokesciai.Rows[e.RowIndex];
                paslaugaSelected = (Paslauga)pasirinktaEilute.DataBoundItem;
                pasirinkasGruMokestis();
            }
        }

        private void btn_priskirtiVienam_Click(object sender, EventArgs e)
        {
            if (gyventojasSelected != null && paslaugaSelected != null)
            {
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
                vartotojoMokesciai();
            }
        }

        private void btn_trinti_Click(object sender, EventArgs e)
        {
            if (mokejimasSelected != null)
            {
                context.Mokejimai.Remove(mokejimasSelected);
                context.SaveChanges();
                vartotojoMokesciai();
                pasirinktasGyvMokestis();
                mokejimasSelected = null;
            }
        }

        private void btn_atstatyti_Click(object sender, EventArgs e)
        {
            gyventojasSelected.gyv_gimimoData = tempGymData;
            gyventojasSelected.naud_elPastas = tempPastas;
            gyventojasSelected.naud_prisijungimoVardas = tempPasVardas;
            gyventojasSelected.naud_pavarde = tempPavarde;
            gyventojasSelected.gyv_permoka = tempPermoka;
            gyventojasSelected.naud_telNumeris = tempTelNr;
            gyventojasSelected.naud_vardas = tempVardas;
            gyventojasSelected.gyv_gyvenimojiVieta = tempVieta;
            gyventojasSelected.naud_slaptazodis = tempSlaptazodis;

            context.SaveChanges();
            uzpildytiLaukus();
        }

        private void btn_slaptazodis_Click(object sender, EventArgs e)
        {
            if (administratoriusSelected.adm_vyriausiasis)
            {
                gyventojasSelected.naud_slaptazodis = gyventojasSelected.naud_prisijungimoVardas;
                lbl_error.Text = "Slaptažodis pakeistas į prisijungimo vardą.";
            }
            else
            {
                lbl_error.Text = "Tik Vyr. Administratoriai gali atstatyi slaptažodį.";
            }
        }
    }
}
