using AxWMPLib;
using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;


namespace _0H03018_重永敏英_uiux01
{
    public partial class From1 : Form
    {
        //グローバルエリア
        private int key;    //選択のが何月か示す変数
        private string kisetu;    //その月の季節を示す変数
        private Image motogaharu;       //春夏秋冬の最初に表示される画像を保存する変数(以下略)
        private Image motoganatu;
        private Image motogaaki;
        private Image motogahuyu;



        int sijidori2 = 1;  //最初の指示を表示するかどうか切り替えるための変数(以下似たようなもの)
        int sijidori3 = 0;

        int sijidori_Visible;       //全体で使うためにグローバル
        int Myuto;      //1が音あり、0が音なし




        public From1(int key0, String kisetu0, int sijidori_Visible_0,int Myuto0)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            pictureBox1.Image = Image.FromFile("閉じるボタン.png");
            pictureBox1.Visible = false;

            TaitoruBotan.Image = Image.FromFile("タイトルボタン.png");
            TaitoruBotan.Visible = false;
            Taitorusetu.Image = Image.FromFile("タイトル画面の詳細表示.png");
            Taitorusetu.Visible = false;
            Myusetu.Image = Image.FromFile("ミュートの詳細表示.png");
            Myusetu.Visible = false;
            axWindowsMediaPlayer1.settings.mute = true;
            Myuto = Myuto0;


            //チュートリアル詳細の切り替え表示
            sijidori_Visible = sijidori_Visible_0;       //引数受け渡し

            if (sijidori_Visible == 1)
            {
                Chuto_Visi.Image = Image.FromFile("Ch_表示.png");
            }
            else
            {
                Chuto_Visi.Image = Image.FromFile("Ch_非表示.png");
            }
            Chuto_Visi.Visible = false;

            //引数引き渡し処理
            key = key0;
            kisetu = kisetu0;

            axWindowsMediaPlayer1.uiMode = "none";                  //動作阻止処理
            axWindowsMediaPlayer1.Visible = false;                  //透明化処理

            axWindowsMediaPlayer2.uiMode = "none";                  //動作阻止処理
            axWindowsMediaPlayer2.Visible = false;                  //透明化処理





            sijituki_haru.Image = Image.FromFile("指示鳥.png");

            sijikare.Image = Image.FromFile("指示鳥.png");

            //祝日_初期設定
            pictureBox23.Image = Image.FromFile("s1月.png");

            //音楽をシャッフルする下準備
            Random rnd = new System.Random();
            int kyoku_r = rnd.Next(3);

            //音楽を流す処理
            switch (kyoku_r)
            {
                case 0:
                    axWindowsMediaPlayer1.URL = "Sparrow_Land.mp3";
                    break;
                case 1:
                    axWindowsMediaPlayer1.URL = "PopHome.mp3";
                    break;
                case 2:
                    axWindowsMediaPlayer1.URL = "IyasiHome.mp3";
                    break;

            }
            axWindowsMediaPlayer1.settings.setMode("loop", true);       //無限ループ
            axWindowsMediaPlayer1.Ctlcontrols.play();

            //音を消すか消さないか
            if (Myuto == 1)
            {
                //音がある状態ならば
                axWindowsMediaPlayer1.settings.mute = false;
                MyutoBtan.Image = Image.FromFile("ミュートボタン.png");
            }
            else
            {
                //音がない状態ならば
                axWindowsMediaPlayer1.settings.mute = true;
                MyutoBtan.Image = Image.FromFile("ミュートボタン_ミュート後.png");

            }
            MyutoBtan.Visible = false;


            On_pop.Image = Image.FromFile("ホーム曲_POP.png");
            On_niti.Image = Image.FromFile("ホーム曲_日常.png");
            On_nou.Image = Image.FromFile("ホーム曲_能天気.png");
            On_pop.Visible = false;
            On_niti.Visible = false;
            On_nou.Visible = false;
            HomeOnsetu.Image = Image.FromFile("ホーム曲の詳細表示.png");

            HomeOnsetu.Visible = false;



            switch (key)
            {
                case 3:
                    pictureBox6.Image = Image.FromFile("3月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s3月.png");

                    break;
                case 4:
                    pictureBox6.Image = Image.FromFile("4月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s4月.png");
                    break;
                case 5:
                    pictureBox6.Image = Image.FromFile("5月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s5月.png");
                    break;
                case 6:
                    pictureBox6.Image = Image.FromFile("6月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s6月.png");

                    break;
                case 7:
                    pictureBox6.Image = Image.FromFile("7月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s7月.png");

                    break;
                case 8:
                    pictureBox6.Image = Image.FromFile("8月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s8月.png");
                    break;
                case 9:
                    pictureBox6.Image = Image.FromFile("9月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s9月.png");

                    break;
                case 10:
                    pictureBox6.Image = Image.FromFile("10月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s10月.png");

                    break;
                case 11:
                    pictureBox6.Image = Image.FromFile("11月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s11月.png");

                    break;
                case 12:
                    pictureBox6.Image = Image.FromFile("12月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s12月.png");

                    break;
                case 1:
                    pictureBox6.Image = Image.FromFile("1月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s1月.png");
                    break;
                case 2:
                    pictureBox6.Image = Image.FromFile("2月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s2月.png");


                    break;
                default:
                    pictureBox6.Image = Image.FromFile("閉じるボタン.png");
                    pictureBox23.Image = Image.FromFile("閉じるボタン.png");

                    break;
            }



            //春ボタン
            pictureBox10.Image = Image.FromFile("春.png");
            motogaharu = pictureBox10.Image;
            pictureBox2.Visible = false;
            pictureBox2.Image = Image.FromFile("3.png");
            pictureBox12.Visible = false;
            pictureBox12.Image = Image.FromFile("4.png");
            pictureBox13.Visible = false;
            pictureBox13.Image = Image.FromFile("5.png");


            //夏ボタン
            pictureBox3.Image = Image.FromFile("夏.png");
            motoganatu = pictureBox3.Image;
            pictureBox14.Visible = false;
            pictureBox14.Image = Image.FromFile("6.png");
            pictureBox15.Visible = false;
            pictureBox15.Image = Image.FromFile("7.png");
            pictureBox16.Visible = false;
            pictureBox16.Image = Image.FromFile("8.png");

            //秋ボタン
            pictureBox4.Image = Image.FromFile("秋.png");
            motogaaki = pictureBox4.Image;
            pictureBox17.Visible = false;
            pictureBox17.Image = Image.FromFile("9.png");
            pictureBox18.Visible = false;
            pictureBox18.Image = Image.FromFile("10.png");
            pictureBox19.Visible = false;
            pictureBox19.Image = Image.FromFile("11.png");

            //冬ボタン
            pictureBox5.Image = Image.FromFile("冬.png");
            motogahuyu = pictureBox5.Image;
            pictureBox20.Visible = false;
            pictureBox20.Image = Image.FromFile("12.png");
            pictureBox21.Visible = false;
            pictureBox21.Image = Image.FromFile("1.png");
            pictureBox22.Visible = false;
            pictureBox22.Image = Image.FromFile("2.png");

            //月の表示周り
            pictureBox9.Image = Image.FromFile("月背景.png");
            pictureBox7.Image = Image.FromFile("右選択ボタン2.png");
            pictureBox8.Image = Image.FromFile("左選択ボタン2.png");
            syousai.Image = Image.FromFile("詳細ボタン.png");
            syuuryousetu.Image = Image.FromFile("閉じるボタンの詳細表示.png");
            syuuryousetu.Visible = false;
            ChutoSetu.Image = Image.FromFile("チュートリアルの詳細表示.png");
            ChutoSetu.Visible = false;


            pictureBox11.Image = Image.FromFile("カレンダー表示_カーソル前.png");

            //指示鳥プログラム　初期設定
            sijituki_haru.Visible = true;
            sijikare.Visible = false;

            //指示鳥_時計の設定
            timer1.Interval = 10;
            timer1.Enabled = true;
            //指示鳥_最初のセリフ
            inko_koe1.Image = Image.FromFile("選択したい月を選ぶ.png");
            inko_koe2.Image = Image.FromFile("カレンダー表示はここ.png");
            if (sijidori2 == 1)
            {
            }
            if (sijidori3 == 0)
            {
                inko_koe2.Visible = false;
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //すべてのフォームを閉じる
            Application.Exit();
        }





        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();


            //夏

            pictureBox3.Image = Image.FromFile("夏k.png");

            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;

            //春を消す処理
            if (pictureBox2.Visible == true)
            {
                pictureBox10.Image = motogaharu;

                pictureBox2.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;

            }
            //秋を消す処理
            if (pictureBox17.Visible == true)
            {
                pictureBox4.Image = motogaaki;


                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;

            }
            //冬を消す処理
            if (pictureBox20.Visible == true)
            {
                pictureBox5.Image = motogahuyu;

                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;

            }




        }   //夏表示

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            //秋
            pictureBox4.Image = Image.FromFile("秋k.png");


            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;

            //夏を消す処理
            if (pictureBox14.Visible == true)
            {
                pictureBox3.Image = motoganatu;

                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;

            }
            //冬を消す処理
            if (pictureBox20.Visible == true)
            {
                pictureBox5.Image = motogahuyu;

                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;

            }
            //春を消す処理
            if (pictureBox2.Visible == true)
            {
                pictureBox10.Image = motogaharu;


                pictureBox2.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;

            }


        }   //秋表示

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            //冬
            pictureBox5.Image = Image.FromFile("冬k.png");

            pictureBox20.Visible = true;
            pictureBox21.Visible = true;
            pictureBox22.Visible = true;
            //秋を消す処理
            if (pictureBox17.Visible == true)
            {
                pictureBox4.Image = motogaaki;

                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;

            }
            //夏を消す処理
            if (pictureBox14.Visible == true)
            {
                pictureBox3.Image = motoganatu;

                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;

            }
            //春を消す処理
            if (pictureBox2.Visible == true)
            {
                pictureBox10.Image = motogaharu;

                pictureBox2.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;

            }



        }   //冬表示

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }   //フォーム1ロード



        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            //春
            pictureBox10.Image = Image.FromFile("春k.png");
            pictureBox2.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;

            //夏を消す処理
            if (pictureBox14.Visible == true)
            {
                pictureBox3.Image = motoganatu;

                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;

            }
            //秋を消す処理
            if (pictureBox17.Visible == true)
            {
                pictureBox4.Image = motogaaki;

                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;

            }
            //冬を消す処理
            if (pictureBox20.Visible == true)
            {
                pictureBox5.Image = motogahuyu;

                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;

            }




        }   //春表示

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {


        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
        }


        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();


            pictureBox6.Image = Image.FromFile("4月.png");
            kisetu = "春";
            key = 4;
            pictureBox23.Image = Image.FromFile("s4月.png");
            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }


        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("5月.png");
            kisetu = "春";
            key = 5;
            pictureBox23.Image = Image.FromFile("s5月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("3月.png");
            kisetu = "春";
            key = 3;
            pictureBox23.Image = Image.FromFile("s3月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }


        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("6月.png");
            kisetu = "夏";
            key = 6;
            pictureBox23.Image = Image.FromFile("s6月.png");
            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }



        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("7月.png");
            kisetu = "夏";
            key = 7;
            pictureBox23.Image = Image.FromFile("s7月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("8月.png");
            kisetu = "夏";
            key = 8;
            pictureBox23.Image = Image.FromFile("s8月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("9月.png");
            kisetu = "秋";
            key = 9;
            pictureBox23.Image = Image.FromFile("s9月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("10月.png");
            kisetu = "秋";
            key = 10;
            pictureBox23.Image = Image.FromFile("s10月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("11月.png");
            kisetu = "秋";
            key = 11;
            pictureBox23.Image = Image.FromFile("s11月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }


        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("12月.png");
            kisetu = "冬";
            key = 12;
            pictureBox23.Image = Image.FromFile("s12月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }


        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("1月.png");
            kisetu = "冬";
            key = 1;
            pictureBox23.Image = Image.FromFile("s1月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }


        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "決定小.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox6.Image = Image.FromFile("2月.png");
            kisetu = "冬";
            key = 2;
            pictureBox23.Image = Image.FromFile("s2月.png");

            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //右移動(月増やす)
            if (key < 12)
            {
                //keyが11以下までは増やす
                key++;
            }
            else
            {
                //keyが12であれば1月に戻す
                key = 1;
            }
            //音
            axWindowsMediaPlayer2.URL = "決定中.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();
            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }


            //月表示変更処理
            switch (key)
            {
                case 3:
                    pictureBox6.Image = Image.FromFile("3月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s3月.png");

                    break;
                case 4:
                    pictureBox6.Image = Image.FromFile("4月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s4月.png");

                    break;
                case 5:
                    pictureBox6.Image = Image.FromFile("5月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s5月.png");


                    break;
                case 6:
                    pictureBox6.Image = Image.FromFile("6月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s6月.png");


                    break;
                case 7:
                    pictureBox6.Image = Image.FromFile("7月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s7月.png");

                    break;
                case 8:
                    pictureBox6.Image = Image.FromFile("8月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s8月.png");

                    break;
                case 9:
                    pictureBox6.Image = Image.FromFile("9月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s9月.png");


                    break;
                case 10:
                    pictureBox6.Image = Image.FromFile("10月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s10月.png");


                    break;
                case 11:
                    pictureBox6.Image = Image.FromFile("11月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s11月.png");


                    break;
                case 12:
                    pictureBox6.Image = Image.FromFile("12月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s12月.png");

                    break;
                case 1:
                    pictureBox6.Image = Image.FromFile("1月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s1月.png");
                    break;
                case 2:
                    pictureBox6.Image = Image.FromFile("2月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s2月.png");



                    break;
                default:
                    pictureBox6.Image = Image.FromFile("閉じるボタン.png");
                    pictureBox23.Image = Image.FromFile("閉じるボタン.png");

                    break;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //左移動(月減らす)
            if (key > 1)
            {
                //keyが1以上のときは減らせる
                key--;
            }
            else
            {
                //keyが1であれば12月にする
                key = 12;
            }
            //音
            axWindowsMediaPlayer2.URL = "決定中.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();


            //指示鳥を次へ動かす処理
            if (sijidori2 == 1)
            {
                sijidori2 = 0;
                sijidori3 = 1;
            }


            //月表示変更処理
            switch (key)
            {
                case 3:
                    pictureBox6.Image = Image.FromFile("3月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s3月.png");

                    break;
                case 4:
                    pictureBox6.Image = Image.FromFile("4月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s4月.png");

                    break;
                case 5:
                    pictureBox6.Image = Image.FromFile("5月.png");
                    kisetu = "春";
                    pictureBox23.Image = Image.FromFile("s5月.png");


                    break;
                case 6:
                    pictureBox6.Image = Image.FromFile("6月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s6月.png");


                    break;
                case 7:
                    pictureBox6.Image = Image.FromFile("7月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s7月.png");

                    break;
                case 8:
                    pictureBox6.Image = Image.FromFile("8月.png");
                    kisetu = "夏";
                    pictureBox23.Image = Image.FromFile("s8月.png");

                    break;
                case 9:
                    pictureBox6.Image = Image.FromFile("9月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s9月.png");


                    break;
                case 10:
                    pictureBox6.Image = Image.FromFile("10月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s10月.png");


                    break;
                case 11:
                    pictureBox6.Image = Image.FromFile("11月.png");
                    kisetu = "秋";
                    pictureBox23.Image = Image.FromFile("s11月.png");


                    break;
                case 12:
                    pictureBox6.Image = Image.FromFile("12月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s12月.png");

                    break;
                case 1:
                    pictureBox6.Image = Image.FromFile("1月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s1月.png");
                    break;
                case 2:
                    pictureBox6.Image = Image.FromFile("2月.png");
                    kisetu = "冬";
                    pictureBox23.Image = Image.FromFile("s2月.png");



                    break;
                default:
                    pictureBox6.Image = Image.FromFile("閉じるボタン.png");
                    pictureBox23.Image = Image.FromFile("閉じるボタン.png");

                    break;
            }


        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile("カレンダー表示_カーソル後.png");
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();


            //春を消す処理
            if (pictureBox2.Visible == true)
            {
                pictureBox10.Image = motogaharu;

                pictureBox2.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;

            }
            //夏を消す処理
            if (pictureBox14.Visible == true)
            {
                pictureBox3.Image = motoganatu;

                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;

            }
            //秋を消す処理
            if (pictureBox17.Visible == true)
            {
                pictureBox4.Image = motogaaki;

                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;

            }
            //冬を消す処理
            if (pictureBox20.Visible == true)
            {
                pictureBox5.Image = motogahuyu;

                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;

            }

        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile("カレンダー表示_カーソル前.png");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "確定音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            sijidori2 = 0;
            sijidori3 = 0;
            //処理が終わったら止める
            timer1.Enabled = false;
            //まずは表示していたものを消す
            sijituki_haru.Visible = false;

            //指示鳥_最初のセリフを消す
            inko_koe1.Visible = false;

            //指示鳥_次のセリフを消す
            sijikare.Visible = false;
            inko_koe2.Visible = false;

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            sijidori_Visible = 0;



            //この処理のあとに次へ進めさせる
            Form2 form2 = new Form2(key, kisetu, sijidori_Visible,Myuto);
            form2.ShowDialog();
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sijidori_Visible == 0)
            {
                //非表示にする処理
                sijituki_haru.Visible = false;
                inko_koe1.Visible = false;

                sijikare.Visible = false;
                inko_koe2.Visible = false;
            }
            else
            {
                //最初の指示鳥表示
                if (sijidori2 == 1)
                {
                    sijituki_haru.Visible = true;
                    inko_koe1.Visible = true;


                }
                //最後のボタンへ案内する処理
                else if (sijidori3 == 1)
                {
                    //まずは表示していたものを消す
                    sijituki_haru.Visible = false;

                    //指示鳥_最初のセリフを消す
                    inko_koe1.Visible = false;

                    //指示鳥_次のセリフを表示させる
                    sijikare.Visible = true;
                    inko_koe2.Visible = true;

                }
                //全ての指示を見えなくする
                else
                {
                    //まずは表示していたものを消す
                    sijituki_haru.Visible = false;

                    //指示鳥_最初のセリフを消す
                    inko_koe1.Visible = false;

                    //指示鳥_次のセリフを消す
                    sijikare.Visible = false;
                    inko_koe2.Visible = false;

                }





            }



        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox8.Image = Image.FromFile("左選択ボタン2_1.png");
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {

            pictureBox8.Image = Image.FromFile("左選択ボタン2.png");
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox7.Image = Image.FromFile("右選択ボタン2_1.png");

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile("右選択ボタン2.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            pictureBox1.Image = Image.FromFile("閉じるボタン_選択後.png");
            syuuryousetu.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("閉じるボタン.png");
            syuuryousetu.Visible = false;
        }
        
        private void syousai_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "確定音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            if (pictureBox1.Visible == false)
            {
                syousai.Image = Image.FromFile("詳細ボタン_カーソル後.png");
                pictureBox1.Visible = true;
                Chuto_Visi.Visible = true;
                TaitoruBotan.Visible = true;
                On_pop.Visible = true;
                On_niti.Visible = true;
                On_nou.Visible = true;
                MyutoBtan.Visible = true;


            }
            else
            {
                syousai.Image = Image.FromFile("詳細ボタン.png");
                pictureBox1.Visible = false;
                Chuto_Visi.Visible = false;
                TaitoruBotan.Visible = false;
                On_pop.Visible = false;
                On_niti.Visible = false;
                On_nou.Visible = false;
                MyutoBtan.Visible = false;


            }
        }

        private void syousai_MouseEnter(object sender, EventArgs e)
        {

        }

        private void syousai_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Chuto_Visi_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();


            ChutoSetu.Visible = true;
        }

        private void Chuto_Visi_MouseLeave(object sender, EventArgs e)
        {
            ChutoSetu.Visible = false;

        }

        private void From1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //チュートリアルを保存しておく処理
            Properties.Settings.Default.Chutoriaru = sijidori_Visible;
            Properties.Settings.Default.Save();

        }

        private void Chuto_Visi_Click(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "確定音.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            if (sijidori_Visible == 1)
            {
                Chuto_Visi.Image = Image.FromFile("Ch_非表示.png");
                sijidori_Visible = 0;
            }
            else
            {
                Chuto_Visi.Image = Image.FromFile("Ch_表示.png");
                sijidori_Visible = 1;
            }
        }


        private void TaitoruBotan_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            Form3 form3 = new Form3(key, kisetu, sijidori_Visible, Myuto);
            form3.ShowDialog();
            this.Close();


        }

        private void TaitoruBotan_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            TaitoruBotan.Image = Image.FromFile("タイトルボタン_選択後.png");
            Taitorusetu.Visible = true;

        }

        private void TaitoruBotan_MouseLeave(object sender, EventArgs e)
        {
            TaitoruBotan.Image = Image.FromFile("タイトルボタン.png");
            Taitorusetu.Visible = false;

        }
        
        private void On_pop_Click(object sender, EventArgs e)
        {
            MyutoBtan.Image = Image.FromFile("ミュートボタン.png");
            Myuto = 1;


            axWindowsMediaPlayer1.URL = "PopHome.mp3";

            axWindowsMediaPlayer1.settings.setMode("loop", true);       //無限ループ
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void On_pop_MouseEnter(object sender, EventArgs e)
        {
            HomeOnsetu.Visible = true;
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

        }

        private void On_niti_Click(object sender, EventArgs e)
        {
            MyutoBtan.Image = Image.FromFile("ミュートボタン.png");
            Myuto = 1;


            axWindowsMediaPlayer1.URL = "IyasiHome.mp3";

            axWindowsMediaPlayer1.settings.setMode("loop", true);       //無限ループ
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void On_niti_MouseEnter(object sender, EventArgs e)
        {
            HomeOnsetu.Visible = true;
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();


        }

        private void On_nou_Click(object sender, EventArgs e)
        {
            MyutoBtan.Image = Image.FromFile("ミュートボタン.png");
            Myuto = 1;

            axWindowsMediaPlayer1.URL = "Sparrow_Land.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);       //無限ループ
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void On_nou_MouseEnter(object sender, EventArgs e)
        {
            HomeOnsetu.Visible = true;
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();


        }

        private void On_pop_MouseLeave(object sender, EventArgs e)
        {
            HomeOnsetu.Visible = false;

        }

        private void On_niti_MouseLeave(object sender, EventArgs e)
        {
            HomeOnsetu.Visible = false;

        }

        private void On_nou_MouseLeave(object sender, EventArgs e)
        {
            HomeOnsetu.Visible = false;

        }

        private void MyutoBtan_Click(object sender, EventArgs e)
        {
            //ボタン切り替え
            if (Myuto == 1)
            {
                //音がある状態ならば
                MyutoBtan.Image = Image.FromFile("ミュートボタン_ミュート後.png");
                Myuto = 0;
                axWindowsMediaPlayer1.settings.mute = true;
            }
            else
            {
                //音がない状態ならば
                MyutoBtan.Image = Image.FromFile("ミュートボタン.png");
                Myuto = 1;
                axWindowsMediaPlayer1.settings.mute = false;
                //音楽をシャッフルする下準備
                Random rnd = new System.Random();
                int kyoku_r = rnd.Next(3);

                //音楽を流す処理
                switch (kyoku_r)
                {
                    case 0:
                        axWindowsMediaPlayer1.URL = "Sparrow_Land.mp3";
                        break;
                    case 1:
                        axWindowsMediaPlayer1.URL = "PopHome.mp3";
                        break;
                    case 2:
                        axWindowsMediaPlayer1.URL = "IyasiHome.mp3";
                        break;

                }
                axWindowsMediaPlayer1.settings.setMode("loop", true);       //無限ループ
                axWindowsMediaPlayer1.Ctlcontrols.play();


            }
        }
        
        private void MyutoBtan_MouseEnter(object sender, EventArgs e)
        {
            //音
            axWindowsMediaPlayer2.URL = "カーソル移動2.mp3";
            axWindowsMediaPlayer2.Ctlcontrols.play();

            Myusetu.Visible = true;


        }

        private void MyutoBtan_MouseLeave(object sender, EventArgs e)
        {
            Myusetu.Visible = false;

        }
    }
}
