using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0H03018_重永敏英_uiux01
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            int key = 1;
            string kisetu = "冬";
            //チュートリアルの設定
            int sijidori_Visible = Properties.Settings.Default.Chutoriaru;       //保存していたものをここで渡す
            int Myuto = 1;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3(key,kisetu,sijidori_Visible,Myuto));
        }
    }
}
