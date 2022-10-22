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
    public partial class Form3 : Form
    {
        int txtLenght = 15;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //bu kısım ise kullanıcılardan isimlerini girmeleri istenicek!
            lblInformation.BackColor = Color.Transparent;
            lblInformation.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
            lblk1.BackColor = Color.Transparent;
            lblk2.BackColor = Color.Transparent;
            lblk1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
            lblk2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
            lbluyari1.BackColor = Color.Transparent;
            lbluyari2.BackColor = Color.Transparent;
            lbluyari1.ForeColor = Color.Red;
            lbluyari2.ForeColor = Color.Red;
            lbluyari1.Visible = false;
            lbluyari2.Visible = false;

            btnGiris.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#393b3a");
            btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#4f4f4f");

            btnBack.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#5c5c5c");
            btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#a2a4a3");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();

            //burada verileri göndericez
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions functions = new Functions();
            functions.AppClose(e);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtbxkullaniciadione.TextLength > 0 && txtbxkullaniciaditwo.TextLength > 0)
            {
                if (txtbxkullaniciadione.TextLength < txtLenght && txtbxkullaniciaditwo.TextLength < txtLenght)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.nicknameOne = txtbxkullaniciadione.Text;
                    form1.nicknameTwo = txtbxkullaniciaditwo.Text;
                    form1.Show();
                }
                else if (txtbxkullaniciaditwo.TextLength >= txtLenght && txtbxkullaniciaditwo.TextLength >= txtLenght)
                {
                    lbluyari1.Text = "Daha kısa kullanıcı adı seçin!";
                    lbluyari2.Text = "Daha kısa kullanıcı adı seçin!";
                    lbluyari1.Visible = true;
                    lbluyari2.Visible = true;
                }
                else if (txtbxkullaniciaditwo.TextLength >= txtLenght && txtbxkullaniciadione.TextLength < txtLenght)
                {
                    lbluyari1.Visible = false;
                    lbluyari2.Text = "Daha kısa kullanıcı adı seçin!";
                    lbluyari2.Visible = true;
                }
                else if (txtbxkullaniciaditwo.TextLength < txtLenght && txtbxkullaniciadione.TextLength >= txtLenght)
                {
                    lbluyari2.Visible = false;
                    lbluyari1.Text = "Daha kısa kullanıcı adı seçin!";
                    lbluyari1.Visible = true;
                }
            }
            else if (txtbxkullaniciadione.TextLength == 0 && txtbxkullaniciaditwo.TextLength == 0)
            {
                lbluyari1.Text = "kullanıcı adı boş bırakılamaz!";
                lbluyari2.Text = "kullanıcı adı boş bırakılamaz!";
                lbluyari1.Visible = true;
                lbluyari2.Visible = true;
            }
            else if (txtbxkullaniciadione.TextLength == 0 && txtbxkullaniciaditwo.TextLength != 0)
            {
                lbluyari1.Text = "kullanıcı adı boş bırakılamaz!";
                lbluyari1.Visible = true;
            }
            else if (txtbxkullaniciadione.TextLength != 0 && txtbxkullaniciaditwo.TextLength == 0)
            {
                lbluyari2.Text = "kullanıcı adı boş bırakılamaz!";
                lbluyari2.Visible = true;
            }
        }
    }
}



//bir bug olarabilir o da su simdi ben isimleri girdikten sonra form3 e geçiyorum verilerin sıfırlanması gerekli yoksa devam eder
//birde isim değişikliginde de sıfırlanması gerekli!