using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyApp
{
    public partial class NotificationForm : Form
    {
        Timer closeTime = new Timer();
        public NotificationForm()
        {
            closeTime.Interval = 10000;
            closeTime.Tick += new EventHandler(closeFuntion);
            closeTime.Start();
            InitializeComponent();
        }

        void closeFuntion(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
