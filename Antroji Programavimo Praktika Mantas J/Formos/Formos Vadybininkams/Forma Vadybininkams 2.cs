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
        public MyDBContext context { get; set; }
        public Forma_Vadybininkams_2()
        {
            InitializeComponent();
        }

        private void Forma_Vadybininkams_2_Load(object sender, EventArgs e)
        {
            uzpildytitesktus();
        }

        private void btb_pakeisti_Click(object sender, EventArgs e)
        {
            label10.Text = VadybininkasUpdateService.UpdateVadybininkas(context, vadybininkasSelected, tbVardas.Text, tbPavarde.Text, tb_elPastas.Text, tb_telNr.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void uzpildytitesktus()
        {
            label1.Text = "Vadybininko ID: " + vadybininkasSelected.naud_ID;
            label2.Text = "Vadybininko Paskyros Vardas: " + vadybininkasSelected.naud_prisijungimoVardas;
            tbVardas.Text = vadybininkasSelected.naud_vardas;
            tbPavarde.Text = vadybininkasSelected.naud_pavarde;
            tb_elPastas.Text = vadybininkasSelected.naud_elPastas;
            tb_telNr.Text = vadybininkasSelected.naud_telNumeris;

            if (vadybininkasSelected.vady_vartGID != null)
            {
                VartotojuGrupe vartotojuGrupeSelected = context.vartotojuGrupes.FirstOrDefault(n => n.VartG_ID == vadybininkasSelected.vady_vartGID);
                label7.Text = "Priskirtos Grupės ID: " + vartotojuGrupeSelected.VartG_ID;
                label8.Text = "Priskirtos Pavadinimas: " + vartotojuGrupeSelected.VartG_pavadinimas;
                label9.Text = "Priskirtos Grupes Adresas: " + vartotojuGrupeSelected.VartG_adresas;
            }
            else
            {
                label7.Text = "Priskirtos Grupės ID: ";
                label8.Text = "Priskirtos Pavadinimas: ";
                label9.Text = "Priskirtos Grupes Adresas: ";
            }
        }
    }
}
