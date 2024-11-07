using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams.Adminai
{
    public partial class Admin_Administratoriai : Form
    {
        public MyDBContext context {  get; set; }
        public Administratorius administratoriusSelected { get; set; }
        private List<Administratorius> administratoriai;
        public Admin_Administratoriai()
        {
            InitializeComponent();
        }

        private void Admin_Administratoriai_Load(object sender, EventArgs e)
        {
            rodytiKaReikia();
        }
        public void rodytiKaReikia()
        {
            var rodymui = context.Naudotojai
                .OfType<Administratorius>()
                .Select(n => new
                {
                    administratoriai = n,
                    n.naud_ID,
                    n.naud_vardas,
                    n.naud_pavarde,
                    n.naud_elPastas,
                    n.naud_telNumeris,
                    n.naud_slaptazodis,
                    n.naud_prisijungimoVardas,
                    n.adm_vyriausiasis,
                    tekstu = n.adm_vyriausiasis ? "Vyriausiasis" : "Paprastas"
                }
                )
                .ToList();

            dtgrd_administratoriai.DataSource = rodymui;
            if (!administratoriusSelected.adm_vyriausiasis)
            {
                dtgrd_administratoriai.Columns["naud_slaptazodis"].Visible = false;
            }
            else
            {
                dtgrd_administratoriai.Columns["naud_slaptazodis"].HeaderText = "Naudotojo Slaptazodis";
            }
            dtgrd_administratoriai.Columns["adm_vyriausiasis"].Visible = false;

            dtgrd_administratoriai.Columns["adm_vyriausiasis"].Visible = false;
            dtgrd_administratoriai.Columns["tekstu"].HeaderText = "Administratoriaus Tipas";


            dtgrd_administratoriai.Columns["naud_ID"].HeaderText = "Naudotojo ID";
            dtgrd_administratoriai.Columns["naud_ID"].DisplayIndex = 0;
            dtgrd_administratoriai.Columns["naud_vardas"].HeaderText = "Vart. Vardas";
            dtgrd_administratoriai.Columns["naud_pavarde"].HeaderText = "Vart. Pavardė";
            dtgrd_administratoriai.Columns["naud_prisijungimoVardas"].HeaderText = "Paskyros Vardas";
            dtgrd_administratoriai.Columns["naud_elPastas"].HeaderText = "El. Paštas";
            dtgrd_administratoriai.Columns["naud_telNumeris"].HeaderText = "Telefono Numeris";
        }
    }
}
