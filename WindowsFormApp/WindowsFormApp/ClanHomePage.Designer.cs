namespace WindowsFormApp
{
    partial class ClanHomePage
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPromijeniPodatke = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNeposudeneKnjige = new System.Windows.Forms.DataGridView();
            this.dgvPosudeneKnjige = new System.Windows.Forms.DataGridView();
            this.btnPosudiKnjigu = new System.Windows.Forms.Button();
            this.btnVratiKnjigu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvOpomene = new System.Windows.Forms.DataGridView();
            this.btnDetaljiKnjige = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeposudeneKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudeneKnjige)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpomene)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPromijeniPodatke);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.txtLozinka);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtKorime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 285);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vasi podaci";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Korime:";
            // 
            // dtpBox
            // 
            this.dtpBox.Enabled = false;
            this.dtpBox.Location = new System.Drawing.Point(91, 111);
            this.dtpBox.Name = "dtpBox";
            this.dtpBox.Size = new System.Drawing.Size(159, 20);
            this.dtpBox.TabIndex = 10;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime:";
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
            // btnPromijeniPodatke
            // 
            this.btnPromijeniPodatke.Location = new System.Drawing.Point(110, 221);
            this.btnPromijeniPodatke.Name = "btnPromijeniPodatke";
            this.btnPromijeniPodatke.Size = new System.Drawing.Size(111, 42);
            this.btnPromijeniPodatke.TabIndex = 0;
            this.btnPromijeniPodatke.Text = "Promijeni podatke";
            this.btnPromijeniPodatke.UseVisualStyleBackColor = true;
            this.btnPromijeniPodatke.Click += new System.EventHandler(this.btnPromijeniPodatke_Click);
            // 
            // txtIme
            // 
            this.txtIme.Enabled = false;
            this.txtIme.Location = new System.Drawing.Point(91, 29);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(159, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(91, 186);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(159, 20);
            this.txtLozinka.TabIndex = 5;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Enabled = false;
            this.txtPrezime.Location = new System.Drawing.Point(91, 69);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(159, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtKorime
            // 
            this.txtKorime.Enabled = false;
            this.txtKorime.Location = new System.Drawing.Point(91, 147);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(159, 20);
            this.txtKorime.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNeposudeneKnjige);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 149);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neposudene knjige";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPosudeneKnjige);
            this.groupBox3.Location = new System.Drawing.Point(353, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 144);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vase posudene knjige";
            // 
            // dgvNeposudeneKnjige
            // 
            this.dgvNeposudeneKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNeposudeneKnjige.Location = new System.Drawing.Point(7, 20);
            this.dgvNeposudeneKnjige.Name = "dgvNeposudeneKnjige";
            this.dgvNeposudeneKnjige.Size = new System.Drawing.Size(376, 123);
            this.dgvNeposudeneKnjige.TabIndex = 0;
            // 
            // dgvPosudeneKnjige
            // 
            this.dgvPosudeneKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudeneKnjige.Location = new System.Drawing.Point(13, 19);
            this.dgvPosudeneKnjige.Name = "dgvPosudeneKnjige";
            this.dgvPosudeneKnjige.Size = new System.Drawing.Size(361, 104);
            this.dgvPosudeneKnjige.TabIndex = 1;
            // 
            // btnPosudiKnjigu
            // 
            this.btnPosudiKnjigu.Location = new System.Drawing.Point(431, 167);
            this.btnPosudiKnjigu.Name = "btnPosudiKnjigu";
            this.btnPosudiKnjigu.Size = new System.Drawing.Size(111, 42);
            this.btnPosudiKnjigu.TabIndex = 13;
            this.btnPosudiKnjigu.Text = "Posudi knjigu";
            this.btnPosudiKnjigu.UseVisualStyleBackColor = true;
            // 
            // btnVratiKnjigu
            // 
            this.btnVratiKnjigu.Location = new System.Drawing.Point(492, 383);
            this.btnVratiKnjigu.Name = "btnVratiKnjigu";
            this.btnVratiKnjigu.Size = new System.Drawing.Size(111, 42);
            this.btnVratiKnjigu.TabIndex = 14;
            this.btnVratiKnjigu.Text = "Vrati knjigu";
            this.btnVratiKnjigu.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvOpomene);
            this.groupBox4.Location = new System.Drawing.Point(13, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 121);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vase opomene";
            // 
            // dgvOpomene
            // 
            this.dgvOpomene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpomene.Location = new System.Drawing.Point(8, 20);
            this.dgvOpomene.Name = "dgvOpomene";
            this.dgvOpomene.Size = new System.Drawing.Size(296, 84);
            this.dgvOpomene.TabIndex = 0;
            // 
            // btnDetaljiKnjige
            // 
            this.btnDetaljiKnjige.Location = new System.Drawing.Point(548, 167);
            this.btnDetaljiKnjige.Name = "btnDetaljiKnjige";
            this.btnDetaljiKnjige.Size = new System.Drawing.Size(111, 42);
            this.btnDetaljiKnjige.TabIndex = 16;
            this.btnDetaljiKnjige.Text = "Detalji knjige";
            this.btnDetaljiKnjige.UseVisualStyleBackColor = true;
            // 
            // ClanHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetaljiKnjige);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnVratiKnjigu);
            this.Controls.Add(this.btnPosudiKnjigu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClanHomePage";
            this.Text = "ClanHomePage";
            this.Load += new System.EventHandler(this.ClanHomePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeposudeneKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudeneKnjige)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpomene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPromijeniPodatke;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNeposudeneKnjige;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPosudeneKnjige;
        private System.Windows.Forms.Button btnPosudiKnjigu;
        private System.Windows.Forms.Button btnVratiKnjigu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvOpomene;
        private System.Windows.Forms.Button btnDetaljiKnjige;
    }
}