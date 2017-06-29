using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownTimer
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 初期化
            System.Threading.Mutex mtxApp = new System.Threading.Mutex(false, Application.ProductName + Properties.Settings.Default.ID);

            if (mtxApp.WaitOne(0, false))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new OptionForm());
            }
            else
            {
                MessageBox.Show("すでに起動しています。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // ガーベージコレクションに設定
            GC.KeepAlive(mtxApp);

            // オブジェクト破棄
            mtxApp.Close();

        }
    }
}
