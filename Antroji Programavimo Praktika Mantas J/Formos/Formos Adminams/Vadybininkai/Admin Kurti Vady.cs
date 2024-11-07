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

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vadybininkai
{
    public partial class Admin_Kurti_Vady : Form
    {
        public MyDBContext context { get; set; }
        public Admin_Kurti_Vady()
        {
            InitializeComponent();
        }

        private void btn_sukurti_Click(object sender, EventArgs e)
        {
            Vadybininkas naujasGyventojas = new Vadybininkas
            {
                naud_tipas = "Vadybininkas",
                naud_vardas = tb_vardas.Text,
                naud_pavarde = tb_pavarde.Text,
                naud_slaptazodis = tb_pavarde.Text,
                naud_prisijungimoVardas = tb_vardas.Text,
                naud_elPastas = tb_pastas.Text,
                naud_telNumeris = tb_telNr.Text,
                vady_vartGID = null
            };
            context.Naudotojai.Add(naujasGyventojas);
            context.SaveChanges();
            naujasGyventojas.naud_prisijungimoVardas = naujasGyventojas.naud_vardas + naujasGyventojas.naud_ID;
            context.SaveChanges();
            lbl_extra.Text = "Vadybininkas sukurtas.";
        }

        private void Admin_Kurti_Vady_Load(object sender, EventArgs e)
        {
            lbl_extra.Text = "";
        }
    }
}
