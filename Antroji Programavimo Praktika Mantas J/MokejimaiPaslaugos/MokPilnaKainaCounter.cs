using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos
{
    internal class MokPilnaKainaCounter
    {
        private decimal pasl_countPilnaKaina(float kiekis, float kaina)
        {
            decimal apvalinta = (decimal)(kiekis * kaina);
            if (apvalinta < 0) apvalinta = 0;
            return apvalinta;
        }
    }
}
