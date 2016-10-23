﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace StreamTimer
{
    public partial class FormMain : Form
    {
        FormOptions Options = new FormOptions();
        private bool countdown = true;
        private bool timechanged = false;
        private bool enabled = true;
        private int cddef = 0;
        private int[] time = new int[3] { 0, 0, 0 };
        private int[] lasttime = new int[3] { 1, 0, 0 };
        private long swtlast = 0;

        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        public FormMain()
        {
            InitializeComponent();
            sw.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (TimerSettings.Default.countdown) radiodown.PerformClick();
            else radioup.PerformClick();

            cddef = TimerSettings.Default.countdownDef;
            time[2] = TimerSettings.Default.posOnExit;
            time[1] = 0;
            time[0] = 0;
            formatTimes();
        }

        private void formatTimes()
        {
            if (time[2] > 59)
            {
                time[1] += time[2] / 60;
                time[2] = time[2] % 60;
            }

            if (time[1] > 59)
            {
                time[0] += time[1] / 60;
                time[1] = time[1] % 60;
            }
            updateBoxes();
        }

        private void updateBoxes()
        {
            hour.Text = Convert.ToString(time[0]);
            minute.Text = Convert.ToString(time[1]);
            second.Text = Convert.ToString(time[2]);
            String text = "";
            if (!TimerSettings.Default.hideHrs || time[0] > 0)
            {
                if (hour.Text.Length < 2)
                {
                    text = "0" + hour.Text + ":";
                }
                else
                {
                    text = hour.Text + ":";
                }
            }
            
            if (minute.Text.Length < 2)
            {
                text += "0" + minute.Text + ":";
            }
            else
            {
                text += minute.Text + ":";
            }

            if (second.Text.Length < 2)
            {
                text += "0" + second.Text;
            }
            else
            {
                text += second.Text;
            }
            File.WriteAllText(@"C:\Users\" + System.Environment.UserName + @"\Documents\timer.txt", text);
        }

        private void en_off()
        {
            radiodown.Enabled = false;
            radioup.Enabled = false;
            hour.Enabled = false;
            minute.Enabled = false;
            second.Enabled = false;
            enabled = false;
        }

        private void en_on()
        {
            radiodown.Enabled = true;
            radioup.Enabled = true;
            hour.Enabled = true;
            minute.Enabled = true;
            second.Enabled = true;
            enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds >= swtlast + 1000)
            {
                swtlast += 1000;
                swTick();

            }
        }

        private void swTick()
        {
            if (countdown)
            {
                if (time[2] <= 0)
                {
                    time[1]--;
                    time[2] = 59;
                }
                else
                {
                    time[2]--;
                }

                if (time[1] < 0)
                {
                    time[0]--;
                    time[1] = 59;
                }

                if ((time[0] + time[1] + time[2]) < 1)
                {
                    timer.Stop();
                    en_on();
                    updateBoxes();
                    MessageBox.Show("The timer has reached 0.", "Timer Ended", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (time[2] >= 59)
                {
                    time[1]++;
                    time[2] = 0;
                }
                else
                {
                    time[2]++;
                }

                if (time[1] > 59)
                {
                    time[0]++;
                    time[1] = 0;
                }
            }
            updateBoxes();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (enabled)
            {
                time[0] = Convert.ToInt32(hour.Text);
                time[1] = Convert.ToInt32(minute.Text);
                if (second.Text == "")
                {
                    second.Text = "0";
                }
                time[2] = Convert.ToInt32(second.Text);

                if (timechanged)
                {
                    cddef = ((time[0] * 3600) + (time[1] * 60) + time[2]);

                    TimerSettings.Default.countdownDef = cddef;
                    TimerSettings.Default.Save();

                    timechanged = false;
                }

                formatTimes();

                if (countdown)
                {
                    if ((time[0] + time[1] + time[2]) > 0)
                    {
                        en_off();
                        lasttime[0] = time[0];
                        lasttime[1] = time[1];
                        lasttime[2] = time[2];
                        timer.Start();
                        swtlast = 0;
                        sw.Reset();
                        sw.Start();
                    }
                }
                else
                {
                    en_off();
                    timer.Start();
                    swtlast = 0;
                    sw.Reset();
                    sw.Start();
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (!enabled)
            {
                timer.Stop();
                sw.Stop();
                en_on();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            sw.Stop();
            en_on();
            if (countdown)
            {
                time[2] = cddef;
                time[1] = 0;
                time[0] = 0;

                formatTimes();
            }
            else
            {
                time[0] = 0;
                time[1] = 0;
                time[2] = 0;
                updateBoxes();
            }
        }

        private void options_Click(object sender, EventArgs e)
        {
            Options = new FormOptions();
            Options.ShowDialog();
        }

        private void hour_TextChanged(object sender, EventArgs e)
        {
            if (countdown && enabled)
            {
                timechanged = true;
            }
        }

        private void second_TextChanged(object sender, EventArgs e)
        {
            if (countdown && enabled)
            {
                timechanged = true;
            }
        }

        private void minute_TextChanged(object sender, EventArgs e)
        {
            if (countdown && enabled)
            {
                timechanged = true;
            }
        }

        private void hour_Focus(object sender, EventArgs e)
        {
            hour.SelectAll();
        }

        private void minute_Focus(object sender, EventArgs e)
        {
            minute.SelectAll();
        }

        private void second_Focus(object sender, EventArgs e)
        {
            second.SelectAll();
        }

        private void radiodown_CheckedChanged(object sender, EventArgs e)
        {
            if (radiodown.Checked)
            {
                countdown = true;

                TimerSettings.Default.countdown = true;
                TimerSettings.Default.Save();
            }
        }

        private void radioup_CheckedChanged(object sender, EventArgs e)
        {
            if (radioup.Checked)
            {
                countdown = false;

                TimerSettings.Default.countdown = false;
                TimerSettings.Default.Save();
            }
        }

        private void hour_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void hour_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                minute.Focus();
            }
        }

        private void minute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void minute_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                second.Focus();
            }
        }

        private void second_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void second_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void second_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_start.PerformClick();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerSettings.Default.posOnExit = (time[0] * 3600) + (time[1] * 60) + time[2];
            TimerSettings.Default.Save();

            if (!enabled)
            {
                DialogResult dialogResult = MessageBox.Show("Timer is currently running. Are you sure you want to exit?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void hour_Leave(object sender, EventArgs e)
        {
            if (hour.Text == "")
            {
                hour.Text = "0";
            }
        }

        private void minute_Leave(object sender, EventArgs e)
        {
            if (minute.Text == "")
            {
                minute.Text = "0";
            }
        }

        private void second_Leave(object sender, EventArgs e)
        {
            if (second.Text == "")
            {
                second.Text = "0";
            }
        }
    }
}