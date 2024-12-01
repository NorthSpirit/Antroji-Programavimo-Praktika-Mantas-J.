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
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
using static Antroji_Programavimo_Praktika_Mantas_J_.Formos.GyventojoFormos;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai
{
    public partial class Admin_Vadybininkai : Form
    {
        public MyDBContext context { get; set; }
        public Administratorius administratoriusSelected { get; set; }
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        public Vadybininkas vadybininkasSelected { get; set; }
        DatagridFillerVadybininkai datagridFillerVadybininkai = new DatagridFillerVadybininkai();

        private List<Vadybininkas> vadybininkai;
        public Admin_Vadybininkai()
        {
            InitializeComponent();
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
            if (vartotojuGrupeSelected != null) datagridFillerVadybininkai.fillDatagrid(context, dtgrd_gyventojai, vartotojuGrupeSelected.VartG_ID, administratoriusSelected.adm_vyriausiasis);
        }

        private void btn_rodytiVisus_Click(object sender, EventArgs e)
        {
            datagridFillerVadybininkai.fillDatagrid(context, dtgrd_gyventojai, -1, administratoriusSelected.adm_vyriausiasis);
        }

        private void btn_rodytiNepriskirtus_Click(object sender, EventArgs e)
        {
            datagridFillerVadybininkai.fillDatagrid(context, dtgrd_gyventojai, null, administratoriusSelected.adm_vyriausiasis);
        }

        private void btn_priskirti_Click(object sender, EventArgs e)
        {
            assignerVadybininkasToGrupe.assignVadybininkasToGrupe(context, vadybininkasSelected, vartotojuGrupeSelected);
        }

        private void btn_kurti_Click(object sender, EventArgs e)
        {
            AdministratoriausFormos.atidarytiVadyKurti(context);
        }

        private void btn_redaguoti_Click(object sender, EventArgs e)
        {
            AdministratoriausFormos.atidarytiVadyRedaguoti(context, vadybininkasSelected, administratoriusSelected, vartotojuGrupeSelected);
        }

        private void btn_atskirti_Click(object sender, EventArgs e)
        {
            unassignerVadybininkas.unassignVadybininkas(context, vadybininkasSelected);
        }

        private void btn_istrinti_Click(object sender, EventArgs e)
        {
            deleterFull deleter = new deleterFull(context);
            deleter.deleteAll(vadybininkasSelected);
            lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: ";
            datagridFillerVadybininkai.fillDatagrid(context, dtgrd_gyventojai, -1, administratoriusSelected.adm_vyriausiasis);
        }

        private void Admin_Vadybininkai_Load(object sender, EventArgs e)
        {
            atnaujintiTeksta();
        }

        private void dtgrd_gyventojai_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vadybininkasSelected = selectorForAll.selectItem<Vadybininkas>(dtgrd_gyventojai, e);
            if (vadybininkasSelected != null) lbl_pasirinktasGyventojas.Text = "Pasirinktas Vadybininkas: " + vadybininkasSelected.naud_vardas + " " + vadybininkasSelected.naud_pavarde;
            else lbl_pasirinktasGyventojas.Text = "Pasirinktas Vadybininkas: ";
        }
    }
}
