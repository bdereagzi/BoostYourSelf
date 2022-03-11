
namespace BoostYourselfSonInch.UI
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbCikis = new System.Windows.Forms.Button();
            this.pbAyarlar = new System.Windows.Forms.Button();
            this.pbIstatistik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOgun = new System.Windows.Forms.ComboBox();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblKalori = new System.Windows.Forms.Label();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvBesinler = new System.Windows.Forms.DataGridView();
            this.btnYeniBesinEkle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOgunEkle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BesinId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YiyecekAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porsiyonlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kalorisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.OgunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlusturulmaZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ogunler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kalori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kullanıcı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).BeginInit();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbCikis);
            this.panel1.Controls.Add(this.pbAyarlar);
            this.panel1.Controls.Add(this.pbIstatistik);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 621);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(204, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 114);
            this.panel2.TabIndex = 5;
            // 
            // pbCikis
            // 
            this.pbCikis.BackColor = System.Drawing.Color.SlateGray;
            this.pbCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pbCikis.ForeColor = System.Drawing.Color.Black;
            this.pbCikis.Image = ((System.Drawing.Image)(resources.GetObject("pbCikis.Image")));
            this.pbCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pbCikis.Location = new System.Drawing.Point(0, 408);
            this.pbCikis.Name = "pbCikis";
            this.pbCikis.Size = new System.Drawing.Size(192, 64);
            this.pbCikis.TabIndex = 0;
            this.pbCikis.Text = "Çıkış";
            this.pbCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pbCikis.UseVisualStyleBackColor = false;
            this.pbCikis.Click += new System.EventHandler(this.pbCikis_Click);
            // 
            // pbAyarlar
            // 
            this.pbAyarlar.BackColor = System.Drawing.Color.SlateGray;
            this.pbAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pbAyarlar.ForeColor = System.Drawing.Color.Black;
            this.pbAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("pbAyarlar.Image")));
            this.pbAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pbAyarlar.Location = new System.Drawing.Point(0, 296);
            this.pbAyarlar.Name = "pbAyarlar";
            this.pbAyarlar.Size = new System.Drawing.Size(192, 64);
            this.pbAyarlar.TabIndex = 0;
            this.pbAyarlar.Text = "Ayarlar";
            this.pbAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pbAyarlar.UseVisualStyleBackColor = false;
            this.pbAyarlar.Click += new System.EventHandler(this.pbAyarlar_Click);
            // 
            // pbIstatistik
            // 
            this.pbIstatistik.BackColor = System.Drawing.Color.SlateGray;
            this.pbIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pbIstatistik.ForeColor = System.Drawing.Color.Black;
            this.pbIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("pbIstatistik.Image")));
            this.pbIstatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pbIstatistik.Location = new System.Drawing.Point(3, 182);
            this.pbIstatistik.Name = "pbIstatistik";
            this.pbIstatistik.Size = new System.Drawing.Size(192, 64);
            this.pbIstatistik.TabIndex = 0;
            this.pbIstatistik.Text = "İstatistikler";
            this.pbIstatistik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pbIstatistik.UseVisualStyleBackColor = false;
            this.pbIstatistik.Click += new System.EventHandler(this.pbIstatistik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(233, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategoriler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(233, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miktar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(233, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Aradığın Besini Bulamadın Mı?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(233, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kalori:";
            // 
            // cmbOgun
            // 
            this.cmbOgun.ForeColor = System.Drawing.Color.Black;
            this.cmbOgun.FormattingEnabled = true;
            this.cmbOgun.Location = new System.Drawing.Point(404, 123);
            this.cmbOgun.Name = "cmbOgun";
            this.cmbOgun.Size = new System.Drawing.Size(178, 21);
            this.cmbOgun.TabIndex = 2;
            // 
            // nudMiktar
            // 
            this.nudMiktar.ForeColor = System.Drawing.Color.Black;
            this.nudMiktar.Location = new System.Drawing.Point(404, 240);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(121, 20);
            this.nudMiktar.TabIndex = 3;
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalori.Location = new System.Drawing.Point(401, 290);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(37, 13);
            this.lblKalori.TabIndex = 1;
            this.lblKalori.Text = "0 kCal";
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.ForeColor = System.Drawing.Color.Black;
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(404, 180);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(178, 21);
            this.cmbKategoriler.TabIndex = 2;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgunId,
            this.OgunAdi,
            this.OlusturulmaZamani,
            this.Ogunler,
            this.Kalori,
            this.Kullanıcı});
            this.dataGridView1.Location = new System.Drawing.Point(214, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(426, 255);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // dgvBesinler
            // 
            this.dgvBesinler.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvBesinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBesinler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BesinId,
            this.YiyecekAdi,
            this.Miktar,
            this.Porsiyonlar,
            this.Kalorisi,
            this.KategoriId});
            this.dgvBesinler.Location = new System.Drawing.Point(668, 117);
            this.dgvBesinler.MultiSelect = false;
            this.dgvBesinler.Name = "dgvBesinler";
            this.dgvBesinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBesinler.Size = new System.Drawing.Size(582, 503);
            this.dgvBesinler.TabIndex = 4;
            // 
            // btnYeniBesinEkle
            // 
            this.btnYeniBesinEkle.BackColor = System.Drawing.Color.Black;
            this.btnYeniBesinEkle.ForeColor = System.Drawing.Color.Beige;
            this.btnYeniBesinEkle.Location = new System.Drawing.Point(505, 324);
            this.btnYeniBesinEkle.Name = "btnYeniBesinEkle";
            this.btnYeniBesinEkle.Size = new System.Drawing.Size(94, 35);
            this.btnYeniBesinEkle.TabIndex = 0;
            this.btnYeniBesinEkle.Text = "Besin Ekle";
            this.btnYeniBesinEkle.UseVisualStyleBackColor = false;
            this.btnYeniBesinEkle.Click += new System.EventHandler(this.btnYeniBesinEkle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(198, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 85);
            this.panel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(369, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "ANA SAYFA";
            // 
            // btnOgunEkle
            // 
            this.btnOgunEkle.BackColor = System.Drawing.Color.Black;
            this.btnOgunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgunEkle.ForeColor = System.Drawing.Color.Beige;
            this.btnOgunEkle.Location = new System.Drawing.Point(588, 199);
            this.btnOgunEkle.Name = "btnOgunEkle";
            this.btnOgunEkle.Size = new System.Drawing.Size(75, 106);
            this.btnOgunEkle.TabIndex = 0;
            this.btnOgunEkle.Text = "Ekle";
            this.btnOgunEkle.UseVisualStyleBackColor = false;
            this.btnOgunEkle.Click += new System.EventHandler(this.btnOgunEkle_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(665, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Besinler";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // BesinId
            // 
            this.BesinId.HeaderText = "BesinId";
            this.BesinId.Name = "BesinId";
            this.BesinId.Visible = false;
            // 
            // YiyecekAdi
            // 
            this.YiyecekAdi.HeaderText = "YiyecekAdi";
            this.YiyecekAdi.Name = "YiyecekAdi";
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // Porsiyonlar
            // 
            this.Porsiyonlar.HeaderText = "Porsiyonlar";
            this.Porsiyonlar.Name = "Porsiyonlar";
            // 
            // Kalorisi
            // 
            this.Kalorisi.HeaderText = "Kalorisi";
            this.Kalorisi.Name = "Kalorisi";
            // 
            // KategoriId
            // 
            this.KategoriId.HeaderText = "KategoriId";
            this.KategoriId.Name = "KategoriId";
            this.KategoriId.Visible = false;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(1050, 91);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 5;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // OgunId
            // 
            this.OgunId.HeaderText = "OgunId";
            this.OgunId.Name = "OgunId";
            this.OgunId.ReadOnly = true;
            this.OgunId.Visible = false;
            // 
            // OgunAdi
            // 
            this.OgunAdi.HeaderText = "OgunAdi";
            this.OgunAdi.Name = "OgunAdi";
            this.OgunAdi.ReadOnly = true;
            this.OgunAdi.Visible = false;
            // 
            // OlusturulmaZamani
            // 
            this.OlusturulmaZamani.HeaderText = "Tuketilen Tarih";
            this.OlusturulmaZamani.Name = "OlusturulmaZamani";
            this.OlusturulmaZamani.ReadOnly = true;
            // 
            // Ogunler
            // 
            this.Ogunler.HeaderText = "Ogunler";
            this.Ogunler.Name = "Ogunler";
            this.Ogunler.ReadOnly = true;
            // 
            // Kalori
            // 
            this.Kalori.HeaderText = "Kalori";
            this.Kalori.Name = "Kalori";
            this.Kalori.ReadOnly = true;
            // 
            // Kullanıcı
            // 
            this.Kullanıcı.HeaderText = "KullaniciId";
            this.Kullanıcı.Name = "Kullanıcı";
            this.Kullanıcı.ReadOnly = true;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1265, 618);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnOgunEkle);
            this.Controls.Add(this.btnYeniBesinEkle);
            this.Controls.Add(this.dgvBesinler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.cmbOgun);
            this.Controls.Add(this.lblKalori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pbIstatistik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOgun;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBesinler;
        private System.Windows.Forms.Button btnYeniBesinEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button pbCikis;
        private System.Windows.Forms.Button pbAyarlar;
        private System.Windows.Forms.Button btnOgunEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn BesinId;
        private System.Windows.Forms.DataGridViewTextBoxColumn YiyecekAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porsiyonlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kalorisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriId;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlusturulmaZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ogunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kalori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kullanıcı;
    }
}