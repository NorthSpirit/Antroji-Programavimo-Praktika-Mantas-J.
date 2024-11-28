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

    namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos
    {
    public partial class Forma_Vadybininkams : Form
    {
        DatagridFillerPaslaugos datagridFillerPaslaugos = new DatagridFillerPaslaugos();
        DatagridFillerGyventojai datagridFillerGyventojai = new DatagridFillerGyventojai();
        public Vadybininkas vadybininkasSelected { get; set; }
        public MyDBContext context { get; set; }
        public Gyventojas gyventojasSelected { get; set; }
        public Paslauga paslaugaSelected { get; set; }

        public Forma_Vadybininkams()
        {
            InitializeComponent();
        }

        private void Forma_Vadybininkams_Load(object sender, EventArgs e)
        {
            uzpildytitesktus();
            datagridFillerPaslaugos.fillDatagrid(context, dtgrdMokesciai, vadybininkasSelected.vady_vartGID);
            datagridFillerGyventojai.fillDatagrid(context, dtgrdGyventojai, vadybininkasSelected.vady_vartGID, false);
        }


        private void dtgrdMokesciai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            paslaugaSelected = selectorForAll.selectItem<Paslauga>(dtgrdMokesciai, e);
            if (paslaugaSelected != null) lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: " + paslaugaSelected.pasl_pavadinimas;
            else lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
        }

        private void dtgrdGyventojai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gyventojasSelected = selectorForAll.selectItem<Gyventojas>(dtgrdGyventojai, e);
            if (gyventojasSelected != null) lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: " + gyventojasSelected.naud_prisijungimoVardas + " " + gyventojasSelected.naud_ID;
            else lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_keistiMokesti_Click(object sender, EventArgs e)
        {
            VadybininkoFormos.paslaugosKeitimas(context, paslaugaSelected);
        }

        private void btb_istrintiMokesti_Click(object sender, EventArgs e)
        {
            deleterFull deleterFull = new deleterFull(context);
            deleterFull.deleteAll(paslaugaSelected);
            datagridFillerPaslaugos.fillDatagrid(context, dtgrdMokesciai, vadybininkasSelected.vady_vartGID);
            lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
        }

        private void btn_atnaujinti_Click(object sender, EventArgs e)
        {
            datagridFillerPaslaugos.fillDatagrid(context, dtgrdMokesciai, vadybininkasSelected.vady_vartGID);
            datagridFillerGyventojai.fillDatagrid(context, dtgrdGyventojai, vadybininkasSelected.vady_vartGID, false);
        }

        private void btn_sukurtiNauja_Click(object sender, EventArgs e)
        {
            VadybininkoFormos.paslaugosKurimas(context, vadybininkasSelected.vady_vartGID);
        }

        private void btn_apieVartotoja_Click(object sender, EventArgs e)
        {
            VadybininkoFormos.atidarytiPerziura(context, vadybininkasSelected);
        }

        private void btn_priskirtiVienam_Click(object sender, EventArgs e)
        {
            assignerMokestisToGyventojas.assignMokestisToGyventojas(context, gyventojasSelected, paslaugaSelected);
        }

        private void btb_priskirtiVisiems_Click(object sender, EventArgs e)
        {
            assignerMokestisToGyventojasMass.assignMokestisToGroup(context, paslaugaSelected, vadybininkasSelected.vady_vartGID);
        }

        private void btb_perziuretiVartotoja_Click(object sender, EventArgs e)
        {
            VadybininkoFormos.atidarytiGyventojoPerziura(context, gyventojasSelected);
        }
        private void uzpildytitesktus()
        {
            lbl_ID.Text = "ID: " + vadybininkasSelected.naud_ID;
            lbl_vartVardas.Text = vadybininkasSelected.naud_vardas + " " + vadybininkasSelected.naud_pavarde;
            if (vadybininkasSelected.vady_vartGID != null)
            {
                VartotojuGrupe vartotojuGrupeSelected = context.vartotojuGrupes.FirstOrDefault(n => n.VartG_ID == vadybininkasSelected.vady_vartGID);
                lbl_priskirtas.Text = "Jums priskirta: " + vartotojuGrupeSelected.VartG_pavadinimas;
                lbl_grupesAdresas.Text = "Adresu: " + vartotojuGrupeSelected.VartG_adresas;
            }
            else
            {
                lbl_priskirtas.Text = "Šiuo metu jums nėra priskirta jokia vartotojų grupė.";
                lbl_grupesAdresas.Text = "Prašome susisiekti su savo vadovaujančiu asmeniu dėl priskyrimo.";
            }
        }
    }
}
