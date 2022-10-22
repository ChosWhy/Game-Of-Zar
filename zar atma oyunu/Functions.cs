using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zar_atma_oyunu
{
    class Functions
    {
        String kOneWon, kTwoWon, koneAndKtwoDraw;
        public void AppClose(FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }
        public String ListBoxData(bool isKOneWin,bool isKTwoWin,bool isDraw,int gameOfPlayed,String nicknameOne, String nicknameTwo)
        {
            kOneWon = gameOfPlayed.ToString() + ". oyunu kazanan :" + nicknameOne;
            kTwoWon = gameOfPlayed.ToString() + ". oyunu kazanan :" + nicknameTwo;
            koneAndKtwoDraw = gameOfPlayed.ToString() + ". oyun berabere bitti.";
            if (isKOneWin == true)
                return kOneWon;
            if(isKTwoWin == true)
                return kTwoWon;
            else
                return koneAndKtwoDraw;
        }
    }
}
