﻿using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Aidles.VartLogic
{
    
    public class selectorForAll
    {
        public static T selectItem<T>(DataGridView dataGrid, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var eiluteSelect = dataGrid.Rows[e.RowIndex];
                var selectedItem = eiluteSelect.DataBoundItem;
                if (selectedItem is T t)
                {
                    return t;
                }
                return default;
            }
            return default;
        }
    }
}