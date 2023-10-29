using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimji.GUI.Menu
{
    public partial class uc_MonAn  : UserControl
    {
        private static uc_MonAn _instance;
        public static uc_MonAn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_MonAn();
                return _instance;
            }
        }
        public uc_MonAn()
        {
            InitializeComponent();
        }
    }
}
