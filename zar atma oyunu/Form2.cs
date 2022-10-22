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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#cfc4c8"); //arkaplan
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#c3481f");
            cokOyunculubtn.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#cfc4c8");
            cokOyunculubtn.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#5990dd");
            cokOyunculubtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#b7c7e6");

            tekOyunculuBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#b7c7e6");
            tekOyunculuBtn.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#cfc4c8");
            tekOyunculuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#5990dd");

            exitBtn.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#cfc4c8");

            settingBtn.BackColor = System.Drawing.ColorTranslator.FromHtml("#b7c7e6");
            settingBtn.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#cfc4c8");
            settingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#5990dd");
        }

        private void cokOyunculubtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions functions = new Functions();
            functions.AppClose(e);
        }


        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            exitBtn.BackgroundImage = Properties.Resources.exit_sign_12;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackgroundImage= Properties.Resources.exit_sign_11;
        }

        private void settingBtn_MouseHover(object sender, EventArgs e)
        {
            settingBtn.BackgroundImage = Properties.Resources.settings2;
        }

        private void settingBtn_MouseLeave(object sender, EventArgs e)
        {
            settingBtn.BackgroundImage = Properties.Resources.settings3;
        }



        private void tekOyunculuBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geçici bir süre tek oyunculu seçeneğimiz kapalıdır!", "Bilgilendirme Penceresi");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

//öncelikle tek ve çok oyunculu seçme butonları olcuak 
//sesi aç ve kapa butonu oluca
//belki ayarlar butonu ekliyebilirim!