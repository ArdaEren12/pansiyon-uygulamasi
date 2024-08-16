namespace pansiyon_kayıt_uygulaması
{
    partial class FrmYeniMusteri
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
            this.GbMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeCikis = new System.Windows.Forms.DateTimePicker();
            this.dateTimeGiris = new System.Windows.Forms.DateTimePicker();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOdalar = new System.Windows.Forms.GroupBox();
            this.btnDolu = new System.Windows.Forms.Button();
            this.btnBos = new System.Windows.Forms.Button();
            this.btn303 = new System.Windows.Forms.Button();
            this.btn302 = new System.Windows.Forms.Button();
            this.btn301 = new System.Windows.Forms.Button();
            this.btn203 = new System.Windows.Forms.Button();
            this.btn202 = new System.Windows.Forms.Button();
            this.btn201 = new System.Windows.Forms.Button();
            this.btn103 = new System.Windows.Forms.Button();
            this.btn102 = new System.Windows.Forms.Button();
            this.btn101 = new System.Windows.Forms.Button();
            this.GbMusteriBilgileri.SuspendLayout();
            this.gbOdalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbMusteriBilgileri
            // 
            this.GbMusteriBilgileri.Controls.Add(this.label11);
            this.GbMusteriBilgileri.Controls.Add(this.cbCinsiyet);
            this.GbMusteriBilgileri.Controls.Add(this.label10);
            this.GbMusteriBilgileri.Controls.Add(this.maskedTextBoxTelefon);
            this.GbMusteriBilgileri.Controls.Add(this.btnKaydet);
            this.GbMusteriBilgileri.Controls.Add(this.txtUcret);
            this.GbMusteriBilgileri.Controls.Add(this.label9);
            this.GbMusteriBilgileri.Controls.Add(this.dateTimeCikis);
            this.GbMusteriBilgileri.Controls.Add(this.dateTimeGiris);
            this.GbMusteriBilgileri.Controls.Add(this.txtOdaNo);
            this.GbMusteriBilgileri.Controls.Add(this.txtTcNo);
            this.GbMusteriBilgileri.Controls.Add(this.txtMail);
            this.GbMusteriBilgileri.Controls.Add(this.txtSoyad);
            this.GbMusteriBilgileri.Controls.Add(this.txtAd);
            this.GbMusteriBilgileri.Controls.Add(this.label8);
            this.GbMusteriBilgileri.Controls.Add(this.label7);
            this.GbMusteriBilgileri.Controls.Add(this.label6);
            this.GbMusteriBilgileri.Controls.Add(this.label5);
            this.GbMusteriBilgileri.Controls.Add(this.label4);
            this.GbMusteriBilgileri.Controls.Add(this.label3);
            this.GbMusteriBilgileri.Controls.Add(this.label2);
            this.GbMusteriBilgileri.Controls.Add(this.label1);
            this.GbMusteriBilgileri.Location = new System.Drawing.Point(23, 21);
            this.GbMusteriBilgileri.Name = "GbMusteriBilgileri";
            this.GbMusteriBilgileri.Size = new System.Drawing.Size(351, 387);
            this.GbMusteriBilgileri.TabIndex = 0;
            this.GbMusteriBilgileri.TabStop = false;
            this.GbMusteriBilgileri.Text = "Müşteri Bilgileri";
            this.GbMusteriBilgileri.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(294, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 2;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cbCinsiyet.Location = new System.Drawing.Point(123, 101);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(121, 24);
            this.cbCinsiyet.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(40, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cinsiyet :";
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(125, 80);
            this.maskedTextBoxTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTelefon.TabIndex = 18;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(67, 306);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(166, 33);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(125, 278);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(171, 22);
            this.txtUcret.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(52, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "ÜCRET :";
            // 
            // dateTimeCikis
            // 
            this.dateTimeCikis.Location = new System.Drawing.Point(125, 250);
            this.dateTimeCikis.Name = "dateTimeCikis";
            this.dateTimeCikis.Size = new System.Drawing.Size(200, 22);
            this.dateTimeCikis.TabIndex = 14;
            this.dateTimeCikis.ValueChanged += new System.EventHandler(this.dateTimeCikis_ValueChanged);
            // 
            // dateTimeGiris
            // 
            this.dateTimeGiris.Location = new System.Drawing.Point(125, 218);
            this.dateTimeGiris.Name = "dateTimeGiris";
            this.dateTimeGiris.Size = new System.Drawing.Size(200, 22);
            this.dateTimeGiris.TabIndex = 13;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Enabled = false;
            this.txtOdaNo.Location = new System.Drawing.Point(125, 190);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(200, 22);
            this.txtOdaNo.TabIndex = 12;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(125, 159);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(200, 22);
            this.txtTcNo.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(125, 131);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 22);
            this.txtMail.TabIndex = 10;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(125, 53);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(171, 22);
            this.txtSoyad.TabIndex = 9;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(125, 25);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(171, 22);
            this.txtAd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(7, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "CIKIŞ TARİHİ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "GİRİŞ TARİHİ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(40, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "ODA NO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(-2, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "TC KİMLİK NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "MAİL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFON  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // gbOdalar
            // 
            this.gbOdalar.Controls.Add(this.btnDolu);
            this.gbOdalar.Controls.Add(this.btnBos);
            this.gbOdalar.Controls.Add(this.btn303);
            this.gbOdalar.Controls.Add(this.btn302);
            this.gbOdalar.Controls.Add(this.btn301);
            this.gbOdalar.Controls.Add(this.btn203);
            this.gbOdalar.Controls.Add(this.btn202);
            this.gbOdalar.Controls.Add(this.btn201);
            this.gbOdalar.Controls.Add(this.btn103);
            this.gbOdalar.Controls.Add(this.btn102);
            this.gbOdalar.Controls.Add(this.btn101);
            this.gbOdalar.Location = new System.Drawing.Point(389, 21);
            this.gbOdalar.Name = "gbOdalar";
            this.gbOdalar.Size = new System.Drawing.Size(391, 387);
            this.gbOdalar.TabIndex = 1;
            this.gbOdalar.TabStop = false;
            this.gbOdalar.Text = "Odalar";
            // 
            // btnDolu
            // 
            this.btnDolu.BackColor = System.Drawing.Color.Red;
            this.btnDolu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDolu.Location = new System.Drawing.Point(198, 283);
            this.btnDolu.Name = "btnDolu";
            this.btnDolu.Size = new System.Drawing.Size(122, 56);
            this.btnDolu.TabIndex = 10;
            this.btnDolu.Text = "DOLU";
            this.btnDolu.UseVisualStyleBackColor = false;
            this.btnDolu.Click += new System.EventHandler(this.btnDolu_Click);
            // 
            // btnBos
            // 
            this.btnBos.BackColor = System.Drawing.Color.Lime;
            this.btnBos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBos.Location = new System.Drawing.Point(72, 283);
            this.btnBos.Name = "btnBos";
            this.btnBos.Size = new System.Drawing.Size(120, 56);
            this.btnBos.TabIndex = 9;
            this.btnBos.Text = "BOŞ";
            this.btnBos.UseVisualStyleBackColor = false;
            this.btnBos.Click += new System.EventHandler(this.btnBos_Click);
            // 
            // btn303
            // 
            this.btn303.BackColor = System.Drawing.Color.Lime;
            this.btn303.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn303.Location = new System.Drawing.Point(269, 192);
            this.btn303.Name = "btn303";
            this.btn303.Size = new System.Drawing.Size(76, 56);
            this.btn303.TabIndex = 8;
            this.btn303.Text = "303";
            this.btn303.UseVisualStyleBackColor = false;
            this.btn303.Click += new System.EventHandler(this.btn303_Click);
            // 
            // btn302
            // 
            this.btn302.BackColor = System.Drawing.Color.Lime;
            this.btn302.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn302.Location = new System.Drawing.Point(157, 192);
            this.btn302.Name = "btn302";
            this.btn302.Size = new System.Drawing.Size(76, 56);
            this.btn302.TabIndex = 7;
            this.btn302.Text = "302";
            this.btn302.UseVisualStyleBackColor = false;
            this.btn302.Click += new System.EventHandler(this.btn302_Click);
            // 
            // btn301
            // 
            this.btn301.BackColor = System.Drawing.Color.Lime;
            this.btn301.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn301.Location = new System.Drawing.Point(35, 192);
            this.btn301.Name = "btn301";
            this.btn301.Size = new System.Drawing.Size(76, 56);
            this.btn301.TabIndex = 6;
            this.btn301.Text = "301";
            this.btn301.UseVisualStyleBackColor = false;
            this.btn301.Click += new System.EventHandler(this.btn301_Click);
            // 
            // btn203
            // 
            this.btn203.BackColor = System.Drawing.Color.Lime;
            this.btn203.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn203.Location = new System.Drawing.Point(269, 109);
            this.btn203.Name = "btn203";
            this.btn203.Size = new System.Drawing.Size(76, 56);
            this.btn203.TabIndex = 5;
            this.btn203.Text = "203";
            this.btn203.UseVisualStyleBackColor = false;
            this.btn203.Click += new System.EventHandler(this.btn203_Click);
            // 
            // btn202
            // 
            this.btn202.BackColor = System.Drawing.Color.Lime;
            this.btn202.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn202.Location = new System.Drawing.Point(157, 109);
            this.btn202.Name = "btn202";
            this.btn202.Size = new System.Drawing.Size(76, 56);
            this.btn202.TabIndex = 4;
            this.btn202.Text = "202";
            this.btn202.UseVisualStyleBackColor = false;
            this.btn202.Click += new System.EventHandler(this.btn202_Click);
            // 
            // btn201
            // 
            this.btn201.BackColor = System.Drawing.Color.Lime;
            this.btn201.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn201.Location = new System.Drawing.Point(35, 109);
            this.btn201.Name = "btn201";
            this.btn201.Size = new System.Drawing.Size(76, 56);
            this.btn201.TabIndex = 3;
            this.btn201.Text = "201";
            this.btn201.UseVisualStyleBackColor = false;
            this.btn201.Click += new System.EventHandler(this.btn201_Click);
            // 
            // btn103
            // 
            this.btn103.BackColor = System.Drawing.Color.Lime;
            this.btn103.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn103.Location = new System.Drawing.Point(269, 31);
            this.btn103.Name = "btn103";
            this.btn103.Size = new System.Drawing.Size(76, 56);
            this.btn103.TabIndex = 2;
            this.btn103.Text = "103";
            this.btn103.UseVisualStyleBackColor = false;
            this.btn103.Click += new System.EventHandler(this.btn103_Click);
            // 
            // btn102
            // 
            this.btn102.BackColor = System.Drawing.Color.Lime;
            this.btn102.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn102.Location = new System.Drawing.Point(157, 33);
            this.btn102.Name = "btn102";
            this.btn102.Size = new System.Drawing.Size(76, 56);
            this.btn102.TabIndex = 1;
            this.btn102.Text = "102";
            this.btn102.UseVisualStyleBackColor = false;
            this.btn102.Click += new System.EventHandler(this.btn102_Click);
            // 
            // btn101
            // 
            this.btn101.BackColor = System.Drawing.Color.Lime;
            this.btn101.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn101.Location = new System.Drawing.Point(35, 33);
            this.btn101.Name = "btn101";
            this.btn101.Size = new System.Drawing.Size(76, 56);
            this.btn101.TabIndex = 0;
            this.btn101.Text = "101";
            this.btn101.UseVisualStyleBackColor = false;
            this.btn101.Click += new System.EventHandler(this.btn101_Click);
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(860, 506);
            this.Controls.Add(this.gbOdalar);
            this.Controls.Add(this.GbMusteriBilgileri);
            this.Name = "FrmYeniMusteri";
            this.Text = "yeni müsteri ekle ";
            this.Load += new System.EventHandler(this.FrmYeniMusteri_Load);
            this.GbMusteriBilgileri.ResumeLayout(false);
            this.GbMusteriBilgileri.PerformLayout();
            this.gbOdalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbMusteriBilgileri;
        private System.Windows.Forms.GroupBox gbOdalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeCikis;
        private System.Windows.Forms.DateTimePicker dateTimeGiris;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btn303;
        private System.Windows.Forms.Button btn302;
        private System.Windows.Forms.Button btn301;
        private System.Windows.Forms.Button btn203;
        private System.Windows.Forms.Button btn202;
        private System.Windows.Forms.Button btn201;
        private System.Windows.Forms.Button btn103;
        private System.Windows.Forms.Button btn102;
        private System.Windows.Forms.Button btn101;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.Button btnDolu;
        private System.Windows.Forms.Button btnBos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Label label11;
    }
}