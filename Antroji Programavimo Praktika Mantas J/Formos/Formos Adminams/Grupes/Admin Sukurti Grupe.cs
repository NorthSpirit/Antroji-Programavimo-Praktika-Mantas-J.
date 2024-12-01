using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams
{
    public partial class Admin_Sukurti_Grupe : Form
    {
        public MyDBContext context { get; set; }
        public Admin_Sukurti_Grupe()
        {
            InitializeComponent();
        }

        private void tb_pavadinimas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_isaugoti_Click(object sender, EventArgs e)
        {
            lbl_extra.Text = VartGrupeCreationService.CreateVartGrupe(context, tb_pavadinimas.Text, tb_grupesAdresas.Text);
        }

        private void btn_atsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Sukurti_Grupe_Load(object sender, EventArgs e)
        {
            lbl_extra.Text = "";
        }
    }
}
