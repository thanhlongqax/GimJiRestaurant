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
    public partial class uc_listTable : UserControl
    {
        public uc_listTable()
        {
            InitializeComponent();
        }

        private String name;
        private String time;
        private String guest;
        private String status;
        private String table;
        private String remove;
        private String edit;
        private String picture;
        private String palpic;

        #region Properties
        [Category("Custom Props")]
        public string Name
        {
            get { return name; }
            set { name = value; lb_name.Text = value; }
        }

        [Category("Custom Props")]
        public string Time
        {
            get { return time; }
            set { time = value; lb_time.Text = value; }
        }

        [Category("Custom Props")]
        public string Guest
        {
            get { return guest; }
            set { guest = value; lb_numGuest.Text = value; }
        }

        [Category("Custom Props")]
        public string Status
        {
            get { return status; }
            set { status = value; lb_status.Text = value; }
        }

        [Category("Custom Props")]
        public string Picture
        {
            get { return picture; }
            set { picture = value; pic_status.Text = value; }
        }

        [Category("Custom Props")]
        public string PanelPic
        {
            get { return palpic; }
            set { palpic = value; pal_pic.Text = value; }
        }

        [Category("Custom Props")]
        public string Remove
        {
            get { return remove; }
            set { remove = value; btn_remove.Text = value; }
        }

        [Category("Custom Props")]
        public string Edit
        {
            get { return edit; }
            set { edit = value; btn_remove.Text = value; }
        }

        #endregion


    }
}
