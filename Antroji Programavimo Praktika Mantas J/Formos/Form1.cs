using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
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
        public Gyventojas gyventojasSelected { get; set; }
        public Vadybininkas vadybininkasSelected { get; set; }
        public Administratorius administratoriusSelected { get; set; }
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
            Naudotojas prisNaudotojas = context.Naudotojai.FirstOrDefault(n => n.naud_prisijungimoVardas == userNameToCheck);
            //Vartotojas egzistuoja
            if (prisNaudotojas != null && prisNaudotojas.naud_prisijungimoVardas == userNameToCheck)
            {
                //Passwordas sutampa
                if (prisNaudotojas.naud_slaptazodis == userPassworkToCheck)
                {
                    switch (prisNaudotojas.naud_tipas)
                    {
                        case "Gyventojas":
                            lbl_extra.Text = "Gyventojas";
                            gyventojasSelected = prisNaudotojas as Gyventojas;
                            if (gyventojasSelected != null)
                            {
                                
                                Forma_Gyventojams forma_Gyventojams = new Forma_Gyventojams();
                                forma_Gyventojams.gyventojasSelected = gyventojasSelected;
                                forma_Gyventojams.context = context;
                                forma_Gyventojams.ShowDialog();
                            }
                            break;
                        case "Vadybininkas":
                            lbl_extra.Text = "Vadybininkas";
                            vadybininkasSelected = prisNaudotojas as Vadybininkas;
                            if (vadybininkasSelected != null)
                            {
                                Forma_Vadybininkams forma_Vadybininkams = new Forma_Vadybininkams();
                                forma_Vadybininkams.vadybininkasSelected = vadybininkasSelected;
                                forma_Vadybininkams.context = context;
                                forma_Vadybininkams.ShowDialog();
                            }
                            break;
                        case "Administratorius":
                            lbl_extra.Text = "Administratorius";
                            administratoriusSelected = prisNaudotojas as Administratorius;
                            if (administratoriusSelected != null)
                            {
                                Forma_Adminams forma_Adminams = new Forma_Adminams();
                                forma_Adminams.administratoriusSelected = administratoriusSelected;
                                forma_Adminams.context = context;
                                forma_Adminams.ShowDialog();
                            }
                            break;
                        default:
                            lbl_extra.Text = "ERROR! unknown type";
                            break;
                    }
                }
                //Passwordas nesutampa
                else
                {
                    lbl_extra.Text = "The Password is incorrect. Please try again.";
                }
            }
            //Vartotojas neegzistuoja
            else
            {
                lbl_extra.Text = "The account does not exist. Please enter a different account name or get a new one.";
            }
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
