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
using static Antroji_Programavimo_Praktika_Mantas_J_.Aidles.GyventojasUpdateService;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai
{
    public partial class Admin_Redaguoti_Vady : Form
    {
        public Vadybininkas vadybininkasSelected { get; set; }
        public VartotojuGrupe vartotojuGrupeSelected { get; set; }
        public Administratorius administratoriusSelected { get; set; }

        string tempPastas;
        string tempPasVardas;
        string tempPavarde;
        string tempTelNr;
        string tempVardas;

        public MyDBContext context { get; set; }
        public Admin_Redaguoti_Vady()
        {
            InitializeComponent();
        }

        private void btn_issaugoti_Click(object sender, EventArgs e)
        {
            lbl_error.Text = VadybininkasUpdateService.UpdateVadybininkas(context, vadybininkasSelected, tb_vardas.Text, tb_pavarde.Text, tb_elPastas.Text, tb_telNr.Text, tb_paskyrosVardas.Text);
        }

        private void btn_atstatyti_Click(object sender, EventArgs e)
        {
            lbl_error.Text = VadybininkasUpdateService.UpdateVadybininkas(context, vadybininkasSelected, tempVardas, tempPavarde, tempPastas, tempTelNr, tempPasVardas);
            uzpildytiLaukus();
        }

        private void uzpildytiLaukus()
        {
            lbl_error.Text = "";
            label1.Text = "Vadybininko ID: " + vadybininkasSelected.naud_ID;
            tb_elPastas.Text = vadybininkasSelected.naud_elPastas;
            tb_paskyrosVardas.Text = vadybininkasSelected.naud_prisijungimoVardas;
            tb_pavarde.Text = vadybininkasSelected.naud_pavarde;
            tb_telNr.Text = vadybininkasSelected.naud_telNumeris;
            tb_vardas.Text = vadybininkasSelected.naud_vardas;
        }
        private void uzpildytiTemp()
        {
            tempVardas = vadybininkasSelected.naud_vardas;
            tempTelNr = vadybininkasSelected.naud_telNumeris;
            tempPavarde = vadybininkasSelected.naud_pavarde;
            tempPasVardas = vadybininkasSelected.naud_prisijungimoVardas;
            tempPastas = vadybininkasSelected.naud_elPastas;
        }
        private void Admin_Redaguoti_Vady_Load(object sender, EventArgs e)
        {
            uzpildytiTemp();
            uzpildytiLaukus();
        }

        private void btn_slaptazodis_Click(object sender, EventArgs e)
        {
            lbl_error.Text = PasswordRestorationService.restorePassword(context, administratoriusSelected.adm_vyriausiasis, administratoriusSelected);
        }
    }
}
