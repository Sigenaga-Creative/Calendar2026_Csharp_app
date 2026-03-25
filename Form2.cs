using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace _0H03018_重永敏英_uiux01
{
    public partial class Form2 : Form
    {

        private int key2;
        private string kisetu2;
        int sijidori_Visible;       //全体で使うためにグローバル
        int Myuto;


        public Form2(int key,String kisetu,int sijidori_Visible_0,int Myuto0)
        {
            InitializeComponent();
            //画面サイズを変更できなくする処理
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //引数持ってくる処理
            key2 = key;          //何月か示す変数
            kisetu2 = kisetu;   //その月の季節を示す変数
            sijidori_Visible = sijidori_Visible_0;

            Myuto = Myuto0;




            //閉じるボタンやフォームを消す処理
            this.ControlBox = false;
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;   //最大サイズへ変更
            pictureBox2.Image = Image.FromFile("閉じるボタン.png");
            pictureBox5.Image = Image.FromFile("↑のラベル.png");

            pictureBox6.Image = Image.FromFile("左選択ボタン.png");
            pictureBox7.Image = Image.FromFile("右選択ボタン.png");

            //音の強制処理
            axWindowsMediaPlayer1.uiMode = "none";                  //動作阻止処理
            axWindowsMediaPlayer1.Visible = false;                  //透明化処理

            axWindowsMediaPlayer2.uiMode = "none";                  //動作阻止処理
            axWindowsMediaPlayer2.Visible = false;                  //透明化処理


        }

        //ロードされた時にする処理
        private void Form2_Load(object sender, EventArgs e)
        {
            //メモをリセットする処理
            textBox1.Text = "";

            //季節の絵を表示するプログラム
            switch (kisetu2)
            {
                case "春":
                    pictureBox1.Image = Image.FromFile("春絵.jpg");
                    break;
                case "夏":
                    pictureBox1.Image = Image.FromFile("夏絵.jpg");
                    break;
                case "秋":
                    pictureBox1.Image = Image.FromFile("秋絵.jpg");
                    break;
                case "冬":
                    pictureBox1.Image = Image.FromFile("冬絵.jpg");
                    break;
                default:
                    pictureBox1.Image = Image.FromFile("閉じるボタン.png");
                    break;

            }
            switch (key2)
            {
                case 1:
                    pictureBox3.Image = Image.FromFile("k1月.png");
                    pictureBox4.Image = Image.FromFile("1月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 2:
                    pictureBox3.Image = Image.FromFile("k2月.png");
                    pictureBox4.Image = Image.FromFile("2月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki4.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 3:
                    pictureBox3.Image = Image.FromFile("k3月.png");
                    pictureBox4.Image = Image.FromFile("3月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "kimitomo.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 4:
                    pictureBox3.Image = Image.FromFile("k4月.png");
                    pictureBox4.Image = Image.FromFile("4月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaharu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 5:
                    pictureBox3.Image = Image.FromFile("k5月.png");
                    pictureBox4.Image = Image.FromFile("5月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaharu3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 6:
                    pictureBox3.Image = Image.FromFile("k6月.png");
                    pictureBox4.Image = Image.FromFile("6月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "IyasiNatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 7:
                    pictureBox3.Image = Image.FromFile("k7月.png");
                    pictureBox4.Image = Image.FromFile("7月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "aonatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 8:
                    pictureBox3.Image = Image.FromFile("k8月.png");
                    pictureBox4.Image = Image.FromFile("8月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "sawayakanatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 9:
                    pictureBox3.Image = Image.FromFile("k9月.png");
                    pictureBox4.Image = Image.FromFile("9月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 10:
                    pictureBox3.Image = Image.FromFile("k10月.png");
                    pictureBox4.Image = Image.FromFile("10月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki2.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 11:
                    pictureBox3.Image = Image.FromFile("k11月.png");
                    pictureBox4.Image = Image.FromFile("11月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                case 12:
                    pictureBox3.Image = Image.FromFile("k12月.png");
                    pictureBox4.Image = Image.FromFile("12月.png");
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki2.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    break;
                default:
                    pictureBox3.Image = Image.FromFile("閉じるボタン.png");
                    pictureBox4.Image = Image.FromFile("閉じるボタン.png");
                    break;


            }
            //音を消すか消さないか
            if (Myuto == 1)
            {
                //音がある状態ならば
                axWindowsMediaPlayer1.settings.mute = false;
            }
            else
            {
                //音がない状態ならば
                axWindowsMediaPlayer1.settings.mute = true;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "確定音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            //再生している曲を止める
            axWindowsMediaPlayer1.Ctlcontrols.stop();


            From1 form1 = new From1(key2, kisetu2, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //左移動(月減らす)
            if (key2 > 1)
            {
                //keyが1以上のときは減らせる
                key2--;
            }
            else
            {
                //keyが1であれば12月にする
                key2 = 12;
            }
            //音
            axWindowsMediaPlayer2.URL = "決定中.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            //メモをリセットする処理
            textBox1.Text = "";


            //月表示変更処理
            switch (key2)
            {
                case 3:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "kimitomo.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k3月.png");
                    pictureBox4.Image = Image.FromFile("3月.png");
                    pictureBox1.Image = Image.FromFile("春絵.jpg");
                    break;
                case 4:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaharu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k4月.png");
                    pictureBox4.Image = Image.FromFile("4月.png");
                    pictureBox1.Image = Image.FromFile("春絵.jpg");
                    break;
                case 5:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaharu3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k5月.png");
                    pictureBox4.Image = Image.FromFile("5月.png");
                    pictureBox1.Image = Image.FromFile("春絵.jpg");
                    break;
                case 6:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "IyasiNatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k6月.png");
                    pictureBox4.Image = Image.FromFile("6月.png");
                    pictureBox1.Image = Image.FromFile("夏絵.jpg");
                    break;
                case 7:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "aonatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k7月.png");
                    pictureBox4.Image = Image.FromFile("7月.png");
                    pictureBox1.Image = Image.FromFile("夏絵.jpg");
                    break;
                case 8:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "sawayakanatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k8月.png");
                    pictureBox4.Image = Image.FromFile("8月.png");
                    pictureBox1.Image = Image.FromFile("夏絵.jpg");
                    break;
                case 9:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k9月.png");
                    pictureBox4.Image = Image.FromFile("9月.png");
                    pictureBox1.Image = Image.FromFile("秋絵.jpg");
                    break;
                case 10:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki2.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k10月.png");
                    pictureBox4.Image = Image.FromFile("10月.png");
                    pictureBox1.Image = Image.FromFile("秋絵.jpg");
                    break;
                case 11:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k11月.png");
                    pictureBox4.Image = Image.FromFile("11月.png");
                    pictureBox1.Image = Image.FromFile("秋絵.jpg");
                    break;
                case 12:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki2.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k12月.png");
                    pictureBox4.Image = Image.FromFile("12月.png");
                    pictureBox1.Image = Image.FromFile("冬絵.jpg");
                    break;
                case 1:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k1月.png");
                    pictureBox4.Image = Image.FromFile("1月.png");
                    pictureBox1.Image = Image.FromFile("冬絵.jpg");
                    break;
                case 2:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki4.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k2月.png");
                    pictureBox4.Image = Image.FromFile("2月.png");
                    pictureBox1.Image = Image.FromFile("冬絵.jpg");

                    break;
                default:
                    pictureBox4.Image = Image.FromFile("閉じるボタン.png");
                    pictureBox3.Image = Image.FromFile("閉じるボタン.png");
                    pictureBox1.Image = Image.FromFile("閉じるボタン.png");
                    break;
            }
            //音を消すか消さないか
            if (Myuto == 1)
            {
                //音がある状態ならば
                axWindowsMediaPlayer1.settings.mute = false;
            }
            else
            {
                //音がない状態ならば
                axWindowsMediaPlayer1.settings.mute = true;

            }


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //右移動(月増やす)
            if (key2 < 12)
            {
                //keyが11以下までは増やす
                key2++;
            }
            else
            {
                //keyが12であれば1月に戻す
                key2 = 1;
            }
            //音
            axWindowsMediaPlayer2.URL = "決定中.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            //メモをリセットする処理
            textBox1.Text = "";


            //月表示変更処理
            switch (key2)
            {
                case 3:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "kimitomo.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k3月.png");
                    pictureBox4.Image = Image.FromFile("3月.png");
                    pictureBox1.Image = Image.FromFile("春絵.jpg");
                    break;
                case 4:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaharu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k4月.png");
                    pictureBox4.Image = Image.FromFile("4月.png");
                    pictureBox1.Image = Image.FromFile("春絵.jpg");
                    break;
                case 5:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaharu3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k5月.png");
                    pictureBox4.Image = Image.FromFile("5月.png");
                    pictureBox1.Image = Image.FromFile("春絵.jpg");
                    break;
                case 6:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "IyasiNatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k6月.png");
                    pictureBox4.Image = Image.FromFile("6月.png");
                    pictureBox1.Image = Image.FromFile("夏絵.jpg");
                    break;
                case 7:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "aonatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k7月.png");
                    pictureBox4.Image = Image.FromFile("7月.png");
                    pictureBox1.Image = Image.FromFile("夏絵.jpg");
                    break;
                case 8:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "sawayakanatu.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k8月.png");
                    pictureBox4.Image = Image.FromFile("8月.png");
                    pictureBox1.Image = Image.FromFile("夏絵.jpg");
                    break;
                case 9:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k9月.png");
                    pictureBox4.Image = Image.FromFile("9月.png");
                    pictureBox1.Image = Image.FromFile("秋絵.jpg");
                    break;
                case 10:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki2.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k10月.png");
                    pictureBox4.Image = Image.FromFile("10月.png");
                    pictureBox1.Image = Image.FromFile("秋絵.jpg");
                    break;
                case 11:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunaaki3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k11月.png");
                    pictureBox4.Image = Image.FromFile("11月.png");
                    pictureBox1.Image = Image.FromFile("秋絵.jpg");
                    break;
                case 12:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki2.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k12月.png");
                    pictureBox4.Image = Image.FromFile("12月.png");
                    pictureBox1.Image = Image.FromFile("冬絵.jpg");
                    break;
                case 1:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki3.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k1月.png");
                    pictureBox4.Image = Image.FromFile("1月.png");
                    pictureBox1.Image = Image.FromFile("冬絵.jpg");
                    break;
                case 2:
                    //音楽を流す処理
                    axWindowsMediaPlayer1.URL = "setunayuki4.mp3";
                    axWindowsMediaPlayer1.settings.setMode("loop", true);   //無限ループ処理
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    pictureBox3.Image = Image.FromFile("k2月.png");
                    pictureBox4.Image = Image.FromFile("2月.png");
                    pictureBox1.Image = Image.FromFile("冬絵.jpg");

                    break;
                default:
                    pictureBox4.Image = Image.FromFile("閉じるボタン.png");
                    pictureBox3.Image = Image.FromFile("閉じるボタン.png");
                    pictureBox1.Image = Image.FromFile("閉じるボタン.png");
                    break;
            }
            //音を消すか消さないか
            if (Myuto == 1)
            {
                //音がある状態ならば
                axWindowsMediaPlayer1.settings.mute = false;
            }
            else
            {
                //音がない状態ならば
                axWindowsMediaPlayer1.settings.mute = true;

            }


        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox2.Image = Image.FromFile("閉じるボタン_選択後.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("閉じるボタン.png");
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("左選択ボタン_2.png");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("左選択ボタン.png");

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox7.Image = Image.FromFile("右選択ボタン_2.png");
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile("右選択ボタン.png");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
