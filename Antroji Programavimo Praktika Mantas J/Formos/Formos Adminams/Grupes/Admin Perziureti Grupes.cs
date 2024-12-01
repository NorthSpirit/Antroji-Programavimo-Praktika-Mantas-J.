using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
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
    public partial class Admin_Perziureti_Grupes : Form
    {
        DatagridFillerVartG DatagridFillerVartG = new DatagridFillerVartG();
        public MyDBContext context { get; set; }
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        private List<VartotojuGrupe> vartotojuGrupes;
        public Admin_Perziureti_Grupes()
        {
            InitializeComponent();
        }

        private void Admin_Perziureti_Grupes_Load(object sender, EventArgs e)
        {
            DatagridFillerVartG.fillDatagrid(context, dtgrd_vartGrupes);
            atnaujintiTeksta();
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

        private void btb_atnaujinti_Click(object sender, EventArgs e)
        {
            DatagridFillerVartG.fillDatagrid(context, dtgrd_vartGrupes);
        }

        private void dtgrd_vartGrupes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vartotojuGrupeSelected = selectorForAll.selectItem<VartotojuGrupe>(dtgrd_vartGrupes, e);
            atnaujintiTeksta();
        }

        private void btb_istrintiGrupe_Click(object sender, EventArgs e)
        {
            deleterFull deleter = new deleterFull(context);
            deleter.deleteAll(vartotojuGrupeSelected);
            lbl_pasirinktaGrupe.Text = "Pasirinkta Grupė:";
            DatagridFillerVartG.fillDatagrid(context, dtgrd_vartGrupes);
        }

        private void btn_sukurtiGrupe_Click(object sender, EventArgs e)
        {
            AdministratoriausFormos.atidarytiSukurtiGrupesAdmind(context);
            DatagridFillerVartG.fillDatagrid(context, dtgrd_vartGrupes);
        }

        private void btb_redaguoti_Click(object sender, EventArgs e)
        {
            AdministratoriausFormos.atidarytiKeistiGrupesAdmin(context, vartotojuGrupeSelected);
            DatagridFillerVartG.fillDatagrid(context, dtgrd_vartGrupes);
            atnaujintiTeksta();
        }
    }
}
