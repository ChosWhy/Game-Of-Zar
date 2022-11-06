using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zar_atma_oyunu
{
    internal class FunctionOfZar
    {
        public String nicknameOne;
        public String nicknameTwo;
        public int scoreOne = 0, scoreTwo = 0;
        int zarOneValue, zarTwoValue;
        int sayac = 0;
        bool isTimerStop = false;
        bool isKOneWin = false;
        bool isKTwoWin = false;
        bool draw = false;
        public int gameOfPlayed = 0;
        String incomingValue;
        public void SetNames(string nicknameOne, string nicknameTwo)
        {
            this.nicknameOne = nicknameOne;
            this.nicknameTwo = nicknameTwo;
        }
        public void FunctionOfTimerone(PictureBox picone, PictureBox pictwo, ImageList imglist,Timer timer1,Button button1,Label skorone, Label skortwo, ListBox keepOfScore)
        {
            int zar1, zar2;
            Random random = new Random();
            zar1 = random.Next(0, 6);
            zar2 = random.Next(0, 6);
            picone.Image = imglist.Images[zar1];
            pictwo.Image = imglist.Images[zar2];
            sayac++;
            int zarsüresi = 16;
            if (sayac == zarsüresi)
            {
                isTimerStop = true;
                timer1.Stop();
                zarOneValue = zar1;
                zarTwoValue = zar2;
                sayac = 0;
                button1.Enabled = true; //butona basıp basmamayı kontrol ediyor
            }
            if (isTimerStop == true)
            {
                Score(zarOneValue, zarTwoValue, keepOfScore);
                skorone.Text = scoreOne.ToString();
                skortwo.Text = scoreTwo.ToString();
                isTimerStop = false;

                //buraya da listboxa skoru yazdırıyorum geçmişte kim kazanmış vs onunla alakalı şeyleri!
            }
        }
        public void Score(int zar1, int zar2,ListBox keepOfScore)
        {
            Functions functions = new Functions();
            if (zar1 > zar2)
            {
                isKOneWin = true;
                scoreOne++;
                draw = false;
                isKTwoWin = false;
            }
            else if (zar1 == zar2)
            {
                scoreOne += 0; scoreTwo += 0;
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
            incomingValue = functions.ListBoxData(isKOneWin, isKTwoWin, draw, gameOfPlayed, nicknameOne, nicknameTwo);
            keepOfScore.Items.Add(incomingValue);
        }
    }
}
