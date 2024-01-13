namespace WindowsFormApp
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
            this.btnLoginZaposlenik = new System.Windows.Forms.Button();
            this.txtKorimeZaposlenik = new System.Windows.Forms.TextBox();
            this.txtLozinkaZaposlenik = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLozinkaClan = new System.Windows.Forms.TextBox();
            this.btnClanLogin = new System.Windows.Forms.Button();
            this.txtKorimeClan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoginZaposlenik
            // 
            this.btnLoginZaposlenik.Location = new System.Drawing.Point(72, 76);
            this.btnLoginZaposlenik.Name = "btnLoginZaposlenik";
            this.btnLoginZaposlenik.Size = new System.Drawing.Size(104, 43);
            this.btnLoginZaposlenik.TabIndex = 0;
            this.btnLoginZaposlenik.Text = "Zaposlenik login";
            this.btnLoginZaposlenik.UseVisualStyleBackColor = true;
            this.btnLoginZaposlenik.Click += new System.EventHandler(this.btnLoginZaposlenik_Click);
            // 
            // txtKorimeZaposlenik
            // 
            this.txtKorimeZaposlenik.Location = new System.Drawing.Point(52, 24);
            this.txtKorimeZaposlenik.Name = "txtKorimeZaposlenik";
            this.txtKorimeZaposlenik.Size = new System.Drawing.Size(144, 20);
            this.txtKorimeZaposlenik.TabIndex = 1;
            // 
            // txtLozinkaZaposlenik
            // 
            this.txtLozinkaZaposlenik.Location = new System.Drawing.Point(52, 50);
            this.txtLozinkaZaposlenik.Name = "txtLozinkaZaposlenik";
            this.txtLozinkaZaposlenik.Size = new System.Drawing.Size(144, 20);
            this.txtLozinkaZaposlenik.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLozinkaZaposlenik);
            this.groupBox1.Controls.Add(this.btnLoginZaposlenik);
            this.groupBox1.Controls.Add(this.txtKorimeZaposlenik);
            this.groupBox1.Location = new System.Drawing.Point(47, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaposlenik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korime:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLozinkaClan);
            this.groupBox2.Controls.Add(this.btnClanLogin);
            this.groupBox2.Controls.Add(this.txtKorimeClan);
            this.groupBox2.Location = new System.Drawing.Point(327, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Korime:";
            // 
            // txtLozinkaClan
            // 
            this.txtLozinkaClan.Location = new System.Drawing.Point(52, 50);
            this.txtLozinkaClan.Name = "txtLozinkaClan";
            this.txtLozinkaClan.Size = new System.Drawing.Size(144, 20);
            this.txtLozinkaClan.TabIndex = 2;
            // 
            // btnClanLogin
            // 
            this.btnClanLogin.Location = new System.Drawing.Point(72, 76);
            this.btnClanLogin.Name = "btnClanLogin";
            this.btnClanLogin.Size = new System.Drawing.Size(104, 43);
            this.btnClanLogin.TabIndex = 0;
            this.btnClanLogin.Text = "Clan login";
            this.btnClanLogin.UseVisualStyleBackColor = true;
            this.btnClanLogin.Click += new System.EventHandler(this.btnClanLogin_Click);
            // 
            // txtKorimeClan
            // 
            this.txtKorimeClan.Location = new System.Drawing.Point(52, 24);
            this.txtKorimeClan.Name = "txtKorimeClan";
            this.txtKorimeClan.Size = new System.Drawing.Size(144, 20);
            this.txtKorimeClan.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginZaposlenik;
        private System.Windows.Forms.TextBox txtKorimeZaposlenik;
        private System.Windows.Forms.TextBox txtLozinkaZaposlenik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLozinkaClan;
        private System.Windows.Forms.Button btnClanLogin;
        private System.Windows.Forms.TextBox txtKorimeClan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

