using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim_sinama_proje
{
    class Node
    {
        public int id;
        public string name;

        public override string ToString()
        {
            return this.name;
        }
        public static void AddItemToCombo(ComboBox target_combo, int p_id, string p_name)
        {
            Node n = new Node()
            {
                id = p_id,
                name = p_name
            };
            target_combo.Items.Add(n);
        }
    }
}
