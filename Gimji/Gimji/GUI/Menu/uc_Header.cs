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
    public partial class uc_Header : UserControl
    {
        public uc_Header()
        {
            InitializeComponent();
        }
        private static uc_Header _instance;
        public static uc_Header  Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uc_Header();
                return _instance;
            }
        }
    }
}
