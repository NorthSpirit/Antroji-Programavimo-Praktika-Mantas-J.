using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic;
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

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams
{
    public partial class Admin_Redaguoti_Grupe : Form
    {
        public MyDBContext context { get; set; }
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        private string tempPavadinimas;
        private string tempAdresas;
        private List<Paslauga> paslaugos;
        private Paslauga paslaugaSelected;

        public Admin_Redaguoti_Grupe()
        {
            InitializeComponent();
        }

        private void Admin_Redaguoti_Grupe_Load(object sender, EventArgs e)
        {
            tempAdresas = vartotojuGrupeSelected.VartG_adresas;
            tempPavadinimas = vartotojuGrupeSelected.VartG_pavadinimas;
            lbl_pasirinktaGrupeID.Text = "ID: " + vartotojuGrupeSelected.VartG_ID;
            textBox2.Text = tempPavadinimas;
            textBox3.Text = tempAdresas;
            atnaujintiPaslaugas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void atnaujintiPaslaugas()
        {
            paslaugos = context.Paslaugos
            .Where(n => n.pasl_vartGID == vartotojuGrupeSelected.VartG_ID)
            .ToList();
            dtgrd_Paslaugos.DataSource = paslaugos;

            dtgrd_Paslaugos.Columns["pasl_vartGID"].Visible = false;
            dtgrd_Paslaugos.Columns["VartotojuGrupe"].Visible = false;
            dtgrd_Paslaugos.Columns["pasl_pavadinimas"].HeaderText = "Paslaugos Pavadinimas";
            dtgrd_Paslaugos.Columns["pasl_matovienetas"].HeaderText = "Mato vienetai";
            dtgrd_Paslaugos.Columns["pasl_ikainis"].HeaderText = "Paslaugos ikainis (Eur.)";
            dtgrd_Paslaugos.Columns["pasl_ID"].HeaderText = "Paslaugos ID";
            dtgrd_Paslaugos.Columns["pasl_ID"].DisplayIndex = 0;
        }
        private void lbl_pasirinktaGrupeID_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_keistiMokesti_Click(object sender, EventArgs e)
        {
            if (paslaugaSelected != null)
            {
                Paslaugos_Keitimas paslaugos_Keitimas = new Paslaugos_Keitimas();
                paslaugos_Keitimas.context = context;
                paslaugos_Keitimas.paslaugaSelected = paslaugaSelected;
                paslaugos_Keitimas.ShowDialog();
                atnaujintiPaslaugas();
            }
        }

        private void btb_istrintiMokesti_Click(object sender, EventArgs e)
        {
            if (paslaugaSelected != null)
            {
                context.Paslaugos.Remove(paslaugaSelected);
                context.SaveChanges();
                atnaujintiPaslaugas();
                paslaugaSelected = null;
                lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
            }
        }

        private void btn_sukurtiNauja_Click(object sender, EventArgs e)
        {
            if (vartotojuGrupeSelected != null)
            {
                Paslaugos_Sukurimas paslaugos_Sukurimas = new Paslaugos_Sukurimas();
                paslaugos_Sukurimas.naujas_vartGID = vartotojuGrupeSelected.VartG_ID;
                paslaugos_Sukurimas.context = context;
                paslaugos_Sukurimas.ShowDialog();
                atnaujintiPaslaugas();
            }
        }

        private void dtgrd_Paslaugos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            paslaugaSelected = selectorForAll.selectItem<Paslauga>(dtgrd_Paslaugos, e);
            if (paslaugaSelected != null) lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: " + paslaugaSelected.pasl_pavadinimas;
            else lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
            /*
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = dtgrd_Paslaugos.Rows[e.RowIndex];
                paslaugaSelected = (Paslauga)pasirinktaEilute.DataBoundItem;
                lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: " + paslaugaSelected.pasl_pavadinimas;
            }
            */
        }

        private void btn_atstatyti_Click(object sender, EventArgs e)
        {
            textBox2.Text = tempPavadinimas;
            textBox3.Text = tempAdresas;
            vartotojuGrupeSelected.VartG_pavadinimas = textBox2.Text;
            vartotojuGrupeSelected.VartG_adresas = textBox3.Text;
            context.SaveChanges();
        }

        private void btn_issaugoti_Click(object sender, EventArgs e)
        {
            vartotojuGrupeSelected.VartG_pavadinimas = textBox2.Text;
            vartotojuGrupeSelected.VartG_adresas = textBox3.Text;
            context.SaveChanges();
        }
    }
}
