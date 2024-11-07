using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
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
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vartotojai;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai
{
    public partial class Admin_Vadybininkai : Form
    {
        public MyDBContext context { get; set; }
        public Administratorius administratoriusSelected { get; set; }
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        public Vadybininkas vadybininkasSelected { get; set; }

        private List<Vadybininkas> vadybininkai;
        public Admin_Vadybininkai()
        {
            InitializeComponent();
        }


        private void atnaujitiGyventojusVisus()
        {
            vadybininkai = context.Naudotojai
           .OfType<Vadybininkas>()
           .ToList();
            dtgrd_gyventojai.DataSource = vadybininkai;
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
            dtgrd_gyventojai.Columns["naud_vardas"].HeaderText = "Vart. Vardas";
            dtgrd_gyventojai.Columns["naud_pavarde"].HeaderText = "Vart. Pavardė";
            dtgrd_gyventojai.Columns["naud_prisijungimoVardas"].HeaderText = "Paskyros Vardas";
            dtgrd_gyventojai.Columns["naud_elPastas"].HeaderText = "El. Paštas";
            dtgrd_gyventojai.Columns["naud_telNumeris"].HeaderText = "Telefono Numeris";
            dtgrd_gyventojai.Columns["vady_vartGID"].HeaderText = "Grupės ID";
        }
        public void atnaujintiVadybininkusGrupe()
        {
            if (vartotojuGrupeSelected != null)
            {
                vadybininkai = context.Naudotojai
                .OfType<Vadybininkas>()
                .Where(n => n.vady_vartGID == vartotojuGrupeSelected.VartG_ID)
                .ToList();
                dtgrd_gyventojai.DataSource = vadybininkai;
                rodytiKaReikia();
            }
        }
        public void atnaujintiVadybininkusNepriskirtus()
        {
            vadybininkai = context.Naudotojai
            .OfType<Vadybininkas>()
            .Where(n => n.vady_vartGID == null)
            .ToList();
            dtgrd_gyventojai.DataSource = vadybininkai;
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
            atnaujintiVadybininkusGrupe();
        }

        private void btn_rodytiVisus_Click(object sender, EventArgs e)
        {
            atnaujitiGyventojusVisus();
        }

        private void btn_rodytiNepriskirtus_Click(object sender, EventArgs e)
        {
            atnaujintiVadybininkusNepriskirtus();
        }

        private void btn_priskirti_Click(object sender, EventArgs e)
        {
            if (vadybininkasSelected != null && vartotojuGrupeSelected != null)
            {
                vadybininkasSelected.vady_vartGID = vartotojuGrupeSelected.VartG_ID;
                context.SaveChanges();
            }
        }

        private void btn_kurti_Click(object sender, EventArgs e)
        {
            Admin_Kurti_Vady admin_Kurti_Vady = new Admin_Kurti_Vady();
            admin_Kurti_Vady.context = context;
            admin_Kurti_Vady.ShowDialog();
        }

        private void btn_redaguoti_Click(object sender, EventArgs e)
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

        private void btn_atskirti_Click(object sender, EventArgs e)
        {
            if (vadybininkasSelected != null)
            {
                vadybininkasSelected.vady_vartGID = null;
                context.SaveChanges();
            }
        }

        private void btn_istrinti_Click(object sender, EventArgs e)
        {
            if (vadybininkasSelected != null)
            {
                context.Naudotojai.Remove(vadybininkasSelected);
                context.SaveChanges();
                vadybininkasSelected = null;
                lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: ";
                atnaujitiGyventojusVisus();
            }
        }

        private void Admin_Vadybininkai_Load(object sender, EventArgs e)
        {
            atnaujintiTeksta();
        }

        private void dtgrd_gyventojai_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = dtgrd_gyventojai.Rows[e.RowIndex];
                vadybininkasSelected = (Vadybininkas)pasirinktaEilute.DataBoundItem;
                lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: " + vadybininkasSelected.naud_vardas + " " + vadybininkasSelected.naud_pavarde;
            }
        }
    }
}
