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
            VartotojuGrupe naujaGrupe = new VartotojuGrupe
            {
                VartG_adresas = tb_grupesAdresas.Text,
                VartG_pavadinimas = tb_pavadinimas.Text,
            };
            context.vartotojuGrupes.Add(naujaGrupe);
            context.SaveChanges();
            lbl_extra.Text = "Nauja grupė sukurta.";
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
