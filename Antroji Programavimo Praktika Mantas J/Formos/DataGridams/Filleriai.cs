using Antroji_Programavimo_Praktika_Mantas_J_.Aidles;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.Formos_Vadybininkams;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams
{
    public interface DatagridFillerGeneric
    {
        void fillDatagrid(MyDBContext context, DataGridView datagrid);
    }
    public interface DatagridFillerIDBased
    {
        void fillDatagrid(MyDBContext context, DataGridView datagrid, int? baseID);
    }
    public interface DatagridFillerVartotojams
    {
        void fillDatagrid(MyDBContext context, DataGridView datagrid, int? baseID, bool showPass);
    }
    public interface DatagridFillerVartotojamNID
    {
        void fillDatagrid(MyDBContext context, DataGridView datagrid, bool showPass);
    }

    //Privalomi ID

    public class DatagridFillerMokesciai : DatagridFillerIDBased
    {
        public void fillDatagrid(MyDBContext context, DataGridView datagrid, int? baseID)
        {
            if (baseID == null) return;
            List<Mokejimas> mokejimai = context.Mokejimai
            .Where(n => n.mok_vartotojoID == baseID)
            .ToList();
            datagrid.DataSource = mokejimai;
            datagrid.Columns["mok_vartotojoID"].Visible = false;
            datagrid.Columns["gyventojas"].Visible = false;
            datagrid.Columns["mok_ID"].HeaderText = "Mok. Numeris";
            datagrid.Columns["mok_ID"].DisplayIndex = 0;
            datagrid.Columns["mok_pavadinimas"].HeaderText = "Mok. Pavadinimas";
            datagrid.Columns["mok_matovienetas"].HeaderText = "Mato vienetas";
            datagrid.Columns["mok_ikainis"].HeaderText = "Vnt. Įkainis";
            datagrid.Columns["mok_kiekis"].HeaderText = "Vienetų Suvartota";
            datagrid.Columns["mok_pilnaKaina"].HeaderText = "Bendra Suma";
            datagrid.Columns["mok_likutis"].HeaderText = "Sumos Likutis";
            datagrid.Columns["mok_terminoPradzia"].HeaderText = "Termino Pradžia";
            datagrid.Columns["mok_terminoPabaiga"].HeaderText = "Termino Pabaiga";
        }
    }
    public class DatagridFillerPaslaugos : DatagridFillerIDBased
    {
        public void fillDatagrid(MyDBContext context, DataGridView datagrid, int? baseID)
        {
            if (baseID == null) return;
            List<Paslauga> paslaugos = context.Paslaugos
            .Where(n => n.pasl_vartGID == baseID)
            .ToList();
            datagrid.DataSource = paslaugos;

            datagrid.Columns["pasl_vartGID"].Visible = false;
            datagrid.Columns["VartotojuGrupe"].Visible = false;
            datagrid.Columns["pasl_pavadinimas"].HeaderText = "Paslaugos Pavadinimas";
            datagrid.Columns["pasl_matovienetas"].HeaderText = "Mato vienetai";
            datagrid.Columns["pasl_ikainis"].HeaderText = "Paslaugos ikainis (Eur.)";
            datagrid.Columns["pasl_ID"].HeaderText = "Paslaugos ID";
            datagrid.Columns["pasl_ID"].DisplayIndex = 0;
        }
    }

    //ID Neegzistuoja

    public class DatagridFillerVartGTest : DatagridFillerGeneric
    {
        public void fillDatagrid(MyDBContext context, DataGridView datagrid)
        {
            List<VartotojuGrupe> vartotojuGrupes = context.vartotojuGrupes
            .ToList();
            var rodymui = context.vartotojuGrupes
                .Select(n => new
                {
                    VartotojuGrupe = n,
                    n.VartG_ID,
                    n.VartG_adresas,
                    n.VartG_pavadinimas,
                    gyventojai = context.Naudotojai
                .OfType<Gyventojas>()
                .Count(m => m.gyv_vartGID == n.VartG_ID && m.naud_tipas == "Gyventojas")
                }
                )
                .ToList();

            datagrid.DataSource = rodymui;
            datagrid.Columns["VartotojuGrupe"].Visible = false;
            datagrid.Columns["VartG_adresas"].HeaderText = "Vartotjų Grupės Adresas";
            datagrid.Columns["VartG_pavadinimas"].HeaderText = "Vartotojų Grupės Pavadinimas";
            datagrid.Columns["gyventojai"].HeaderText = "Gyventojų Skaičius";
            datagrid.Columns["vartG_ID"].HeaderText = "Grupės ID";
            datagrid.Columns["vartG_ID"].DisplayIndex = 0;
        }
    }
    public class DatagridFillerVartG : DatagridFillerGeneric
    {
        public void fillDatagrid(MyDBContext context, DataGridView datagrid)
        {

            List<VartotojuGrupe> vartotojuGrupes = context.vartotojuGrupes.ToList();

            datagrid.DataSource = vartotojuGrupes;
            datagrid.Columns["VartG_adresas"].HeaderText = "Vartotjų Grupės Adresas";
            datagrid.Columns["VartG_pavadinimas"].HeaderText = "Vartotojų Grupės Pavadinimas";
            datagrid.Columns["vartG_ID"].HeaderText = "Grupės ID";
            datagrid.Columns["vartG_ID"].DisplayIndex = 0;
        }
    }
    //Vartotoju
    //ID Neegzistuoja

    public class DatagridFillerAdministratoriai : DatagridFillerVartotojamNID
    {
        public void fillDatagrid(MyDBContext context, DataGridView datagrid, bool showPass)
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
            datagrid.DataSource = rodymui;
            if (!showPass) datagrid.Columns["naud_slaptazodis"].Visible = false;
            else datagrid.Columns["naud_slaptazodis"].HeaderText = "Naudotojo Slaptažodis";

            datagrid.Columns["adm_vyriausiasis"].Visible = false;

            datagrid.Columns["adm_vyriausiasis"].Visible = false;
            datagrid.Columns["tekstu"].HeaderText = "Administratoriaus Tipas";


            datagrid.Columns["naud_ID"].HeaderText = "Naudotojo ID";
            datagrid.Columns["naud_ID"].DisplayIndex = 0;
            datagrid.Columns["naud_vardas"].HeaderText = "Vart. Vardas";
            datagrid.Columns["naud_pavarde"].HeaderText = "Vart. Pavardė";
            datagrid.Columns["naud_prisijungimoVardas"].HeaderText = "Paskyros Vardas";
            datagrid.Columns["naud_elPastas"].HeaderText = "El. Paštas";
            datagrid.Columns["naud_telNumeris"].HeaderText = "Telefono Numeris";
        }
    }
    //ID neprivalomas

    public class DatagridFillerGyventojai : DatagridFillerVartotojams
    {
        public void fillDatagrid(MyDBContext context, DataGridView datagrid, int? baseID, bool showPass)
        {
            List<Gyventojas> gyventojai;
            if (baseID == null)
            {
                gyventojai = context.Naudotojai
                .OfType<Gyventojas>()
                .Where(g => g.gyv_vartGID == null)
                .ToList();
            }
            else if (baseID <= 0)
            {
                gyventojai = context.Naudotojai
                .OfType<Gyventojas>()
                .ToList();
            }
            else
            {
                gyventojai = context.Naudotojai
                .OfType<Gyventojas>()
                .Where(g => g.gyv_vartGID == baseID)
                .ToList();
            }
            datagrid.DataSource = gyventojai;

            if (!showPass) datagrid.Columns["naud_slaptazodis"].Visible = false;
            else datagrid.Columns["naud_slaptazodis"].HeaderText = "Naudotojo Slaptažodis";

            datagrid.Columns["naud_tipas"].Visible = false;
            datagrid.Columns["VartotojuGrupe"].Visible = false;
            datagrid.Columns["gyv_vartGID"].Visible = false;
            datagrid.Columns["gyv_gyvenimojiVieta"].HeaderText = "Gyventojo adresas";
            datagrid.Columns["gyv_gimimoData"].HeaderText = "Gim. Data";
            datagrid.Columns["gyv_permoka"].HeaderText = "Sukaupta permoka (Eur.)";
            datagrid.Columns["naud_ID"].HeaderText = "Gyventojo ID";
            datagrid.Columns["naud_vardas"].HeaderText = "Gyv. Vardas";
            datagrid.Columns["naud_elPastas"].HeaderText = "El Paštas";
            datagrid.Columns["naud_telNumeris"].HeaderText = "Tel Numeris";
            datagrid.Columns["naud_pavarde"].HeaderText = "Gyv. Pavarde";
            datagrid.Columns["naud_prisijungimoVardas"].HeaderText = "Gyv. Paskyros Vardas";
        }
    }
    public class DatagridFillerVadybininkai : DatagridFillerVartotojams
    {
        public void fillDatagrid(MyDBContext context, DataGridView datagrid, int? baseID, bool showPass)
        {
            List<Vadybininkas> vadybininkai;
            if (baseID == null)
            {
                vadybininkai = context.Naudotojai
                .OfType<Vadybininkas>()
                .Where(g => g.vady_vartGID == null)
                .ToList();
            }
            else if (baseID <= 0)
            {
                vadybininkai = context.Naudotojai
                .OfType<Vadybininkas>()
                .ToList();
            }
            else
            {
                vadybininkai = context.Naudotojai
                .OfType<Vadybininkas>()
                .Where(g => g.vady_vartGID == baseID)
                .ToList();
            }
            datagrid.DataSource = vadybininkai;

            if (!showPass) datagrid.Columns["naud_slaptazodis"].Visible = false;
            else datagrid.Columns["naud_slaptazodis"].HeaderText = "Naudotojo Slaptažodis";

            datagrid.Columns["VartotojuGrupe"].Visible = false;
            datagrid.Columns["naud_tipas"].Visible = false;
            datagrid.Columns["naud_ID"].HeaderText = "Naudotojo ID";
            datagrid.Columns["naud_ID"].DisplayIndex = 0;
            datagrid.Columns["naud_vardas"].HeaderText = "Vart. Vardas";
            datagrid.Columns["naud_pavarde"].HeaderText = "Vart. Pavardė";
            datagrid.Columns["naud_prisijungimoVardas"].HeaderText = "Paskyros Vardas";
            datagrid.Columns["naud_elPastas"].HeaderText = "El. Paštas";
            datagrid.Columns["naud_telNumeris"].HeaderText = "Telefono Numeris";
            datagrid.Columns["vady_vartGID"].HeaderText = "Grupės ID";
        }
    }
}
