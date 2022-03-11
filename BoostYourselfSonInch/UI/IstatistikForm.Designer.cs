
namespace BoostYourselfSonInch.UI
{
    partial class IstatistikForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudToplamKalori = new System.Windows.Forms.NumericUpDown();
            this.nudOgunlerinKalorisi = new System.Windows.Forms.NumericUpDown();
            this.cmbOgunler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAylik = new System.Windows.Forms.RadioButton();
            this.rbHaftalik = new System.Windows.Forms.RadioButton();
            this.cmbRaporKategoriler = new System.Windows.Forms.ComboBox();
            this.cmbOgunler2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTumKisilerOrtKcal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblKullaniciOrtKcal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOgunlerinYemekleri = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOgunler3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblKullaniciTopYemek = new System.Windows.Forms.Label();
            this.lblKullanicilarTopYemek = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToplamKalori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOgunlerinKalorisi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunlerinYemekleri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudToplamKalori);
            this.groupBox1.Controls.Add(this.nudOgunlerinKalorisi);
            this.groupBox1.Controls.Add(this.cmbOgunler);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Beige;
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gün Sonu Raporu";
            // 
            // nudToplamKalori
            // 
            this.nudToplamKalori.Location = new System.Drawing.Point(56, 294);
            this.nudToplamKalori.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudToplamKalori.Name = "nudToplamKalori";
            this.nudToplamKalori.Size = new System.Drawing.Size(120, 20);
            this.nudToplamKalori.TabIndex = 2;
            // 
            // nudOgunlerinKalorisi
            // 
            this.nudOgunlerinKalorisi.Location = new System.Drawing.Point(56, 177);
            this.nudOgunlerinKalorisi.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudOgunlerinKalorisi.Name = "nudOgunlerinKalorisi";
            this.nudOgunlerinKalorisi.Size = new System.Drawing.Size(120, 20);
            this.nudOgunlerinKalorisi.TabIndex = 2;
            // 
            // cmbOgunler
            // 
            this.cmbOgunler.FormattingEnabled = true;
            this.cmbOgunler.Location = new System.Drawing.Point(56, 72);
            this.cmbOgunler.Name = "cmbOgunler";
            this.cmbOgunler.Size = new System.Drawing.Size(121, 21);
            this.cmbOgunler.TabIndex = 1;
            this.cmbOgunler.SelectedIndexChanged += new System.EventHandler(this.cmbOgunler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(83, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(82, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Toplam \r\nKalori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(74, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğünlerin \r\nKalorisi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblKullanicilarTopYemek);
            this.groupBox2.Controls.Add(this.lblKullaniciTopYemek);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rbAylik);
            this.groupBox2.Controls.Add(this.rbHaftalik);
            this.groupBox2.Controls.Add(this.cmbRaporKategoriler);
            this.groupBox2.Controls.Add(this.cmbOgunler2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTumKisilerOrtKcal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblKullaniciOrtKcal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.Beige;
            this.groupBox2.Location = new System.Drawing.Point(265, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 396);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kıyas Raporu";
            // 
            // rbAylik
            // 
            this.rbAylik.AutoSize = true;
            this.rbAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAylik.ForeColor = System.Drawing.Color.Beige;
            this.rbAylik.Location = new System.Drawing.Point(354, 38);
            this.rbAylik.Name = "rbAylik";
            this.rbAylik.Size = new System.Drawing.Size(60, 21);
            this.rbAylik.TabIndex = 2;
            this.rbAylik.TabStop = true;
            this.rbAylik.Text = "Aylık";
            this.rbAylik.UseVisualStyleBackColor = true;
            this.rbAylik.CheckedChanged += new System.EventHandler(this.rbAylik_CheckedChanged);
            // 
            // rbHaftalik
            // 
            this.rbHaftalik.AutoSize = true;
            this.rbHaftalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbHaftalik.ForeColor = System.Drawing.Color.Beige;
            this.rbHaftalik.Location = new System.Drawing.Point(58, 38);
            this.rbHaftalik.Name = "rbHaftalik";
            this.rbHaftalik.Size = new System.Drawing.Size(81, 21);
            this.rbHaftalik.TabIndex = 2;
            this.rbHaftalik.TabStop = true;
            this.rbHaftalik.Text = "Haftalık";
            this.rbHaftalik.UseVisualStyleBackColor = true;
            this.rbHaftalik.CheckedChanged += new System.EventHandler(this.rbHaftalik_CheckedChanged);
            // 
            // cmbRaporKategoriler
            // 
            this.cmbRaporKategoriler.FormattingEnabled = true;
            this.cmbRaporKategoriler.Location = new System.Drawing.Point(354, 72);
            this.cmbRaporKategoriler.Name = "cmbRaporKategoriler";
            this.cmbRaporKategoriler.Size = new System.Drawing.Size(121, 21);
            this.cmbRaporKategoriler.TabIndex = 1;
            this.cmbRaporKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbRaporKategoriler_SelectedIndexChanged);
            // 
            // cmbOgunler2
            // 
            this.cmbOgunler2.FormattingEnabled = true;
            this.cmbOgunler2.Location = new System.Drawing.Point(117, 72);
            this.cmbOgunler2.Name = "cmbOgunler2";
            this.cmbOgunler2.Size = new System.Drawing.Size(121, 21);
            this.cmbOgunler2.TabIndex = 1;
            this.cmbOgunler2.SelectedIndexChanged += new System.EventHandler(this.cmbOgunler2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Beige;
            this.label6.Location = new System.Drawing.Point(258, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kategoriler";
            // 
            // lblTumKisilerOrtKcal
            // 
            this.lblTumKisilerOrtKcal.AutoSize = true;
            this.lblTumKisilerOrtKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTumKisilerOrtKcal.ForeColor = System.Drawing.Color.Beige;
            this.lblTumKisilerOrtKcal.Location = new System.Drawing.Point(351, 175);
            this.lblTumKisilerOrtKcal.Name = "lblTumKisilerOrtKcal";
            this.lblTumKisilerOrtKcal.Size = new System.Drawing.Size(53, 18);
            this.lblTumKisilerOrtKcal.TabIndex = 0;
            this.lblTumKisilerOrtKcal.Text = "0 kcal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Beige;
            this.label11.Location = new System.Drawing.Point(19, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ortalama Kalori :";
            // 
            // lblKullaniciOrtKcal
            // 
            this.lblKullaniciOrtKcal.AutoSize = true;
            this.lblKullaniciOrtKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciOrtKcal.ForeColor = System.Drawing.Color.Beige;
            this.lblKullaniciOrtKcal.Location = new System.Drawing.Point(171, 175);
            this.lblKullaniciOrtKcal.Name = "lblKullaniciOrtKcal";
            this.lblKullaniciOrtKcal.Size = new System.Drawing.Size(53, 18);
            this.lblKullaniciOrtKcal.TabIndex = 0;
            this.lblKullaniciOrtKcal.Text = "0 kcal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Beige;
            this.label8.Location = new System.Drawing.Point(351, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tüm Kişiler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Beige;
            this.label7.Location = new System.Drawing.Point(171, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kullanıcı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Beige;
            this.label5.Location = new System.Drawing.Point(31, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Öğünler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOgunlerinYemekleri);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbOgunler3);
            this.groupBox3.ForeColor = System.Drawing.Color.Beige;
            this.groupBox3.Location = new System.Drawing.Point(776, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 396);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yemek Çeşidi Raporu";
            // 
            // dgvOgunlerinYemekleri
            // 
            this.dgvOgunlerinYemekleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunlerinYemekleri.Location = new System.Drawing.Point(6, 67);
            this.dgvOgunlerinYemekleri.Name = "dgvOgunlerinYemekleri";
            this.dgvOgunlerinYemekleri.Size = new System.Drawing.Size(519, 323);
            this.dgvOgunlerinYemekleri.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Beige;
            this.label4.Location = new System.Drawing.Point(150, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Öğünler";
            // 
            // cmbOgunler3
            // 
            this.cmbOgunler3.FormattingEnabled = true;
            this.cmbOgunler3.Location = new System.Drawing.Point(279, 34);
            this.cmbOgunler3.Name = "cmbOgunler3";
            this.cmbOgunler3.Size = new System.Drawing.Size(121, 21);
            this.cmbOgunler3.TabIndex = 1;
            this.cmbOgunler3.SelectedIndexChanged += new System.EventHandler(this.cmbOgunler3_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Beige;
            this.label13.Location = new System.Drawing.Point(24, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "İstatistikler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Kullanıcının en çok yediği yemek:";
            // 
            // lblKullaniciTopYemek
            // 
            this.lblKullaniciTopYemek.AutoSize = true;
            this.lblKullaniciTopYemek.Location = new System.Drawing.Point(31, 294);
            this.lblKullaniciTopYemek.Name = "lblKullaniciTopYemek";
            this.lblKullaniciTopYemek.Size = new System.Drawing.Size(0, 13);
            this.lblKullaniciTopYemek.TabIndex = 3;
            // 
            // lblKullanicilarTopYemek
            // 
            this.lblKullanicilarTopYemek.AutoSize = true;
            this.lblKullanicilarTopYemek.Location = new System.Drawing.Point(362, 282);
            this.lblKullanicilarTopYemek.Name = "lblKullanicilarTopYemek";
            this.lblKullanicilarTopYemek.Size = new System.Drawing.Size(0, 13);
            this.lblKullanicilarTopYemek.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(258, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Kullanıcıların en çok yediği yemek:";
            // 
            // IstatistikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1319, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "IstatistikForm";
            this.Text = "IstatistikForm";
            this.Load += new System.EventHandler(this.IstatistikForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToplamKalori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOgunlerinKalorisi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunlerinYemekleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbOgunler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbRaporKategoriler;
        private System.Windows.Forms.ComboBox cmbOgunler2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOgunlerinYemekleri;
        private System.Windows.Forms.ComboBox cmbOgunler3;
        private System.Windows.Forms.NumericUpDown nudToplamKalori;
        private System.Windows.Forms.NumericUpDown nudOgunlerinKalorisi;
        private System.Windows.Forms.RadioButton rbAylik;
        private System.Windows.Forms.RadioButton rbHaftalik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTumKisilerOrtKcal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblKullaniciOrtKcal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblKullanicilarTopYemek;
        private System.Windows.Forms.Label lblKullaniciTopYemek;
        private System.Windows.Forms.Label label9;
    }
}