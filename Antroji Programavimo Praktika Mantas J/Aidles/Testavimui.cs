using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Aidles
{
    internal class Testavimui
    {
        public static void sukurtiTestavimui(MyDBContext context)
        {
            VartotojuGrupe testGrupe = new VartotojuGrupe
            {
                VartG_adresas = "Smaragdu miestas 7",
                VartG_pavadinimas = "Smaragdu miesto bendrija"
            };

            VartotojuGrupe testGrupe2 = new VartotojuGrupe
            {
                VartG_adresas = "Manto kambarys",
                VartG_pavadinimas = "Manto bendrija"
            };

            context.vartotojuGrupes.Add(testGrupe);
            context.vartotojuGrupes.Add(testGrupe2);
            context.SaveChanges();

            Gyventojas testGyventojas = new Gyventojas
            {
                naud_tipas = "Gyventojas",
                naud_vardas = "Vardenis",
                naud_pavarde = "Pavardenis",
                naud_slaptazodis = "1234",
                naud_prisijungimoVardas = "testvart1",
                naud_elPastas = "VardenisPavardenis@gmail.com",
                naud_telNumeris = "1234567890",
                gyv_gyvenimojiVieta = "Vilnius fabijoniskes zadeikos 11 64",
                gyv_gimimoData = "1999-09-09",
                gyv_permoka = 0,
                gyv_vartGID = testGrupe.VartG_ID
            };

            Gyventojas testGyventojas2 = new Gyventojas
            {
                naud_tipas = "Gyventojas",
                naud_vardas = "Jonas",
                naud_pavarde = "Jonaitis",
                naud_slaptazodis = "4321",
                naud_prisijungimoVardas = "testvart2",
                naud_elPastas = "JonasJonaitis@gmail.com",
                naud_telNumeris = "09987654321",
                gyv_gyvenimojiVieta = "Vilnius antakalnio g. 4 12",
                gyv_gimimoData = "1991-11-11",
                gyv_permoka = 0,
                gyv_vartGID = testGrupe.VartG_ID
            };

            Gyventojas testGyventojas3 = new Gyventojas
            {
                naud_tipas = "Gyventojas",
                naud_vardas = "Kazys",
                naud_pavarde = "Urbonas",
                naud_slaptazodis = "3333",
                naud_prisijungimoVardas = "testvart3",
                naud_elPastas = "KazysUrbonas@hotmail.com",
                naud_telNumeris = "09987654321",
                gyv_gyvenimojiVieta = "Vilnius Fabijoniskes kazkur 13 36",
                gyv_gimimoData = "1992-03-12",
                gyv_permoka = 0,
                gyv_vartGID = testGrupe2.VartG_ID
            };

            Gyventojas testGyventojas4 = new Gyventojas
            {
                naud_tipas = "Gyventojas",
                naud_vardas = "Linas",
                naud_pavarde = "Jurevicius",
                naud_slaptazodis = "4444",
                naud_prisijungimoVardas = "testvart4",
                naud_elPastas = "Nesakysiu@hotmail.com",
                naud_telNumeris = "646464646464",
                gyv_gyvenimojiVieta = "Lino kambarys",
                gyv_gimimoData = "2023-10-22",
                gyv_permoka = 0,
                gyv_vartGID = null
            };

            Administratorius testAdministratorius = new Administratorius
            {
                naud_tipas = "Administratorius",
                naud_vardas = "Bulve",
                naud_pavarde = "Katinauskas",
                naud_slaptazodis = "admin",
                naud_prisijungimoVardas = "admin",
                naud_elPastas = "PotatCat@gmail.com",
                naud_telNumeris = "170097000874",
                adm_vyriausiasis = true
            };
            Vadybininkas testVadybininkas = new Vadybininkas
            {
                naud_tipas = "Vadybininkas",
                naud_vardas = "Arbuzas",
                naud_pavarde = "Chamelionas",
                naud_prisijungimoVardas = "manager",
                naud_slaptazodis = "1111",
                naud_elPastas = "ChameleonAI@gmail.com",
                naud_telNumeris = "133300000",
                vady_vartGID = testGrupe.VartG_ID
            };
            Vadybininkas testVadybininkas2 = new Vadybininkas
            {
                naud_tipas = "Vadybininkas",
                naud_vardas = "Krituolis",
                naud_pavarde = "Puolėjas",
                naud_prisijungimoVardas = "manager2",
                naud_slaptazodis = "2222",
                naud_elPastas = "FallenIncursio@gmail.com",
                naud_telNumeris = "133300000",
                vady_vartGID = null
            };
            context.Naudotojai.Add(testGyventojas);
            context.Naudotojai.Add(testGyventojas2);
            context.Naudotojai.Add(testGyventojas3);
            context.Naudotojai.Add(testGyventojas4);
            context.Naudotojai.Add(testAdministratorius);
            context.Naudotojai.Add(testVadybininkas);
            context.Naudotojai.Add(testVadybininkas2);
            context.SaveChanges();
            List<Mokejimas> mokejimai = new List<Mokejimas>
    {
        new Mokejimas
        {
            mok_vartotojoID = testGyventojas.naud_ID,
            mok_pavadinimas = "Paslauga 1",
            mok_matovienetas = "Vnt",
            mok_ikainis = 10.00F,
            mok_kiekis = 2,
            mok_pilnaKaina = 20.00m,
            mok_likutis = 20.00m,
            mok_terminoPradzia = DateTime.Now,
            mok_terminoPabaiga = DateTime.Now.AddMonths(1)
        },
        new Mokejimas
        {
            mok_vartotojoID = testGyventojas.naud_ID,
            mok_pavadinimas = "Paslauga 2",
            mok_matovienetas = "Vnt",
            mok_ikainis = 15.50F,
            mok_kiekis = 1,
            mok_pilnaKaina = 15.50m,
            mok_likutis = 15.50m,
            mok_terminoPradzia = DateTime.Now,
            mok_terminoPabaiga = DateTime.Now.AddMonths(2)
        },
        new Mokejimas
        {
            mok_vartotojoID = testGyventojas.naud_ID,
            mok_pavadinimas = "Paslauga 3",
            mok_matovienetas = "Vnt",
            mok_ikainis = 5.25F,
            mok_kiekis = 3,
            mok_pilnaKaina = 15.75m,
            mok_likutis = 15.75m,
            mok_terminoPradzia = DateTime.Now,
            mok_terminoPabaiga = DateTime.Now.AddMonths(3)
        }
    };

            context.Mokejimai.AddRange(mokejimai);
            context.SaveChanges();
        }
    }
}
