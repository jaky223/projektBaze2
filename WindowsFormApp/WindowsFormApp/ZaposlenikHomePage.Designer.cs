namespace WindowsFormApp
{
    partial class ZaposlenikHomePage
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
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPrikazSvihClanova = new System.Windows.Forms.DataGridView();
            this.btnObrisiClana = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajOpomenu = new System.Windows.Forms.Button();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazSvihClanova)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.Location = new System.Drawing.Point(110, 221);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(111, 42);
            this.btnDodajClana.TabIndex = 0;
            this.btnDodajClana.Text = "Dodaj clana";
            this.btnDodajClana.UseVisualStyleBackColor = true;
            this.btnDodajClana.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(91, 29);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(159, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(91, 69);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(159, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(91, 147);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(159, 20);
            this.txtKorime.TabIndex = 4;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(91, 186);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(159, 20);
            this.txtLozinka.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDodajClana);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.txtLozinka);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtKorime);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 285);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje clana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum rodenja:";
            // 
            // dtpBox
            // 
            this.dtpBox.Location = new System.Drawing.Point(91, 111);
            this.dtpBox.Name = "dtpBox";
            this.dtpBox.Size = new System.Drawing.Size(159, 20);
            this.dtpBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Korime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lozinka:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPrikazSvihClanova);
            this.groupBox2.Location = new System.Drawing.Point(360, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 285);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prikaz svih clanova";
            // 
            // dgvPrikazSvihClanova
            // 
            this.dgvPrikazSvihClanova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazSvihClanova.Location = new System.Drawing.Point(6, 19);
            this.dgvPrikazSvihClanova.Name = "dgvPrikazSvihClanova";
            this.dgvPrikazSvihClanova.Size = new System.Drawing.Size(392, 234);
            this.dgvPrikazSvihClanova.TabIndex = 0;
            // 
            // btnObrisiClana
            // 
            this.btnObrisiClana.Location = new System.Drawing.Point(657, 334);
            this.btnObrisiClana.Name = "btnObrisiClana";
            this.btnObrisiClana.Size = new System.Drawing.Size(111, 42);
            this.btnObrisiClana.TabIndex = 13;
            this.btnObrisiClana.Text = "Obrisi clana";
            this.btnObrisiClana.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSadrzaj);
            this.groupBox3.Controls.Add(this.txtNaslov);
            this.groupBox3.Controls.Add(this.btnDodajOpomenu);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(795, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 285);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opomene";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(188, 106);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnDodajOpomenu
            // 
            this.btnDodajOpomenu.Location = new System.Drawing.Point(43, 222);
            this.btnDodajOpomenu.Name = "btnDodajOpomenu";
            this.btnDodajOpomenu.Size = new System.Drawing.Size(111, 42);
            this.btnDodajOpomenu.TabIndex = 15;
            this.btnDodajOpomenu.Text = "Dodaj opomenu";
            this.btnDodajOpomenu.UseVisualStyleBackColor = true;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(66, 135);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(128, 20);
            this.txtNaslov.TabIndex = 16;
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(66, 171);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(128, 45);
            this.txtSadrzaj.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Naslov:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sadrzaj:";
            // 
            // ZaposlenikHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnObrisiClana);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZaposlenikHomePage";
            this.Text = "ZaposlenikHomePage";
            this.Load += new System.EventHandler(this.ZaposlenikHomePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazSvihClanova)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPrikazSvihClanova;
        private System.Windows.Forms.Button btnObrisiClana;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnDodajOpomenu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}