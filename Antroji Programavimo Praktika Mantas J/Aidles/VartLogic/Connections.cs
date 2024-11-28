using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Adminams;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Antroji_Programavimo_Praktika_Mantas_J_.Formos.GyventojoFormos;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic
{
    public interface UserLoginerGeneric
    {
        void VartotojoLogin(Naudotojas naudotojasSelected, MyDBContext context, Label errorLabel);
    }
    /*
    public interface UserLegitimacyCheck
    {
        bool validLogin(Naudotojas naudotojasSelected);
        string errorLabelString();
    }
    public class GyventojasLegitimacyCheck : UserLegitimacyCheck
    {
        private string errorLabel;
        public bool validLogin(Naudotojas naudotojasSelected)
        {
            if (naudotojasSelected is Gyventojas gyventojasSelected)
            {
                //Tikrinimas senai sistemai
                if (gyventojasSelected.naud_tipas == "Gyventojas")
                {
                    errorLabel = "Gyventojas prisijungė";
                    return true;
                }
                else
                {
                    errorLabel = "ERROR: Gyventojas doesn't have Gyventojas tag.";
                    return false;
                }
            }
            else
            {
                errorLabel = "ERROR: Corrupt Data.";
                return false;
            }
        }
        public string errorLabelString()
        {
            return errorLabel;
        }
    }
    public class VadybininkasLegitimacyCheck : UserLegitimacyCheck
    {
        private string errorLabel;
        public bool validLogin(Naudotojas naudotojasSelected)
        {
            if (naudotojasSelected is Vadybininkas vadybininkasSelected)
            {
                //Tikrinimas senai sistemai
                if (vadybininkasSelected.naud_tipas == "Vadybininkas")
                {
                    errorLabel = "Vadybininkas prisijungė";
                    return true;
                }
                else
                {
                    errorLabel = "ERROR: Vadybininkas doesn't have Vadybininkas tag.";
                    return false;
                }
            }
            else
            {
                errorLabel = "ERROR: Corrupt Data.";
                return false;
            }
        }
        public string errorLabelString()
        {
            return errorLabel;
        }
    }
    public class AdministratoriusLegitimacyCheck : UserLegitimacyCheck
    {
        private string errorLabel;
        public bool validLogin(Naudotojas naudotojasSelected)
        {
            if (naudotojasSelected is Administratorius administratoriusSelected)
            {
                //Tikrinimas senai sistemai
                if (administratoriusSelected.naud_tipas == "Administratorius")
                {
                    errorLabel = "Administratorius prisijungė";
                    return true;
                }
                else
                {
                    errorLabel = "ERROR: Administratorius doesn't have Administratorius tag.";
                    return false;
                }
            }
            else
            {
                errorLabel = "ERROR: Corrupt Data.";
                return false;
            }
        }
        public string errorLabelString()
        {
            return errorLabel;
        }
    }
    */
    //Gyventojui
    public class GyventojasLoginer : UserLoginerGeneric
    {
        public void VartotojoLogin(Naudotojas naudotojasSelected, MyDBContext context, Label errorLabel)
        {
            Gyventojas gyventojasSelected = naudotojasSelected as Gyventojas;
            if (gyventojasSelected != null)
            {
                atidaryti1(context, gyventojasSelected);
                errorLabel.Text = "Vartotojas prisijungė";
            }
            else
            {
                errorLabel.Text = "Error, Corrupt Vartotojas.";
            }
        }
    }
    //Vadybininkui
    public class VadybininkasLoginer : UserLoginerGeneric
    {
        public void VartotojoLogin(Naudotojas naudotojasSelected, MyDBContext context, Label errorLabel)
        {
            Vadybininkas vadybininkasSelected = naudotojasSelected as Vadybininkas;
            if (vadybininkasSelected != null)
            {
                VadybininkoFormos.atidaryti1(context, vadybininkasSelected);
                errorLabel.Text = "Vadybininkas prisijungė";
            }
            else
            {
                errorLabel.Text = "Error, Corrupt Vartotojas.";
            }
        }
    }
    //Administratoriui
    public class AdminasLogister : UserLoginerGeneric
    {
        public void VartotojoLogin(Naudotojas naudotojasSelected, MyDBContext context, Label errorLabel)
        {
            Administratorius administratoriusSelected = naudotojasSelected as Administratorius;
            if (administratoriusSelected != null)
            {
                AdminuFormos.atidaryti1(context, administratoriusSelected);
                errorLabel.Text = "Vadybininkas prisijungė";
            }
            else
            {
                errorLabel.Text = "Error, Corrupt Vartotojas.";
            }
        }
    }
    /*
    public class UserExistanceChecker
    {
        public (Naudotojas naudotojasSelected, bool validNaudotojas) VartotojasChecker(MyDBContext context, string nameToCheck)
        {
            Naudotojas naudotojasTikrinimui = context.Naudotojai.FirstOrDefault(n => n.naud_prisijungimoVardas == nameToCheck);
            if (naudotojasTikrinimui != null)
            {
                return (naudotojasTikrinimui, true);
            }
            else
            {
                return (null, false);
            }
        }
    }
    */
    /*
    public class UserPassChecker
    {
        public bool validPassword(Naudotojas naudotojasToCheck, string passToCheck)
        {
            return naudotojasToCheck.naud_slaptazodis == passToCheck;
        }
    }
    */
    public class naudotojasLoginHandlerFull
    {
        private Dictionary<string, UserLoginerGeneric> loginerList;
        public naudotojasLoginHandlerFull()
        {
            loginerList = new Dictionary<string, UserLoginerGeneric>
            {
                { "Gyventojas", new GyventojasLoginer() },
                { "Vadybininkas", new VadybininkasLoginer() },
                { "Administratorius", new AdminasLogister() }
            };
        }
        public void VartotojoLoginFull(MyDBContext context, Label errorLabel, string userNameInput, string userPassInput)
        {
            Naudotojas naudotojasSelected = context.Naudotojai.FirstOrDefault(n => n.naud_prisijungimoVardas == userNameInput);


            if (naudotojasSelected != null)
            {
                if (naudotojasSelected.naud_slaptazodis == userPassInput)
                {
                    if (loginerList.ContainsKey(naudotojasSelected.naud_tipas))
                    {
                        var loginer = loginerList[naudotojasSelected.naud_tipas];
                        loginer.VartotojoLogin(naudotojasSelected, context, errorLabel);
                    }
                    else
                    {
                        errorLabel.Text = "ERROR! unknown type";
                    }
                }
                else
                {
                    errorLabel.Text = "Netinkamas slaptažodis";
                }
            }
            else
            {
                errorLabel.Text = "Vartotojas nerastas";
            }
        }
    }
}
