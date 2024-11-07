using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
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

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams
{
    public partial class Forma_Vadybininkams_2 : Form
    {
        public Vadybininkas vadybininkasSelected { get; set; }
        public VartotojuGrupe vartojuGrupeSelected { get; set; }
        public MyDBContext context { get; set; }
        private int pakeistika = 2;
        public Forma_Vadybininkams_2()
        {
            InitializeComponent();
        }

        private void Forma_Vadybininkams_2_Load(object sender, EventArgs e)
        {

            label1.Text = "Vadybininko ID: " + vadybininkasSelected.naud_ID;
            label2.Text = "Vadybininko Paskyros Vardas: " + vadybininkasSelected.naud_prisijungimoVardas;
            label3.Text = "Vadybininko Vardas: " + vadybininkasSelected.naud_vardas;
            label4.Text = "Vadybininko Pavarde: " + vadybininkasSelected.naud_pavarde;
            label5.Text = "El. Paštas: " + vadybininkasSelected.naud_elPastas;
            label6.Text = "Teleforno Nr.: " + vadybininkasSelected.naud_telNumeris;
            if (vadybininkasSelected.vady_vartGID != null)
            {
                label7.Text = "Priskirtos Grupės ID: " + vartojuGrupeSelected.VartG_ID;
                label8.Text = "Priskirtos Pavadinimas: " + vartojuGrupeSelected.VartG_pavadinimas;
                label9.Text = "Priskirtos Grupes Adresas: " + vartojuGrupeSelected.VartG_adresas;
            }
            else
            {
                label7.Text = "Priskirtos Grupės ID: ";
                label8.Text = "Priskirtos Pavadinimas: ";
                label9.Text = "Priskirtos Grupes Adresas: ";
            }

        }

        private void btb_pakeisti_Click(object sender, EventArgs e)
        {
            switch (pakeistika)
            {
                case 1:
                    vadybininkasSelected.naud_elPastas = textBox1.Text;
                    context.SaveChanges();
                    break;
                case 2:
                    vadybininkasSelected.naud_telNumeris = textBox1.Text;
                    context.SaveChanges();
                    break;
                default:
                    break;

            }
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
