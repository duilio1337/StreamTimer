using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamTimer
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
            cb_hidehr.Checked = TimerSettings.Default.hideHrs;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stream timer created by Duilio." + Environment.NewLine + "Version: 1.1.1" + Environment.NewLine + "This program will automatically create a new file called 'timer.txt' in your documents.", "About");
        }

        private void cb_showhr_CheckedChanged(object sender, EventArgs e)
        {
            TimerSettings.Default.hideHrs = cb_hidehr.Checked;
        }
    }
}
