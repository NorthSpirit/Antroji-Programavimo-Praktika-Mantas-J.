using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
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

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams
{
    public partial class Gyventojo_Perziura : Form
    {
        public Gyventojas gyventojasSelected { get; set; }
        DatagridFillerMokesciai datagridFillerMokesciai = new DatagridFillerMokesciai();
        public MyDBContext context { get; set; }
        private Mokejimas mokejimasSelected { get; set; }
        public Gyventojo_Perziura()
        {
            InitializeComponent();
        }

        private void Gyventojo_Perziura_Load(object sender, EventArgs e)
        {
            uzpildytitesktus();
            datagridFillerMokesciai.fillDatagrid(context, dtgrd_mokejimai, gyventojasSelected.naud_ID);
        }

        private void dtgrd_mokejimai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mokejimasSelected = selectorForAll.selectItem<Mokejimas>(dtgrd_mokejimai, e);
            if (mokejimasSelected != null) lbl_pasirinktasMokestis.Text = "Pasirinktas Mokejimas: " + mokejimasSelected.mok_pavadinimas;
            else lbl_pasirinktasMokestis.Text = "Pasirinktas Mokejimas: ";
        }

        private void btn_istrintiMokesti_Click(object sender, EventArgs e)
        {
            deleterFull deleter = new deleterFull(context);
            deleter.deleteAll(mokejimasSelected);
            lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
            datagridFillerMokesciai.fillDatagrid(context, dtgrd_mokejimai, gyventojasSelected.naud_ID);
        }
        private void uzpildytitesktus()
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
    }
}
