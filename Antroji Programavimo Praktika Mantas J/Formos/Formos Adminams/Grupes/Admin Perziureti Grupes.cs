using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
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
    public partial class Admin_Perziureti_Grupes : Form
    {
        public MyDBContext context { get; set; }
        public VartotojuGrupe VartotojuGrupeSelected { get; set; }
        private List<VartotojuGrupe> vartotojuGrupes;
        public Admin_Perziureti_Grupes()
        {
            InitializeComponent();
        }

        private void Admin_Perziureti_Grupes_Load(object sender, EventArgs e)
        {
            uzkrautiGrupes();
            atnaujintiTeksta();
        }
        private void uzkrautiGrupes()
        {
            vartotojuGrupes = context.vartotojuGrupes
            .ToList();
            var rodymui = context.vartotojuGrupes
                .Select(n => new
                {
                    VartotojuGrupe = n,
                    n.VartG_ID,
                    n.VartG_adresas,
                    n.VartG_pavadinimas,
                    gyventojai = context.Naudotojai
                .OfType<Gyventojas>()
                .Count(m => m.gyv_vartGID == n.VartG_ID && m.naud_tipas == "Gyventojas")
                }
                )
                .ToList();

            dtgrd_vartGrupes.DataSource = rodymui;
            dtgrd_vartGrupes.Columns["VartotojuGrupe"].Visible = false;
            dtgrd_vartGrupes.Columns["VartG_adresas"].HeaderText = "Vartotjų Grupės Adresas";
            dtgrd_vartGrupes.Columns["VartG_pavadinimas"].HeaderText = "Vartotojų Grupės Pavadinimas";
            dtgrd_vartGrupes.Columns["gyventojai"].HeaderText = "Gyventojų Skaičius";
            dtgrd_vartGrupes.Columns["vartG_ID"].HeaderText = "Grupės ID";
            dtgrd_vartGrupes.Columns["vartG_ID"].DisplayIndex = 0;
        }
        private void atnaujintiTeksta()
        {
            if (VartotojuGrupeSelected != null)
            {
                lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė: " + VartotojuGrupeSelected.VartG_pavadinimas;
                lbl_pasirinktaGrupeAdresas.Text = "Adresas: " + VartotojuGrupeSelected.VartG_adresas;
                lbl_pasirinktaGrupeID.Text = "ID: " + VartotojuGrupeSelected.VartG_ID;
            }
            else
            {
                lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė: NONE";
                lbl_pasirinktaGrupeAdresas.Text = "Adresas: ";
                lbl_pasirinktaGrupeID.Text = "ID: ";
            }
        }

        private void btb_atnaujinti_Click(object sender, EventArgs e)
        {
            uzkrautiGrupes();
        }

        private void dtgrd_vartGrupes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = (dynamic)dtgrd_vartGrupes.Rows[e.RowIndex].DataBoundItem;
                VartotojuGrupeSelected = pasirinktaEilute.VartotojuGrupe;
                atnaujintiTeksta();
            }
        }

        private void btb_istrintiGrupe_Click(object sender, EventArgs e)
        {
            context.vartotojuGrupes.Remove(VartotojuGrupeSelected);
            context.SaveChanges();
            VartotojuGrupeSelected = null;
            atnaujintiTeksta();
            uzkrautiGrupes();
        }

        private void btn_sukurtiGrupe_Click(object sender, EventArgs e)
        {
            Admin_Sukurti_Grupe admin_Sukurti_Grupe = new Admin_Sukurti_Grupe();
            admin_Sukurti_Grupe.context = context;
            admin_Sukurti_Grupe.ShowDialog();
            uzkrautiGrupes();
        }

        private void btb_redaguoti_Click(object sender, EventArgs e)
        {
            if (VartotojuGrupeSelected != null)
            {
                Admin_Redaguoti_Grupe admin_Redaguoti_Grupe = new Admin_Redaguoti_Grupe();
                admin_Redaguoti_Grupe.context = context;
                admin_Redaguoti_Grupe.vartotojuGrupeSelected = VartotojuGrupeSelected;
                admin_Redaguoti_Grupe.ShowDialog();
                uzkrautiGrupes();
                if (VartotojuGrupeSelected != null)
                {
                    lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė: " + VartotojuGrupeSelected.VartG_pavadinimas;
                    lbl_pasirinktaGrupeAdresas.Text = "Adresas: " + VartotojuGrupeSelected.VartG_adresas;
                    lbl_pasirinktaGrupeID.Text = "ID: " + VartotojuGrupeSelected.VartG_ID;
                }
                else
                {
                    lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė: NONE";
                    lbl_pasirinktaGrupeAdresas.Text = "Adresas: ";
                    lbl_pasirinktaGrupeID.Text = "ID: ";
                }
            }
        }
    }
}
