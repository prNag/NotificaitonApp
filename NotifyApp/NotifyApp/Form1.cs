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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int32 tempInt = 0;
            try
            {
                if (Int32.TryParse(txtNofiyTime.Text, out tempInt))
                {
                    if (tempInt > 0)
                    {
                        MessageBox.Show("Notification Time Updated");
                        notfiyTime = tempInt;
                    }
                    else {
                        MessageBox.Show("Enter Valid Time");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
         

        }
    }
}
