namespace zar_atma_oyunu
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btn_back = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nametwo = new System.Windows.Forms.Label();
            this.skorone = new System.Windows.Forms.Label();
            this.skortwo = new System.Windows.Forms.Label();
            this.keepOfScore = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::zar_atma_oyunu.Properties.Resources.backıcon2;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(13, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "zar1.png");
            this.ımageList1.Images.SetKeyName(1, "zar2.jpg");
            this.ımageList1.Images.SetKeyName(2, "zar3.png");
            this.ımageList1.Images.SetKeyName(3, "zar4.png");
            this.ımageList1.Images.SetKeyName(4, "zar5.png");
            this.ımageList1.Images.SetKeyName(5, "zar6.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(134, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(588, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // nameone
            // 
            this.nameone.AutoSize = true;
            this.nameone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameone.Location = new System.Drawing.Point(202, 114);
            this.nameone.Name = "nameone";
            this.nameone.Size = new System.Drawing.Size(70, 25);
            this.nameone.TabIndex = 7;
            this.nameone.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(417, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zargana";
            // 
            // nametwo
            // 
            this.nametwo.AutoSize = true;
            this.nametwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nametwo.Location = new System.Drawing.Point(656, 114);
            this.nametwo.Name = "nametwo";
            this.nametwo.Size = new System.Drawing.Size(70, 25);
            this.nametwo.TabIndex = 9;
            this.nametwo.Text = "label4";
            // 
            // skorone
            // 
            this.skorone.AutoSize = true;
            this.skorone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorone.Location = new System.Drawing.Point(469, 148);
            this.skorone.Name = "skorone";
            this.skorone.Size = new System.Drawing.Size(24, 25);
            this.skorone.TabIndex = 10;
            this.skorone.Text = "0";
            // 
            // skortwo
            // 
            this.skortwo.AutoSize = true;
            this.skortwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skortwo.Location = new System.Drawing.Point(550, 148);
            this.skortwo.Name = "skortwo";
            this.skortwo.Size = new System.Drawing.Size(24, 25);
            this.skortwo.TabIndex = 11;
            this.skortwo.Text = "0";
            // 
            // keepOfScore
            // 
            this.keepOfScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.keepOfScore.FormattingEnabled = true;
            this.keepOfScore.ItemHeight = 16;
            this.keepOfScore.Location = new System.Drawing.Point(738, 433);
            this.keepOfScore.Name = "keepOfScore";
            this.keepOfScore.Size = new System.Drawing.Size(312, 228);
            this.keepOfScore.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(346, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rakibinizle zar atmaya başlayın.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(426, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 80);
            this.button1.TabIndex = 14;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keepOfScore);
            this.Controls.Add(this.skortwo);
            this.Controls.Add(this.skorone);
            this.Controls.Add(this.nametwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameone);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nametwo;
        private System.Windows.Forms.Label skorone;
        private System.Windows.Forms.Label skortwo;
        private System.Windows.Forms.ListBox keepOfScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}