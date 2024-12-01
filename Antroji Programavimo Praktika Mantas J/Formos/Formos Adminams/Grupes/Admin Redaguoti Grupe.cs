using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Antroji_Programavimo_Praktika_Mantas_J_.Formos.GyventojoFormos;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams
{
    public partial class Admin_Redaguoti_Grupe : Form
    {
        public MyDBContext context { get; set; }
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        DatagridFillerPaslaugos datagridFillerPaslaugos = new DatagridFillerPaslaugos();
        private string tempPavadinimas;
        private string tempAdresas;
        private Paslauga paslaugaSelected;

        public Admin_Redaguoti_Grupe()
        {
            InitializeComponent();
        }

        private void Admin_Redaguoti_Grupe_Load(object sender, EventArgs e)
        {
            sustatytiTemp();
            sustatytiTexta();
            datagridFillerPaslaugos.fillDatagrid(context, dtgrd_Paslaugos, vartotojuGrupeSelected.VartG_ID);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_pasirinktaGrupeID_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_keistiMokesti_Click(object sender, EventArgs e)
        {
            VadybininkoFormos.paslaugosKeitimas(context, paslaugaSelected);
            datagridFillerPaslaugos.fillDatagrid(context, dtgrd_Paslaugos, vartotojuGrupeSelected.VartG_ID);
        }

        private void btb_istrintiMokesti_Click(object sender, EventArgs e)
        {
            deleterFull deleterFull = new deleterFull(context);
            deleterFull.deleteAll(paslaugaSelected);
            datagridFillerPaslaugos.fillDatagrid(context, dtgrd_Paslaugos, vartotojuGrupeSelected.VartG_ID);
            lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
        }

        private void btn_sukurtiNauja_Click(object sender, EventArgs e)
        {
            VadybininkoFormos.paslaugosKurimas(context, vartotojuGrupeSelected.VartG_ID);
            datagridFillerPaslaugos.fillDatagrid(context, dtgrd_Paslaugos, vartotojuGrupeSelected.VartG_ID);
        }

        private void dtgrd_Paslaugos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            paslaugaSelected = selectorForAll.selectItem<Paslauga>(dtgrd_Paslaugos, e);
            if (paslaugaSelected != null) lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: " + paslaugaSelected.pasl_pavadinimas;
            else lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
        }

        private void btn_atstatyti_Click(object sender, EventArgs e)
        {
            label1.Text = VartGrupeUpdateService.UpdateVartGrupe(context, tempPavadinimas, tempAdresas, vartotojuGrupeSelected);
            sustatytiTexta();
        }

        private void btn_issaugoti_Click(object sender, EventArgs e)
        {
            label1.Text = VartGrupeUpdateService.UpdateVartGrupe(context,textBox2.Text,textBox3.Text, vartotojuGrupeSelected);
        }
        private void sustatytiTexta()
        {
            lbl_pasirinktaGrupeID.Text = "ID: " + vartotojuGrupeSelected.VartG_ID;
            label1.Text = "";
            textBox2.Text = tempPavadinimas;
            textBox3.Text = tempAdresas;
        }
        private void sustatytiTemp()
        {
            tempAdresas = vartotojuGrupeSelected.VartG_adresas;
            tempPavadinimas = vartotojuGrupeSelected.VartG_pavadinimas;
        }
    }
}
