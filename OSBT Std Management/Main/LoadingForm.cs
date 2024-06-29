using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSBT_Std_Management
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 10;
            pbar.Text = pbar.Value.ToString() + "%";
            if (pbar.Value == 100)
            {
                timer1.Enabled = false;
                MainForm main = new MainForm();
                this.Hide();
                main.Show();
            }
        }


    }
}
