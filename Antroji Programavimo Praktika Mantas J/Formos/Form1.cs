using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using Microsoft.EntityFrameworkCore;

namespace Antroji_Programavimo_Praktika_Mantas_J_
{
    public partial class Form1 : Form
    {
        public MyDBContext context {  get; set; }
        public Form1()
        {
            InitializeComponent();
            context = new MyDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_extra.Text = "";
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            string userNameToCheck = tb_userName.Text;
            string userPassworkToCheck = tb_password.Text;
            naudotojasLoginHandlerFull loginHandler = new naudotojasLoginHandlerFull();
            loginHandler.VartotojoLoginFull(context, lbl_extra, userNameToCheck, userPassworkToCheck);
        }

        private void lbl_extra_Click(object sender, EventArgs e)
        {
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Testavimui.sukurtiTestavimui(context);
        }
    }
}
