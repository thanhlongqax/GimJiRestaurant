using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Home
{
    public partial class uc_Home : UserControl
    {
        public uc_Home()
        {
            InitializeComponent();
            uc_inforTable inforTable = new uc_inforTable();
            uc_status status = new uc_status();
            populateStatusTable();
            pal_status.Controls.Add(status);
            pal_inforTable.Controls.Add(inforTable);
            pal_status.Controls.Add(status);
            populateTable();



        }
        public void populateTable()
        {
            uc_listTable[] listTables = new uc_listTable[10];
            for (int i = 0; i < listTables.Length; i++)
            {
                listTables[i] = new uc_listTable();
                listTables[i].Name = "Lucas";
                listTables[i].Guest = "5";

                if (flow_pal_listtable.Controls.Count < 0)
                {
                    flow_pal_listtable.Controls.Clear();
                }
                else
                    flow_pal_listtable.Controls.Add(listTables[i]);
            }
        }
        public void populateStatusTable()
        {
            uc_table[] Table = new uc_table[10];
            for (int i = 0; i < Table.Length; i++)
            {
                Table[i] = new uc_table();


                if (flow_pal_table.Controls.Count < 0)
                {
                    flow_pal_table.Controls.Clear();
                }
                else
                    flow_pal_table.Controls.Add(Table[i]);
            }
        }

    }
}
