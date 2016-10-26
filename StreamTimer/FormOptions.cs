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
            tb_prefix.Text = TimerSettings.Default.prefix;
            tb_suffix.Text = TimerSettings.Default.suffix;
            cb_overtime.Checked = TimerSettings.Default.overtime;
            cb_nonotify.Checked = TimerSettings.Default.nonotify;
            tb_otprefix.Text = TimerSettings.Default.otPrefix;
            tb_otsuffix.Text = TimerSettings.Default.otSuffix;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stream timer created by Rob 'duilio1337' Harper." + Environment.NewLine + "Version: 1.2.2" + Environment.NewLine + "This program will automatically create a new file called 'timer.txt' in your documents by default.", "About");
        }

        private void cb_showhr_CheckedChanged(object sender, EventArgs e)
        {
            TimerSettings.Default.hideHrs = cb_hidehr.Checked;
        }

        private void tb_prefix_TextChanged(object sender, EventArgs e)
        {
            TimerSettings.Default.prefix = tb_prefix.Text;
        }

        private void tb_suffix_TextChanged(object sender, EventArgs e)
        {
            TimerSettings.Default.suffix = tb_suffix.Text;
        }

        private void cb_overtime_CheckedChanged(object sender, EventArgs e)
        {
            TimerSettings.Default.overtime = cb_overtime.Checked;
        }

        private void cb_nonotify_CheckedChanged(object sender, EventArgs e)
        {
            TimerSettings.Default.nonotify = cb_nonotify.Checked;
        }

        private void tb_otprefix_TextChanged(object sender, EventArgs e)
        {
            TimerSettings.Default.otPrefix = tb_otprefix.Text;
        }

        private void tb_otsuffix_TextChanged(object sender, EventArgs e)
        {
            TimerSettings.Default.otSuffix = tb_otsuffix.Text;
        }

        private void b_file_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog(this);
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            TimerSettings.Default.filePath = saveFileDialog.FileName;
            TimerSettings.Default.Save();
        }
    }
}
