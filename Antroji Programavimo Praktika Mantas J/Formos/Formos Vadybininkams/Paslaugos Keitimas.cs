using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
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
    public partial class Paslaugos_Keitimas : Form
    {
        public Paslauga paslaugaSelected { get; set; }
        public MyDBContext context { get; set; }
        string tempPavadinimas;
        string tempMatoVienetas;
        float tempIkainis;
        public Paslaugos_Keitimas()
        {
            InitializeComponent();
        }

        private void Paslaugos_Keitimas_Load(object sender, EventArgs e)
        {
            tempPavadinimas = paslaugaSelected.pasl_pavadinimas;
            tempMatoVienetas = paslaugaSelected.pasl_matovienetas;
            tempIkainis = paslaugaSelected.pasl_ikainis;

            tb_pavadinimas.Text = paslaugaSelected.pasl_pavadinimas;
            tb_matoVienetas.Text = paslaugaSelected.pasl_matovienetas;
            tb_Ikaitis.Text = paslaugaSelected.pasl_ikainis.ToString();
        }

        private void btn_atstatyti_Click(object sender, EventArgs e)
        {
            paslaugaSelected.pasl_pavadinimas = tempPavadinimas;
            paslaugaSelected.pasl_matovienetas = tempMatoVienetas;
            paslaugaSelected.pasl_ikainis = tempIkainis;
            lbl_klaida.Text = "Mokestis atstatyas.";
            context.SaveChanges();

            tb_pavadinimas.Text = paslaugaSelected.pasl_pavadinimas;
            tb_matoVienetas.Text = paslaugaSelected.pasl_matovienetas;
            tb_Ikaitis.Text = paslaugaSelected.pasl_ikainis.ToString();
        }

        private void btn_isaugoti_Click(object sender, EventArgs e)
        {
            float parsedIkainis;
            if (float.TryParse(tb_Ikaitis.Text, out parsedIkainis))
            {
                paslaugaSelected.pasl_ikainis = parsedIkainis;
                paslaugaSelected.pasl_pavadinimas = tb_pavadinimas.Text;
                paslaugaSelected.pasl_matovienetas = tb_matoVienetas.Text;
                context.SaveChanges();
                lbl_klaida.Text = "Mokestis pakeistas.";
            }
            else
            {
                lbl_klaida.Text = "KLAIDA: ikainis turi būti nurodytas skaičiumi.";
            }
        }

        private void btn_atsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
