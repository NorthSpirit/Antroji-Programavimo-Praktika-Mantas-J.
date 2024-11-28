using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos
{
    public partial class Forma_Gyventojams : Form
    {
        public Gyventojas gyventojasSelected { get; set; }
        public MyDBContext context { get; set; }
        public Forma_Gyventojams()
        {
            InitializeComponent();
        }

        private void Forma_Gyventojams_Load(object sender, EventArgs e)
        {
            DatagridFillerMokesciai datagridFillerMokesciai = new DatagridFillerMokesciai();
            datagridFillerMokesciai.fillDatagrid(context, dtgrd_mokejimai, gyventojasSelected.naud_ID);
            uzpildytitesktus();
        }

        private void dtgrd_mokejimai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_apieVartotoja_Click(object sender, EventArgs e)
        {
            GyventojoFormos.atidarytiPerziura(context, gyventojasSelected);
        }

        private void lbl_priskirtas_Click(object sender, EventArgs e)
        {

        }
        private void uzpildytitesktus()
        {
            lbl_vartVardas.Text = gyventojasSelected.naud_vardas + " " + gyventojasSelected.naud_pavarde;
            if (gyventojasSelected.gyv_vartGID != null)
            {
                VartotojuGrupe vartojuGrupeSelected = context.vartotojuGrupes.FirstOrDefault(n => n.VartG_ID == gyventojasSelected.gyv_vartGID);
                lbl_priskirtas.Text = "Esate priskirtas prie: " + vartojuGrupeSelected.VartG_pavadinimas;
                lbl_grupesAdresas.Text = "Adresu: " + vartojuGrupeSelected.VartG_adresas;
            }
            else
            {
                lbl_priskirtas.Text = "Jus neesate priskirtas prie jokio vartotoju grupes.";
                lbl_grupesAdresas.Text = "Prašome susisiekti su mūsų pagalbos centru, jei norite būti priskirtas";
            }
        }
    }
}
