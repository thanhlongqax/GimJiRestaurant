using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Management.CustomerManagement
{
    public partial class uc_customer : UserControl
    {
        public uc_customer()
        {
            InitializeComponent();
        }

        #region Properties

        public Label Title
        {
            get { return lb_name; }
            set { lb_name = value; }
        }
        public Label ID
        {
            get { return lb_id; }
            set { lb_id = value; }
        }
        public Label Stt
        {
            get { return lb_stt; }
            set { lb_stt = value; }
        }
        public Label Point
        {
            get { return lb_point; }
            set { lb_point = value; }
        }

        #endregion
    }
}
