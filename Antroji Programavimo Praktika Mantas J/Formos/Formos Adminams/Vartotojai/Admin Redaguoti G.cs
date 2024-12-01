using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
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
using static Antroji_Programavimo_Praktika_Mantas_J_.Aidles.GyventojasUpdateService;

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

        DatagridFillerPaslaugos datagridFillerPaslaugos = new DatagridFillerPaslaugos();
        DatagridFillerMokesciai datagridFillerMokesciai = new DatagridFillerMokesciai();
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
            datagridFillerPaslaugos.fillDatagrid(context, dtgrd_grupesMokesciai, gyventojasSelected.gyv_vartGID);
            datagridFillerMokesciai.fillDatagrid(context, dtgrd_mokejimai, gyventojasSelected.naud_ID);
            uzpildytiText();
            uzpildytiTemp();
            grupesMokesciai();
            vartotojoMokesciai();
        }
        private void uzpildytiText()
        {
            lbl_error.Text = "";
            label1.Text = "Vartotojo ID: " + gyventojasSelected.naud_ID;
            tb_data.Text = gyventojasSelected.gyv_gimimoData;
            tb_elPastas.Text = gyventojasSelected.naud_elPastas;
            tb_paskyrosVardas.Text = gyventojasSelected.naud_prisijungimoVardas;
            tb_pavarde.Text = gyventojasSelected.naud_pavarde;
            tb_permoka.Text = gyventojasSelected.gyv_permoka.ToString();
            tb_telNr.Text = gyventojasSelected.naud_telNumeris;
            tb_vardas.Text = gyventojasSelected.naud_vardas;
            tb_vieta.Text = gyventojasSelected.gyv_gyvenimojiVieta;
        }
        private void uzpildytiTemp()
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
            lbl_error.Text = GyventojasUpdateService.UpdateGyventojas(context, gyventojasSelected, tb_vardas.Text, tb_pavarde.Text, tb_elPastas.Text, tb_telNr.Text, tb_vieta.Text, tb_data.Text, tb_permoka.Text, tb_paskyrosVardas.Text);
        }

        private void dtgrd_mokejimai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mokejimasSelected = selectorForAll.selectItem<Mokejimas>(dtgrd_mokejimai, e);
            pasirinktasGyvMokestis();
        }

        private void dtgrd_grupesMokesciai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            paslaugaSelected = selectorForAll.selectItem<Paslauga>(dtgrd_grupesMokesciai, e);
            pasirinkasGruMokestis();
        }

        private void btn_priskirtiVienam_Click(object sender, EventArgs e)
        {
            assignerMokestisToGyventojas.assignMokestisToGyventojas(context, gyventojasSelected, paslaugaSelected);
            datagridFillerMokesciai.fillDatagrid(context, dtgrd_mokejimai, gyventojasSelected.naud_ID);
        }

        private void btn_trinti_Click(object sender, EventArgs e)
        {
            deleterFull deleter = new deleterFull(context);
            deleter.deleteAll(mokejimasSelected);
            lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
            datagridFillerMokesciai.fillDatagrid(context, dtgrd_mokejimai, gyventojasSelected.naud_ID);
        }

        private void btn_atstatyti_Click(object sender, EventArgs e)
        {
            lbl_error.Text = GyventojasUpdateService.UpdateGyventojas(context, gyventojasSelected, tempVardas, tempPavarde, tempPastas, tempTelNr, tempVieta, tempGymData, tempPermoka.ToString(), tempPasVardas);
            uzpildytiText();
        }

        private void btn_slaptazodis_Click(object sender, EventArgs e)
        {
            lbl_error.Text = PasswordRestorationService.restorePassword(context, administratoriusSelected.adm_vyriausiasis, gyventojasSelected);
        }
    }
}
