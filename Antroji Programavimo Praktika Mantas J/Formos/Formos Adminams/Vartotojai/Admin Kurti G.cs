using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
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

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Vartotojai
{
    public partial class Admin_Kurti_G : Form
    {
        public MyDBContext context { get; set; }
        public Admin_Kurti_G()
        {
            InitializeComponent();
        }

        private void Admin_Kurti_G_Load(object sender, EventArgs e)
        {
            lbl_extra.Text = "";
        }

        private void btn_sukurti_Click(object sender, EventArgs e)
        {
            lbl_extra.Text = GyventojasCreationService.CreateGyventojas(context, tb_vardas.Text, tb_pavarde.Text, tb_pastas.Text, tb_telNr.Text, tb_vieta.Text, tb_data.Text);
        }
    }
}
