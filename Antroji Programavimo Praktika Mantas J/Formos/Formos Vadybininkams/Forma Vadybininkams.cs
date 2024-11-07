    using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
    using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams;
    using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
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

    namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos
    {
    public partial class Forma_Vadybininkams : Form
    {
        public Vadybininkas vadybininkasSelected { get; set; }
        public VartotojuGrupe vartojuGrupeSelected { get; set; }
        private List<Paslauga> paslaugos;
        private List<Gyventojas> gyventojai;
        public MyDBContext context { get; set; }
        public Gyventojas gyventojasSelected { get; set; }
        public Paslauga paslaugaSelected { get; set; }

        public Forma_Vadybininkams()
        {
            InitializeComponent();
        }

        private void Forma_Vadybininkams_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = "ID: " + vadybininkasSelected.naud_ID;
            lbl_vartVardas.Text = vadybininkasSelected.naud_vardas + " " + vadybininkasSelected.naud_pavarde;
            int? vartGrupesID = vadybininkasSelected.vady_vartGID;
            if (vartGrupesID != null)
            {
                vartojuGrupeSelected = context.vartotojuGrupes.FirstOrDefault(n => n.VartG_ID == vartGrupesID);
            }

            if (vartojuGrupeSelected != null)
            {
                lbl_priskirtas.Text = "Jums priskirta: " + vartojuGrupeSelected.VartG_pavadinimas;
                lbl_grupesAdresas.Text = "Adresu: " + vartojuGrupeSelected.VartG_adresas;
            }
            else
            {
                lbl_priskirtas.Text = "Šiuo metu jums nėra priskirta jokia vartotojų grupė.";
                lbl_grupesAdresas.Text = "Prašome susisiekti su savo vadovaujančiu asmeniu dėl priskyrimo.";

            }
            atnaujintiPaslaugas();
            atnaujintiVartotojus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = dataGridView1.Rows[e.RowIndex];
                paslaugaSelected = (Paslauga)pasirinktaEilute.DataBoundItem;
                lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: " + paslaugaSelected.pasl_pavadinimas;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pasirinktaEilute = dataGridView2.Rows[e.RowIndex];
                gyventojasSelected = (Gyventojas)pasirinktaEilute.DataBoundItem;
                lbl_pasirinktasGyventojas.Text = "Pasirinktas Gyventojas: " + gyventojasSelected.naud_vardas + " " + gyventojasSelected.naud_pavarde;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_keistiMokesti_Click(object sender, EventArgs e)
        {
            if (paslaugaSelected != null)
            {
                Paslaugos_Keitimas paslaugos_Keitimas = new Paslaugos_Keitimas();
                paslaugos_Keitimas.context = context;
                paslaugos_Keitimas.paslaugaSelected = paslaugaSelected;
                paslaugos_Keitimas.ShowDialog();
            }
        }

        private void btb_istrintiMokesti_Click(object sender, EventArgs e)
        {
            if (paslaugaSelected != null)
            {
                context.Paslaugos.Remove(paslaugaSelected);
                context.SaveChanges();
                atnaujintiPaslaugas();
                paslaugaSelected = null;
                lbl_pasirinktasMokestis.Text = "Pasirinktas Mokestis: ";
            }
        }

        private void atnaujintiPaslaugas()
        {
            if (vadybininkasSelected.vady_vartGID != null)
            {
                paslaugos = context.Paslaugos
                .Where(n => n.pasl_vartGID == vadybininkasSelected.vady_vartGID)
                .ToList();
                dataGridView1.DataSource = paslaugos;

                dataGridView1.Columns["pasl_vartGID"].Visible = false;
                dataGridView1.Columns["VartotojuGrupe"].Visible = false;
                dataGridView1.Columns["pasl_pavadinimas"].HeaderText = "Paslaugos Pavadinimas";
                dataGridView1.Columns["pasl_matovienetas"].HeaderText = "Mato vienetai";
                dataGridView1.Columns["pasl_ikainis"].HeaderText = "Paslaugos ikainis (Eur.)";
                dataGridView1.Columns["pasl_ID"].HeaderText = "Paslaugos ID";
                dataGridView1.Columns["pasl_ID"].DisplayIndex = 0;
            }
        }
        private void atnaujintiVartotojus()
        {
            if (vadybininkasSelected.vady_vartGID!= null)
            {
                gyventojai = context.Naudotojai
                .OfType<Gyventojas>()
                .Where(n => n.gyv_vartGID == vadybininkasSelected.vady_vartGID)
                .ToList();
                dataGridView2.DataSource = gyventojai;

                dataGridView2.Columns["naud_tipas"].Visible = false;
                dataGridView2.Columns["VartotojuGrupe"].Visible = false;
                dataGridView2.Columns["naud_slaptazodis"].Visible = false;
                dataGridView2.Columns["gyv_vartGID"].Visible = false;
                dataGridView2.Columns["gyv_gyvenimojiVieta"].HeaderText = "Gyventojo adresas";
                dataGridView2.Columns["gyv_gimimoData"].HeaderText = "Gim. Data";
                dataGridView2.Columns["gyv_permoka"].HeaderText = "Sukaupta permoka (Eur.)";
                dataGridView2.Columns["naud_ID"].HeaderText = "Gyventojo ID";
                dataGridView2.Columns["naud_vardas"].HeaderText = "Gyv. Vardas";
                dataGridView2.Columns["naud_pavarde"].HeaderText = "Gyv. Pavarde";
                dataGridView2.Columns["naud_prisijungimoVardas"].HeaderText = "Gyv. Paskyros Vardas";
            }
        }

        private void btn_atnaujinti_Click(object sender, EventArgs e)
        {
            atnaujintiPaslaugas();
            atnaujintiVartotojus();
        }

        private void btn_sukurtiNauja_Click(object sender, EventArgs e)
        {
            if (vadybininkasSelected.vady_vartGID != null)
            {
                Paslaugos_Sukurimas paslaugos_Sukurimas = new Paslaugos_Sukurimas();
                paslaugos_Sukurimas.naujas_vartGID = vadybininkasSelected.vady_vartGID ?? 0;
                paslaugos_Sukurimas.context = context;
                paslaugos_Sukurimas.ShowDialog();
            }
        }

        private void btn_apieVartotoja_Click(object sender, EventArgs e)
        {
            Forma_Vadybininkams_2 forma_Vadybininkams_2 = new Forma_Vadybininkams_2();
            forma_Vadybininkams_2.vadybininkasSelected = vadybininkasSelected;
            forma_Vadybininkams_2.vartojuGrupeSelected = vartojuGrupeSelected;
            forma_Vadybininkams_2.context = context;
            forma_Vadybininkams_2.ShowDialog();
        }

        private void btn_priskirtiVienam_Click(object sender, EventArgs e)
        {
            if (gyventojasSelected != null && paslaugaSelected != null)
            {
                DateTime now = DateTime.Now;
                DateTime terminoPradzia = new DateTime(now.Year, now.Month, 1).AddMonths(1);
                DateTime terminoPabaiga = terminoPradzia.AddMonths(1).AddDays(-1);
                Mokejimas naujas = new Mokejimas
                {
                    mok_ikainis = paslaugaSelected.pasl_ikainis,
                    mok_matovienetas = paslaugaSelected.pasl_matovienetas,
                    mok_pavadinimas = paslaugaSelected.pasl_pavadinimas,
                    mok_terminoPradzia = terminoPradzia,
                    mok_terminoPabaiga = terminoPabaiga,
                    mok_vartotojoID = gyventojasSelected.naud_ID,
                    mok_kiekis = 0,
                    mok_pilnaKaina = 0,
                    mok_likutis = 0,
                };
                context.Mokejimai.Add(naujas);
                context.SaveChanges();
            }
        }

        private void btb_priskirtiVisiems_Click(object sender, EventArgs e)
        {
            if (paslaugaSelected != null && vartojuGrupeSelected != null)
            {
                DateTime now = DateTime.Now;
                DateTime terminoPradzia = new DateTime(now.Year, now.Month, 1).AddMonths(1);
                DateTime terminoPabaiga = terminoPradzia.AddMonths(1).AddDays(-1);
                foreach (Gyventojas gyventojas in gyventojai)
                {
                    Mokejimas naujas = new Mokejimas
                    {
                        mok_ikainis = paslaugaSelected.pasl_ikainis,
                        mok_matovienetas = paslaugaSelected.pasl_matovienetas,
                        mok_pavadinimas = paslaugaSelected.pasl_pavadinimas,
                        mok_terminoPradzia = terminoPradzia,
                        mok_terminoPabaiga = terminoPabaiga,
                        mok_vartotojoID = gyventojas.naud_ID,
                        mok_kiekis = 0,
                        mok_pilnaKaina = 0,
                        mok_likutis = 0,
                    };
                    context.Mokejimai.Add(naujas);
                }
                context.SaveChanges();
            }
        }

        private void btb_perziuretiVartotoja_Click(object sender, EventArgs e)
        {
            if (gyventojasSelected != null)
            {
                Gyventojo_Perziura gyventojo_Perziura = new Gyventojo_Perziura();
                gyventojo_Perziura.context = context;
                gyventojo_Perziura.gyventojasSelected = gyventojasSelected;
                gyventojo_Perziura.ShowDialog();
            }
        }
    }
}
