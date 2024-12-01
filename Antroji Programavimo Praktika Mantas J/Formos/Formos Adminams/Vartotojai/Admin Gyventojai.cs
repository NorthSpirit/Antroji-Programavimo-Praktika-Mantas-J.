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
using static Antroji_Programavimo_Praktika_Mantas_J_.Formos.GyventojoFormos;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vartotojai
{
    public partial class Admin_Gyventojai : Form
    {
        public MyDBContext context { get; set; }
        DatagridFillerGyventojai datagridFillerGyventojai = new DatagridFillerGyventojai();
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
            if (vartotojuGrupeSelected != null)datagridFillerGyventojai.fillDatagrid(context, dtgrd_gyventojai, vartotojuGrupeSelected.VartG_ID, administratoriusSelected.adm_vyriausiasis);
        }

        private void btn_rodytiVisus_Click(object sender, EventArgs e)
        {
            datagridFillerGyventojai.fillDatagrid(context, dtgrd_gyventojai, -1, administratoriusSelected.adm_vyriausiasis);
        }

        private void btn_rodytiNepriskirtus_Click(object sender, EventArgs e)
        {
            datagridFillerGyventojai.fillDatagrid(context,dtgrd_gyventojai,null,administratoriusSelected.adm_vyriausiasis);
        }

        private void dtgrd_gyventojai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gyventojasSelected = selectorForAll.selectItem<Gyventojas>(dtgrd_gyventojai, e);
            if (gyventojasSelected != null) lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: " + gyventojasSelected.naud_prisijungimoVardas + " " + gyventojasSelected.naud_ID;
            else lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: ";
        }

        private void btn_priskirti_Click(object sender, EventArgs e)
        {
            assignerGyventojasToGrupe.assignGyventojasToGrupe(context, gyventojasSelected, vartotojuGrupeSelected);
        }

        private void btn_kurti_Click(object sender, EventArgs e)
        {
            AdministratoriausFormos.atidarytiGyvKurti(context);
        }

        private void btn_redaguoti_Click(object sender, EventArgs e)
        {
            AdministratoriausFormos.atidarytiGyvRedaguoti(context, gyventojasSelected, administratoriusSelected, vartotojuGrupeSelected);
        }

        private void btn_atskirti_Click(object sender, EventArgs e)
        {
            unassignerGyventojas.unassignGyventojas(context, gyventojasSelected);
        }

        private void btn_istrinti_Click(object sender, EventArgs e)
        {
            deleterFull deleter = new deleterFull(context);
            deleter.deleteAll(gyventojasSelected);
            lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: ";
            datagridFillerGyventojai.fillDatagrid(context, dtgrd_gyventojai, -1, administratoriusSelected.adm_vyriausiasis);
        }
    }
}
