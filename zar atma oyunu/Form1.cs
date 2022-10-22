using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zar_atma_oyunu
{
    public partial class Form1 : Form
    {
        public String nicknameOne;
        public String nicknameTwo;
        int scoreOne = 0, scoreTwo = 0;
        int zarOneValue, zarTwoValue;
        int sayac = 0;
        bool isTimerStop = false;
        bool isKOneWin = false;
        bool isKTwoWin = false;
        bool draw = false;
        int gameOfPlayed = 0;
        String incomingValue;


        public Form1()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#acbed1");
            int zar1baslangic, zar2baslangic;
            Random random = new Random();
            zar1baslangic = random.Next(0, 6);
            zar2baslangic = random.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[zar1baslangic];
            pictureBox2.Image = ımageList1.Images[zar2baslangic];
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");//textlerin rengini değiştiricem
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
            label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
            button1.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#acbed1");
            button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#e9d5cf");
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#c7b8ac"); //burası 1 satır ustteki kod renginin biraz daha kalın rengi
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("");
            nameone.Text = nicknameOne;
            nametwo.Text = nicknameTwo;
            keepOfScore.BackColor = System.Drawing.ColorTranslator.FromHtml("#acbed1");
            keepOfScore.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int zar1,zar2;
            Random random = new Random();
            zar1 = random.Next(0, 6);
            zar2 = random.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[zar1];
            pictureBox2.Image = ımageList1.Images[zar2];
            sayac++;
            int zarsüresi = 16;
            if(sayac == zarsüresi)
            {
                isTimerStop = true;
                timer1.Stop();
                zarOneValue = zar1;
                zarTwoValue = zar2;
                sayac = 0;
                button1.Enabled = true; //butona basıp basmamayı kontrol ediyor
            }
            if(isTimerStop == true)
            {
                Score(zarOneValue, zarTwoValue);
                skorone.Text = scoreOne.ToString();
                skortwo.Text = scoreTwo.ToString();
                isTimerStop=false;

                //buraya da listboxa skoru yazdırıyorum geçmişte kim kazanmış vs onunla alakalı şeyleri!
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gameOfPlayed = 0;
            scoreOne = 0;
            scoreTwo = 0;
            
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Score(int zar1,int zar2)
        {
            Functions functions = new Functions();
            if(zar1 > zar2)
            {
                isKOneWin = true;
                scoreOne++;
                draw = false;
                isKTwoWin = false;
            }
            else if(zar1 == zar2)
            { 
                scoreOne += 0;scoreTwo += 0;
                draw = true;
                isKOneWin = false;
                isKTwoWin = false;
            }
            else
            {
                isKTwoWin = true;
                scoreTwo++;
                isKOneWin = false;
                draw = false;
            }
            gameOfPlayed++;
            //metodu burda cagırırm
            incomingValue = functions.ListBoxData(isKOneWin,isKTwoWin,draw,gameOfPlayed,nicknameOne,nicknameTwo);
            keepOfScore.Items.Add(incomingValue);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions functions = new Functions();
            functions.AppClose(e);
        }
    }
}

