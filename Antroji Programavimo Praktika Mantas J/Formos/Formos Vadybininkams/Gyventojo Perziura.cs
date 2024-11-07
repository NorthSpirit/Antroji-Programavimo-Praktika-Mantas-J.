using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
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

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams
{
    public partial class Gyventojo_Perziura : Form
    {
        public Gyventojas gyventojasSelected { get; set; }

        public List<Mokejimas> mokejimai;
        public MyDBContext context { get; set; }
        private Mokejimas mokejimasSelected { get; set; }
        public Gyventojo_Perziura()
        {
            InitializeComponent();
        }

        private void Gyventojo_Perziura_Load(object sender, EventArgs e)
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
            atnaujintiMokejimus();
        }

        private void dtgrd_mokejimai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = dtgrd_mokejimai.Rows[e.RowIndex];
                mokejimasSelected = (Mokejimas)pasirinktaEilute.DataBoundItem;
                lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: " + mokejimasSelected.mok_pavadinimas;
            }
        }

        private void atnaujintiMokejimus()
        {
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

        private void btn_istrintiMokesti_Click(object sender, EventArgs e)
        {
            if (mokejimasSelected != null)
            {
                context.Mokejimai.Remove(mokejimasSelected);
                context.SaveChanges();
                atnaujintiMokejimus();
                lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
                mokejimasSelected = null;
            }
        }
    }
}
