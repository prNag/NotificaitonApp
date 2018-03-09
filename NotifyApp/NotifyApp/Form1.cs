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

        Timer timer = new Timer();
       
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
                        timer.Interval = tempInt;
                        timer.Tick += new EventHandler(openFuntion);
                        timer.Start();
                    }
                    else {
                        MessageBox.Show("Enter Valid Time");
                        timer.Stop();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number");
                    timer.Stop();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                timer.Stop();
            }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current Time interval is set to " + (notfiyTime / 1000) + " s");
        }
        void openFuntion(object sender, EventArgs e)
        {
            NotificationForm tForm = new NotificationForm();
            tForm.Show();
            timer.Stop();
        }
    }
}
