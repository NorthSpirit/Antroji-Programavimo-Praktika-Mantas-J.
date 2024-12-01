using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Adminai;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vartotojai;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
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
using static Antroji_Programavimo_Praktika_Mantas_J_.Formos.GyventojoFormos;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams
{
    public partial class Forma_Adminams : Form
    {
        public MyDBContext context { get; set; }
        public Administratorius administratoriusSelected { get; set; }
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        public Forma_Adminams()
        {
            InitializeComponent();
        }

        private void Forma_Adminams_Load(object sender, EventArgs e)
        {
            if (!administratoriusSelected.adm_vyriausiasis)
            {
                lbl_prisijunges.Text = "Prisijungęs Administratorius: " + administratoriusSelected.naud_vardas + " " + administratoriusSelected.naud_pavarde;
            }
            else
            {
                lbl_prisijunges.Text = "Prisijungęs Vyr. Administratorius: " + administratoriusSelected.naud_vardas + " " + administratoriusSelected.naud_pavarde;
            }
            lbl_ID.Text = "ID: " + administratoriusSelected.naud_ID;
        }

        private void lbl_prisijunges_Click(object sender, EventArgs e)
        {

        }

        private void lbl_prisijunges_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void btn_perziuretiAdmin_Click(object sender, EventArgs e)
        {
            AdministratoriausFormos.atidarytiAdminAdmin(context, administratoriusSelected);
        }

        private void btn_perziuretiGrupes_Click(object sender, EventArgs e)
        {
            Admin_Perziureti_Grupes admin_Perziureti_Grupes = new Admin_Perziureti_Grupes();
            admin_Perziureti_Grupes.context = context;
            admin_Perziureti_Grupes.vartotojuGrupeSelected = vartotojuGrupeSelected;
            admin_Perziureti_Grupes.ShowDialog();
            if (admin_Perziureti_Grupes.vartotojuGrupeSelected != null)
            {
                vartotojuGrupeSelected = admin_Perziureti_Grupes.vartotojuGrupeSelected;
                lbl_pasirinktaGrupe.Text = "Pasirinkta Grupe: " + vartotojuGrupeSelected.VartG_pavadinimas;
            }
            else
            {
                lbl_pasirinktaGrupe.Text = "Pasirinkta Grupe: ";
            }
        }

        private void btn_perziuretiGyv_Click(object sender, EventArgs e)
        {
            Admin_Gyventojai admin_Gyventojai = new Admin_Gyventojai();
            admin_Gyventojai.context = context;
            admin_Gyventojai.vartotojuGrupeSelected = vartotojuGrupeSelected;
            admin_Gyventojai.administratoriusSelected = administratoriusSelected;
            admin_Gyventojai.ShowDialog();
        }

        private void btn_perziuretiVad_Click(object sender, EventArgs e)
        {
            Admin_Vadybininkai admin_Vadybininkai = new Admin_Vadybininkai();
            admin_Vadybininkai.context = context;
            admin_Vadybininkai.vartotojuGrupeSelected = vartotojuGrupeSelected;
            admin_Vadybininkai.administratoriusSelected = administratoriusSelected;
            admin_Vadybininkai.ShowDialog();
        }
    }
}
