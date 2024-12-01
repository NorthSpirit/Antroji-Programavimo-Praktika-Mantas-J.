﻿using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
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
        private string tempPavadinimas;
        private string tempMatoVienetas;
        private string tempIkainis;
        public Paslaugos_Keitimas()
        {
            InitializeComponent();
        }

        private void Paslaugos_Keitimas_Load(object sender, EventArgs e)
        {
            sustatytiTemp();
            sustatytiTexta();
        }

        private void btn_atstatyti_Click(object sender, EventArgs e)
        {
            lbl_error.Text = PaslaugaUpdateService.UpdatePaslauga(context, tempPavadinimas, tempMatoVienetas, tempIkainis, paslaugaSelected);
            sustatytiTexta();
        }

        private void btn_isaugoti_Click(object sender, EventArgs e)
        {
            lbl_error.Text = PaslaugaUpdateService.UpdatePaslauga(context, tb_pavadinimas.Text, tb_matoVienetas.Text, tb_Ikaitis.Text, paslaugaSelected);
        }

        private void btn_atsaukti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sustatytiTexta()
        {
            lbl_error.Text = "";
            tb_pavadinimas.Text = paslaugaSelected.pasl_pavadinimas;
            tb_matoVienetas.Text = paslaugaSelected.pasl_matovienetas;
            tb_Ikaitis.Text = paslaugaSelected.pasl_ikainis.ToString();
        }
        private void sustatytiTemp()
        {
            tempPavadinimas = paslaugaSelected.pasl_pavadinimas;
            tempMatoVienetas = paslaugaSelected.pasl_matovienetas;
            tempIkainis = paslaugaSelected.pasl_ikainis.ToString();
        }
    }
}
