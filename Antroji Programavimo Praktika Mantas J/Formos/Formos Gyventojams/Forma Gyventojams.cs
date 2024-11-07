using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Microsoft.EntityFrameworkCore;
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
    public partial class Forma_Gyventojams : Form
    {
        public Gyventojas gyventojasSelected { get; set; }
        private VartotojuGrupe vartojuGrupeSelected;
        public List<Mokejimas> mokejimai;
        public MyDBContext context { get; set; }
        public Forma_Gyventojams()
        {
            InitializeComponent();
        }

        private void Forma_Gyventojams_Load(object sender, EventArgs e)
        {
            int? vartGrupesID = gyventojasSelected.gyv_vartGID;
            if (vartGrupesID != null)
            {
                vartojuGrupeSelected = context.vartotojuGrupes.FirstOrDefault(n => n.VartG_ID == vartGrupesID);
            }

            lbl_vartVardas.Text = gyventojasSelected.naud_vardas + " " + gyventojasSelected.naud_pavarde;
            if (vartojuGrupeSelected != null)
            {
                lbl_priskirtas.Text = "Esate priskirtas prie: " + vartojuGrupeSelected.VartG_pavadinimas;
                lbl_grupesAdresas.Text = "Adresu: " + vartojuGrupeSelected.VartG_adresas;
            }
            else
            {
                lbl_priskirtas.Text = "Jus neesate priskirtas prie jokio vartotoju grupes.";
                lbl_grupesAdresas.Text = "Prašome susisiekti su mūsų pagalbos centru, jei norite būti priskirtas";
            }
            mokejimai = context.Mokejimai
            .Where(n => n.mok_vartotojoID == gyventojasSelected.naud_ID)
            .ToList();
            dtgrd_mokejimai.DataSource = mokejimai;
            dtgrd_mokejimai.Columns["mok_vartotojoID"].Visible = false;
            dtgrd_mokejimai.Columns["gyventojas"].Visible = false;
            dtgrd_mokejimai.Columns["mok_ID"].HeaderText = "Mok. Numeris";
            dtgrd_mokejimai.Columns["mok_ID"].DisplayIndex = 0;
            dtgrd_mokejimai.Columns["mok_pavadinimas"].HeaderText = "Mok. Pavadinimas";
            dtgrd_mokejimai.Columns["mok_matovienetas"].HeaderText = "Mato vienetas";
            dtgrd_mokejimai.Columns["mok_ikainis"].HeaderText = "Vnt. Įkainis";
            dtgrd_mokejimai.Columns["mok_kiekis"].HeaderText = "Vienetų Suvartota";
            dtgrd_mokejimai.Columns["mok_pilnaKaina"].HeaderText = "Bendra Suma";
            dtgrd_mokejimai.Columns["mok_likutis"].HeaderText = "Sumos Likutis";
            dtgrd_mokejimai.Columns["mok_terminoPradzia"].HeaderText = "Termino Pradžia";
            dtgrd_mokejimai.Columns["mok_terminoPabaiga"].HeaderText = "Termino Pabaiga";
        }

        private void dtgrd_mokejimai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_apieVartotoja_Click(object sender, EventArgs e)
        {
            Forma_Gyventojams_2 forma_Gyventojams_2 = new Forma_Gyventojams_2();
            forma_Gyventojams_2.gyventojasSelected = gyventojasSelected;
            forma_Gyventojams_2.context = context;
            forma_Gyventojams_2.ShowDialog();
        }

        private void lbl_priskirtas_Click(object sender, EventArgs e)
        {

        }
    }
}
