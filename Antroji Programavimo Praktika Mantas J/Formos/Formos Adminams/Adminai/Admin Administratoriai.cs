using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
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
            DatagridFillerAdministratoriai datagridFillerAdministratoriai = new DatagridFillerAdministratoriai();
            datagridFillerAdministratoriai.fillDatagrid(context, dtgrd_administratoriai, administratoriusSelected.adm_vyriausiasis);
        }
    }
}
