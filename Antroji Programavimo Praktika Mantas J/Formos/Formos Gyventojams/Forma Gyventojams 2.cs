using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
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

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Gyventojams
{
    public partial class Forma_Gyventojams_2 : Form
    {
        public Gyventojas gyventojasSelected { get; set; }
        public MyDBContext context { get; set; }
        public Forma_Gyventojams_2()
        {
            InitializeComponent();
        }

        private void Forma_Gyventojams_2_Load(object sender, EventArgs e)
        {
            uzpildytitesktus();
        }

        private void btb_pakeisti_Click(object sender, EventArgs e)
        {
            label10.Text = GyventojasUpdateService.UpdateGyventojas(context,gyventojasSelected,tbVardas.Text,tbPavarde.Text,tb_elPastas.Text,tb_telNr.Text,tb_Vieta.Text,tb_data.Text);
        }
        private void uzpildytitesktus()
        {
            label1.Text = "Vartotojo ID: " + gyventojasSelected.naud_ID;
            label2.Text = "Vartotojo Paskyros Vardas: " + gyventojasSelected.naud_prisijungimoVardas;

            tbVardas.Text = gyventojasSelected.naud_vardas;
            tbPavarde.Text = gyventojasSelected.naud_pavarde;
            tb_elPastas.Text = gyventojasSelected.naud_elPastas;
            tb_telNr.Text = gyventojasSelected.naud_telNumeris;
            tb_data.Text = gyventojasSelected.gyv_gimimoData;
            tb_Vieta.Text = gyventojasSelected.gyv_gyvenimojiVieta;

            label3.Text = "Vartotojo Vardas: " + gyventojasSelected.naud_vardas;
            label4.Text = "Vartotojo Pavarde: " + gyventojasSelected.naud_pavarde;
            label5.Text = "El. Paštas: " + gyventojasSelected.naud_elPastas;
            label6.Text = "Teleforno Nr.: " + gyventojasSelected.naud_telNumeris;
            label7.Text = "Gyvenamoji Vieta: " + gyventojasSelected.gyv_gyvenimojiVieta;

            label8.Text = "Gimimo Data: " + gyventojasSelected.gyv_gimimoData;
            label9.Text = "Permoka: " + gyventojasSelected.gyv_permoka;
            label10.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
