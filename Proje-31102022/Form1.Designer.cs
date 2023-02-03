namespace Proje_31102022
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tckimlikno = new System.Windows.Forms.MaskedTextBox();
            this.adisoyadi = new System.Windows.Forms.TextBox();
            this.yas = new System.Windows.Forms.TextBox();
            this.mezuniyet = new System.Windows.Forms.ComboBox();
            this.bay = new System.Windows.Forms.RadioButton();
            this.bayan = new System.Windows.Forms.RadioButton();
            this.il = new System.Windows.Forms.ComboBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsilc = new System.Windows.Forms.Button();
            this.buttonsiln = new System.Windows.Forms.Button();
            this.buttontumsil = new System.Windows.Forms.Button();
            this.buttonyeni = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.kayitsayisi = new System.Windows.Forms.Label();
            this.buttonara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_cinsiyet = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(65, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(29, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mezuniyet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(356, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doğum Yeri :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(358, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefon No :";
            // 
            // tckimlikno
            // 
            this.tckimlikno.Location = new System.Drawing.Point(107, 10);
            this.tckimlikno.Mask = "00000000000";
            this.tckimlikno.Name = "tckimlikno";
            this.tckimlikno.Size = new System.Drawing.Size(121, 20);
            this.tckimlikno.TabIndex = 7;
            this.tckimlikno.ValidatingType = typeof(int);
            // 
            // adisoyadi
            // 
            this.adisoyadi.Location = new System.Drawing.Point(107, 51);
            this.adisoyadi.Name = "adisoyadi";
            this.adisoyadi.Size = new System.Drawing.Size(121, 20);
            this.adisoyadi.TabIndex = 8;
            // 
            // yas
            // 
            this.yas.Location = new System.Drawing.Point(107, 92);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(121, 20);
            this.yas.TabIndex = 9;
            // 
            // mezuniyet
            // 
            this.mezuniyet.FormattingEnabled = true;
            this.mezuniyet.Items.AddRange(new object[] {
            "İlköğretim",
            "Ortaöğretim",
            "Lise",
            "Lisans",
            "Yüksek Lisans",
            "Doktora"});
            this.mezuniyet.Location = new System.Drawing.Point(107, 137);
            this.mezuniyet.Name = "mezuniyet";
            this.mezuniyet.Size = new System.Drawing.Size(121, 21);
            this.mezuniyet.TabIndex = 10;
            // 
            // bay
            // 
            this.bay.AutoSize = true;
            this.bay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bay.Location = new System.Drawing.Point(453, 35);
            this.bay.Name = "bay";
            this.bay.Size = new System.Drawing.Size(46, 17);
            this.bay.TabIndex = 11;
            this.bay.TabStop = true;
            this.bay.Text = "Bay";
            this.bay.UseVisualStyleBackColor = true;
            // 
            // bayan
            // 
            this.bayan.AutoSize = true;
            this.bayan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.bayan.Location = new System.Drawing.Point(505, 35);
            this.bayan.Name = "bayan";
            this.bayan.Size = new System.Drawing.Size(60, 17);
            this.bayan.TabIndex = 12;
            this.bayan.TabStop = true;
            this.bayan.Text = "Bayan";
            this.bayan.UseVisualStyleBackColor = true;
            // 
            // il
            // 
            this.il.FormattingEnabled = true;
            this.il.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "MERSİN",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ (İZMİT)",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA (ADAPAZARI)",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.il.Location = new System.Drawing.Point(442, 79);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(121, 21);
            this.il.TabIndex = 13;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(442, 136);
            this.telefon.Mask = "(999) 000-00-00";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(121, 20);
            this.telefon.TabIndex = 15;
            // 
            // buttonekle
            // 
            this.buttonekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonekle.Location = new System.Drawing.Point(16, 189);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(75, 23);
            this.buttonekle.TabIndex = 16;
            this.buttonekle.Text = "EKLE";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonsilc
            // 
            this.buttonsilc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonsilc.Location = new System.Drawing.Point(97, 189);
            this.buttonsilc.Name = "buttonsilc";
            this.buttonsilc.Size = new System.Drawing.Size(116, 23);
            this.buttonsilc.TabIndex = 16;
            this.buttonsilc.Text = "SİL (CHECKBOX)";
            this.buttonsilc.UseVisualStyleBackColor = true;
            this.buttonsilc.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonsiln
            // 
            this.buttonsiln.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonsiln.Location = new System.Drawing.Point(219, 189);
            this.buttonsiln.Name = "buttonsiln";
            this.buttonsiln.Size = new System.Drawing.Size(149, 23);
            this.buttonsiln.TabIndex = 16;
            this.buttonsiln.Text = "SİL (NORMAL SEÇİM)";
            this.buttonsiln.UseVisualStyleBackColor = true;
            this.buttonsiln.Click += new System.EventHandler(this.buttonsiln_Click);
            // 
            // buttontumsil
            // 
            this.buttontumsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttontumsil.Location = new System.Drawing.Point(374, 189);
            this.buttontumsil.Name = "buttontumsil";
            this.buttontumsil.Size = new System.Drawing.Size(97, 23);
            this.buttontumsil.TabIndex = 16;
            this.buttontumsil.Text = "TÜMÜNÜ SİL";
            this.buttontumsil.UseVisualStyleBackColor = true;
            this.buttontumsil.Click += new System.EventHandler(this.buttontumsil_Click);
            // 
            // buttonyeni
            // 
            this.buttonyeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonyeni.Location = new System.Drawing.Point(477, 189);
            this.buttonyeni.Name = "buttonyeni";
            this.buttonyeni.Size = new System.Drawing.Size(86, 23);
            this.buttonyeni.TabIndex = 16;
            this.buttonyeni.Text = "YENİ KAYIT";
            this.buttonyeni.UseVisualStyleBackColor = true;
            this.buttonyeni.Click += new System.EventHandler(this.buttonyeni_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(578, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kayıt Sayısı :";
            // 
            // kayitsayisi
            // 
            this.kayitsayisi.AutoSize = true;
            this.kayitsayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.kayitsayisi.ForeColor = System.Drawing.Color.Maroon;
            this.kayitsayisi.Location = new System.Drawing.Point(665, 194);
            this.kayitsayisi.Name = "kayitsayisi";
            this.kayitsayisi.Size = new System.Drawing.Size(14, 13);
            this.kayitsayisi.TabIndex = 18;
            this.kayitsayisi.Text = "0";
            // 
            // buttonara
            // 
            this.buttonara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonara.Location = new System.Drawing.Point(246, 8);
            this.buttonara.Name = "buttonara";
            this.buttonara.Size = new System.Drawing.Size(75, 23);
            this.buttonara.TabIndex = 16;
            this.buttonara.Text = "ARA";
            this.buttonara.UseVisualStyleBackColor = true;
            this.buttonara.Click += new System.EventHandler(this.buttonara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 168);
            this.dataGridView1.TabIndex = 19;
            // 
            // groupBox_cinsiyet
            // 
            this.groupBox_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox_cinsiyet.Location = new System.Drawing.Point(361, 6);
            this.groupBox_cinsiyet.Name = "groupBox_cinsiyet";
            this.groupBox_cinsiyet.Size = new System.Drawing.Size(204, 67);
            this.groupBox_cinsiyet.TabIndex = 20;
            this.groupBox_cinsiyet.TabStop = false;
            this.groupBox_cinsiyet.Text = "Cinsiyet :";
            this.groupBox_cinsiyet.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kayitsayisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonara);
            this.Controls.Add(this.buttonyeni);
            this.Controls.Add(this.buttontumsil);
            this.Controls.Add(this.buttonsiln);
            this.Controls.Add(this.buttonsilc);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.il);
            this.Controls.Add(this.bayan);
            this.Controls.Add(this.bay);
            this.Controls.Add(this.mezuniyet);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.adisoyadi);
            this.Controls.Add(this.tckimlikno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_cinsiyet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tckimlikno;
        private System.Windows.Forms.TextBox adisoyadi;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.ComboBox mezuniyet;
        private System.Windows.Forms.RadioButton bay;
        private System.Windows.Forms.RadioButton bayan;
        private System.Windows.Forms.ComboBox il;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonsilc;
        private System.Windows.Forms.Button buttonsiln;
        private System.Windows.Forms.Button buttontumsil;
        private System.Windows.Forms.Button buttonyeni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label kayitsayisi;
        private System.Windows.Forms.Button buttonara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_cinsiyet;
    }
}

