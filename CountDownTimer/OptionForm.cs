using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownTimer
{
    public partial class OptionForm : Form
    {
        private Timer timer;
        private const string LARGE_FORM_SIZE= "L";
        private const string SMALL_FORM_SIZE= "S";

        public OptionForm()
        {
            InitializeComponent();

            this.Text += "（" + Properties.Settings.Default.ID + "）";
            notifyIcon1.Text = Properties.Settings.Default.ID;

            timer = new Timer();
            timer.Interval = Properties.Settings.Default.TimeCheckSpan * 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            textBoxID.Text = Properties.Settings.Default.ID;
            numericUpDownRunMinute.Value = Properties.Settings.Default.RunMinute;
            numericUpDownCountDownSeconds.Value = Properties.Settings.Default.CountDownSeconds;
            radioButtonLarge.Checked = Properties.Settings.Default.TimerFormSize.ToUpper() == LARGE_FORM_SIZE ? true : false;
            radioButtonSmall.Checked = Properties.Settings.Default.TimerFormSize.ToUpper() != LARGE_FORM_SIZE ? true : false;
            switch (Properties.Settings.Default.TimerFormPosition)
            {
                case 0:
                    radioButtonTopLeft.Checked = true;
                    break;
                case 1:
                    radioButtonTopRight.Checked = true;
                    break;
                case 2:
                    radioButtonBottomLeft.Checked = true;
                    break;
                case 3:
                    radioButtonBottomRight.Checked = true;
                    break;
            }
            numericUpDownStartCountDown.Value = Properties.Settings.Default.StartCountDown;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text != Properties.Settings.Default.ID)
            {
                MessageBox.Show("識別名の変更は次回起動から有効になります。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Properties.Settings.Default.ID = textBoxID.Text;
            Properties.Settings.Default.RunMinute = Convert.ToInt32(numericUpDownRunMinute.Value);
            Properties.Settings.Default.CountDownSeconds = Convert.ToInt32(numericUpDownCountDownSeconds.Value);
            Properties.Settings.Default.TimerFormSize = radioButtonLarge.Checked ? LARGE_FORM_SIZE : SMALL_FORM_SIZE;
            Properties.Settings.Default.StartCountDown = Convert.ToInt32(numericUpDownStartCountDown.Value);
            if (radioButtonTopLeft.Checked)
            {
                Properties.Settings.Default.TimerFormPosition = 0;
            }
            if (radioButtonTopRight.Checked)
            {
                Properties.Settings.Default.TimerFormPosition = 1;
            }
            if (radioButtonBottomLeft.Checked)
            {
                Properties.Settings.Default.TimerFormPosition = 2;
            }
            if (radioButtonBottomRight.Checked)
            {
                Properties.Settings.Default.TimerFormPosition = 3;
            }
            Properties.Settings.Default.Save();

            this.Hide();
        }

        private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (now.Minute == Properties.Settings.Default.RunMinute)
            {
                timer.Stop();

                using (TimerForm launcherForm = new TimerForm(Properties.Settings.Default.TimerFormSize, Properties.Settings.Default.TimerFormPosition))
                {
                    launcherForm.ShowDialog();
                }

                timer.Start();
            }
        }

        private void OptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void OptionForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OptionForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ImmediatelyRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();

            using (TimerForm launcherForm = new TimerForm(Properties.Settings.Default.TimerFormSize, Properties.Settings.Default.TimerFormPosition))
            {
                launcherForm.ShowDialog();
            }

            timer.Start();
        }
    }
}
