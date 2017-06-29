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
    public partial class TimerForm : Form
    {
        private Timer timer;
        private DateTime toDatetime;
        private bool isCountDownRunning = false;
        private string formSize;
        private int formPosition;

        public TimerForm()
        {
            InitializeComponent();
        }

        public TimerForm(string size, int position) : this()
        {
            formSize = size;
            formPosition = position;
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            if (formSize == "S")
            {
                this.Size = new Size(250, 50);
                timeLabel.Font = new Font(new FontFamily("メイリオ"), 24);
            }

            // ウィンドウを画面右下に表示させる
            ChangeFormPosition();

            this.TopMost = true;

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isCountDownRunning)
            {
                timer.Stop();

                for (int i = Properties.Settings.Default.StartCountDown; i >= 0; i--)
                {
                    timeLabel.Text = i == 0 ? "スタート" : i.ToString();
                    this.Refresh();
                    System.Threading.Thread.Sleep(1000);
                }

                toDatetime = DateTime.Now.AddSeconds(Properties.Settings.Default.CountDownSeconds);
                timer.Start();
                isCountDownRunning = true;
            }

            // 現在時を取得
            DateTime now = DateTime.Now;

            //残り時間を表示
            timeLabel.Text = (toDatetime - now).ToString(@"hh\:mm\:ss\.fff");

            if ((toDatetime - now).TotalMilliseconds <= 0)
            {
                //タイマー停止
                timer.Stop();

                this.Close();
            }
        }

        private void ChangeFormPosition()
        {
            int left = 0;
            int top = 0;

            switch (formPosition)
            {
                case 0:
                    left = 0;
                    top = 0;
                    break;
                case 1:
                    left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                    top = 0;
                    break;
                case 2:
                    left = 0;
                    top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                    break;
                case 3:
                    left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                    top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                    break;
            }

            DesktopBounds = new Rectangle(left, top, this.Width, this.Height);
        }
    }
}
