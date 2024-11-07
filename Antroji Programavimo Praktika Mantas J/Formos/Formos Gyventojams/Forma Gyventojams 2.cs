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

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos
{
    public partial class Forma_Gyventojams_2 : Form
    {
        public Gyventojas gyventojasSelected { get; set; }
        public MyDBContext context { get; set; }
        private int pakeistika = 2;
        public Forma_Gyventojams_2()
        {
            InitializeComponent();

        }

        private void Forma_Gyventojams_2_Load(object sender, EventArgs e)
        {
            label1.Text = "Vartotojo ID: " + gyventojasSelected.naud_ID;
            label2.Text = "Vartotojo Paskyros Vardas: " + gyventojasSelected.naud_prisijungimoVardas;
            label3.Text = "Vartotojo Vardas: " + gyventojasSelected.naud_vardas;
            label4.Text = "Vartotojo Pavarde: " + gyventojasSelected.naud_pavarde;
            label5.Text = "El. Paštas: " + gyventojasSelected.naud_elPastas;
            label6.Text = "Teleforno Nr.: " + gyventojasSelected.naud_telNumeris;
            label7.Text = "Gyvenamoji Vieta: " + gyventojasSelected.gyv_gyvenimojiVieta;
            label8.Text = "Gimimo Data: " + gyventojasSelected.gyv_gimimoData;
            label9.Text = "Permoka: " + gyventojasSelected.gyv_permoka;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            lbl_pakeistiKa.Text = "Pakeisti gyvenamąją vietą.";
            pakeistika = 3;
        }

        private void btb_pakeisti_Click(object sender, EventArgs e)
        {
            switch(pakeistika)
            {
                case 1:
                    gyventojasSelected.naud_elPastas = textBox1.Text;
                    context.SaveChanges();
                    break;
                case 2:
                    gyventojasSelected.naud_telNumeris = textBox1.Text;
                    context.SaveChanges();
                    break;
                case 3:
                    gyventojasSelected.gyv_gyvenimojiVieta = textBox1.Text;
                    context.SaveChanges();
                    break;
                default:
                    break;
            }
            label1.Text = "Vartotojo ID: " + gyventojasSelected.naud_ID;
            label2.Text = "Vartotojo Paskyros Vardas: " + gyventojasSelected.naud_prisijungimoVardas;
            label3.Text = "Vartotojo Vardas: " + gyventojasSelected.naud_vardas;
            label4.Text = "Vartotojo Pavarde: " + gyventojasSelected.naud_pavarde;
            label5.Text = "El. Paštas: " + gyventojasSelected.naud_elPastas;
            label6.Text = "Teleforno Nr.: " + gyventojasSelected.naud_telNumeris;
            label7.Text = "Gyvenamoji Vieta: " + gyventojasSelected.gyv_gyvenimojiVieta;
            label8.Text = "Gimimo Data: " + gyventojasSelected.gyv_gimimoData;
            label9.Text = "Permoka: " + gyventojasSelected.gyv_permoka;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lbl_pakeistiKa.Text = "Pakeisti el. Paštą";
            pakeistika = 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            lbl_pakeistiKa.Text = "Pakeisti tel. nr.";
            pakeistika = 2;
        }
    }
}
