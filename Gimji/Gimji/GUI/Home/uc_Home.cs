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
            uc_listTable listTable = new uc_listTable();
            uc_status status = new uc_status();
            uc_table table = new uc_table();
            populateTable();
            //panel4.Controls.Add(table);
            //panel5.Controls.Add(inforTable);
            panel6.Controls.Add(status);


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

    }
}
