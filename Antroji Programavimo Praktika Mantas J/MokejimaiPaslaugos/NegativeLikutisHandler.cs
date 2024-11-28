using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos
{
    internal class NegativeLikutisHandler
    {
        public void pasl_handleNegativeLikutis(decimal mok_Likutis, decimal mokamaSuma, decimal permoka)
        {
            decimal currentpermoka;
            if (mok_Likutis < mokamaSuma)
            {
                currentpermoka = mokamaSuma - mok_Likutis;
                permoka += currentpermoka;
                mok_Likutis = 0;

            }
            else
            {
                mok_Likutis -= mokamaSuma;
            }
        }
    }
}
