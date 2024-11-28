using Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic;
using Antroji_Programavimo_Praktika_Mantas_J_.Formos.DataGridams;
using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Aidles
{
    public interface deleterGeneric<T>
    {
        void deleteMe(MyDBContext context, T selectedItem);
    }
    public class deleterPaslauga : deleterGeneric<Paslauga>
    {
        public void deleteMe(MyDBContext context, Paslauga selectedItem)
        {
            context.Paslaugos.Remove(selectedItem);
            context.SaveChanges();
        }
    }

    public class deleterMokestis : deleterGeneric<Mokejimas>
    {
        public void deleteMe(MyDBContext context, Mokejimas selectedItem)
        {
            context.Mokejimai.Remove(selectedItem);
            context.SaveChanges();
        }
    }

    public class deleterVartGrupe : deleterGeneric<VartotojuGrupe>
    {
        public void deleteMe(MyDBContext context, VartotojuGrupe selectedItem)
        {
            context.vartotojuGrupes.Remove(selectedItem);
            context.SaveChanges();
        }
    }

    public class deleterNaudotojas : deleterGeneric<Naudotojas>
    {
        public void deleteMe(MyDBContext context, Naudotojas selectedItem)
        {
            context.Naudotojai.Remove(selectedItem);
            context.SaveChanges();
        }
    }

    public class deleterFull
    {
        private Dictionary<Type, object> deleterList; 
        private MyDBContext context;
        public deleterFull(MyDBContext context)
        {
            this.context = context;
            deleterList = new Dictionary<Type, object>
            {
                {typeof(Naudotojas), new deleterNaudotojas() },
                {typeof(VartotojuGrupe), new deleterVartGrupe() },
                {typeof(Paslauga), new deleterPaslauga() },
                {typeof(Mokejimas), new deleterMokestis() }
            };
        }
        public void deleteAll<T>(T selectedItem)
        {
            if (selectedItem == null) return;

            Type selectedItemType = typeof(T);
            if (deleterList.ContainsKey(selectedItemType))
            {
                var deleter = deleterList[selectedItemType] as deleterGeneric<T>;
                deleter.deleteMe(context, selectedItem);
            }

            selectedItem = default;
        }
    }
}
