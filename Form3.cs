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
    public partial class Form3 : Form
    {
        int key0;
        private string kisetu;
        int sijidori_Visible;       //全体で使うためにグローバル
        int Myuto;


        public Form3(int key, String kisetu0, int sijidori_Visible_0,int Myuto0)
        {
            InitializeComponent();

            this.ControlBox = false;
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;   //最大サイズにする処理
            //画面サイズを変更できなくする処理
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            sijidori_Visible = sijidori_Visible_0;
            key0 = key;
            kisetu = kisetu0;
            Myuto = Myuto0;




            //画面を飾る処理
            pictureBox1.Image = Image.FromFile("スタート画面.png");
            pictureBox2.Image = Image.FromFile("↑のラベル.png");
            pictureBox3.Image = Image.FromFile("↓のラベル.png");
            pictureBox4.Image = Image.FromFile("下ラベル文字.png");
            pictureBox5.Image = Image.FromFile("下のラベル2.png");
            pictureBox6.Image = Image.FromFile("指示鳥.png");
            syuuryousetu.Image = Image.FromFile("閉じるボタンの詳細表示.png");
            syuuryousetu.Visible = false;

            pictureBox7.Image = Image.FromFile("↓のラベル.png");
            pictureBox8.Image = Image.FromFile("↓のラベル.png");
            pictureBox9.Image = Image.FromFile("↓のラベル.png");
            pictureBox10.Image = Image.FromFile("↓のラベル.png");
            pictureBox11.Image = Image.FromFile("↓のラベル.png");
            pictureBox12.Image = Image.FromFile("↓のラベル.png");
            pictureBox13.Image = Image.FromFile("↓のラベル.png");
            pictureBox14.Image = Image.FromFile("↓のラベル.png");
            pictureBox15.Image = Image.FromFile("↓のラベル.png");
            pictureBox16.Image = Image.FromFile("↓のラベル.png");
            pictureBox17.Image = Image.FromFile("↓のラベル.png");
            pictureBox18.Image = Image.FromFile("↓のラベル.png");
            pictureBox19.Image = Image.FromFile("↓のラベル.png");


            pictureBox20.Image = Image.FromFile("閉じるボタン.png");

            //チュートリアル案内の表示　非表示
            if(sijidori_Visible == 0)
            {
                pictureBox6.Visible = false;
                label4.Visible = false;

            }
            else
            {
                pictureBox6.Visible = true;
                label4.Visible = true;
            }





        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //音楽を流す処理
            axWindowsMediaPlayer1.uiMode = "none";                  //動作阻止処理
            axWindowsMediaPlayer1.Visible = false;                  //透明化処理
            axWindowsMediaPlayer1.URL = "PoPst.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();


            axWindowsMediaPlayer2.uiMode = "none";                  //動作阻止処理
            axWindowsMediaPlayer2.Visible = false;                  //透明化処理


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


            timer1.Interval = 530;
            timer1.Enabled = true;
            label1.Visible = true;
        }

        private void Form3_Click(object sender, EventArgs e)
        {

            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();



            axWindowsMediaPlayer1.Ctlcontrols.stop();
            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();
            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "スタート音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            From1 form1 = new From1(key0, kisetu, sijidori_Visible, Myuto);
            form1.ShowDialog();
            this.Close();

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //すべてのフォームを閉じる
            Application.Exit();

        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox20.Image = Image.FromFile("閉じるボタン_選択後.png");
            syuuryousetu.Visible = true;

        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile("閉じるボタン.png");
            syuuryousetu.Visible = false;

        }
    }
}
