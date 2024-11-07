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
    public partial class Admin_Gyventojai : Form
    {
        public MyDBContext context { get; set; }
        public Administratorius administratoriusSelected { get; set; }
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        public Gyventojas gyventojasSelected { get; set; }
        private List<Gyventojas> gyventojai;
        public Admin_Gyventojai()
        {
            InitializeComponent();
        }

        private void Admin_Gyventojai_Load(object sender, EventArgs e)
        {
            atnaujintiTeksta();
        }

        private void atnaujitiGyventojusVisus()
        {
            gyventojai = context.Naudotojai
           .OfType<Gyventojas>()
           .ToList();
            dtgrd_gyventojai.DataSource = gyventojai;
            rodytiKaReikia();
        }
        public void rodytiKaReikia()
        {
            dtgrd_gyventojai.Columns["VartotojuGrupe"].Visible = false;
            dtgrd_gyventojai.Columns["naud_tipas"].Visible = false;
            if (!administratoriusSelected.adm_vyriausiasis)
            {
                dtgrd_gyventojai.Columns["naud_slaptazodis"].Visible = false;
            }
            else
            {
                dtgrd_gyventojai.Columns["naud_slaptazodis"].HeaderText = "Naudotojo Slaptazodis";
            }
            dtgrd_gyventojai.Columns["naud_ID"].HeaderText = "Naudotojo ID";
            dtgrd_gyventojai.Columns["naud_ID"].DisplayIndex = 0;
            dtgrd_gyventojai.Columns["gyv_gimimoData"].HeaderText = "Vart. Gymimo Data";
            dtgrd_gyventojai.Columns["naud_vardas"].HeaderText = "Vart. Vardas";
            dtgrd_gyventojai.Columns["naud_pavarde"].HeaderText = "Vart. Pavardė";
            dtgrd_gyventojai.Columns["naud_prisijungimoVardas"].HeaderText = "Paskyros Vardas";
            dtgrd_gyventojai.Columns["naud_elPastas"].HeaderText = "El. Paštas";
            dtgrd_gyventojai.Columns["naud_telNumeris"].HeaderText = "Telefono Numeris";
            dtgrd_gyventojai.Columns["gyv_vartGID"].HeaderText = "Pris. Gr. ID";
            dtgrd_gyventojai.Columns["gyv_permoka"].HeaderText = "Permoka (Eur.)";
        }
        public void atnaujintiGyventojusGrupe()
        {
            if (vartotojuGrupeSelected != null)
            {
                gyventojai = context.Naudotojai
                .OfType<Gyventojas>()
                .Where(n => n.gyv_vartGID == vartotojuGrupeSelected.VartG_ID)
                .ToList();
                dtgrd_gyventojai.DataSource = gyventojai;
                rodytiKaReikia();
            }
        }
        public void atnaujintiGyventojusNepriskirtus()
        {
            gyventojai = context.Naudotojai
            .OfType<Gyventojas>()
            .Where(n => n.gyv_vartGID == null)
            .ToList();
            dtgrd_gyventojai.DataSource = gyventojai;
            rodytiKaReikia();
        }
        private void atnaujintiTeksta()
        {
            if (vartotojuGrupeSelected != null)
            {
                lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė: " + vartotojuGrupeSelected.VartG_pavadinimas;
                lbl_pasirinktaGrupeAdresas.Text = "Adresas: " + vartotojuGrupeSelected.VartG_adresas;
                lbl_pasirinktaGrupeID.Text = "ID: " + vartotojuGrupeSelected.VartG_ID;
            }
            else
            {
                lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė: NONE";
                lbl_pasirinktaGrupeAdresas.Text = "Adresas: ";
                lbl_pasirinktaGrupeID.Text = "ID: ";
            }
        }

        private void btn_rodytiGrupes_Click(object sender, EventArgs e)
        {
            atnaujintiGyventojusGrupe();
        }

        private void btn_rodytiVisus_Click(object sender, EventArgs e)
        {
            atnaujitiGyventojusVisus();
        }

        private void btn_rodytiNepriskirtus_Click(object sender, EventArgs e)
        {
            atnaujintiGyventojusNepriskirtus();
        }

        private void dtgrd_gyventojai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = dtgrd_gyventojai.Rows[e.RowIndex];
                gyventojasSelected = (Gyventojas)pasirinktaEilute.DataBoundItem;
                lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: " + gyventojasSelected.naud_vardas + " " + gyventojasSelected.naud_pavarde;
            }
        }

        private void btn_priskirti_Click(object sender, EventArgs e)
        {
            if (gyventojasSelected != null && vartotojuGrupeSelected != null)
            {
                gyventojasSelected.gyv_vartGID = vartotojuGrupeSelected.VartG_ID;
                context.SaveChanges();
            }
        }

        private void btn_kurti_Click(object sender, EventArgs e)
        {
            Admin_Kurti_G admin_Kurti_G = new Admin_Kurti_G();
            admin_Kurti_G.context = context;
            admin_Kurti_G.ShowDialog();
        }

        private void btn_redaguoti_Click(object sender, EventArgs e)
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

        private void btn_atskirti_Click(object sender, EventArgs e)
        {
            if (gyventojasSelected != null)
            {
                gyventojasSelected.gyv_vartGID = null;
                context.SaveChanges();
            }
        }

        private void btn_istrinti_Click(object sender, EventArgs e)
        {
            if (gyventojasSelected != null)
            {
                context.Naudotojai.Remove(gyventojasSelected);
                context.SaveChanges();
                gyventojasSelected = null;
                lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: ";
                atnaujitiGyventojusVisus();
            }
        }
    }
}
