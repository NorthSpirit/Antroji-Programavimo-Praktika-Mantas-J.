using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams
{
    public partial class Paslaugos_Sukurimas : Form
    {
        public MyDBContext context { get; set; }
        public int naujas_vartGID { get; set; }
        public Paslaugos_Sukurimas()
        {
            InitializeComponent();
        }

        private void Paslaugos_Sukurimas_Load(object sender, EventArgs e)
        {
        }

        private void btn_atsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_isaugoti_Click(object sender, EventArgs e)
        {
            lbl_klaida.Text = PaslaugaCreationService.CreatePaslauga(context,tb_pavadinimas.Text,tb_matoVienetas.Text, tb_Ikaitis.Text, naujas_vartGID);
        }
    }
}
