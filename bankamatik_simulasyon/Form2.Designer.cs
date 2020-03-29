namespace bankamatik_simulasyon
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hesap No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(193, 35);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(177, 28);
            this.txtad.TabIndex = 6;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(193, 83);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(177, 28);
            this.txtsoyad.TabIndex = 7;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(193, 136);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(177, 28);
            this.msktc.TabIndex = 8;
            this.msktc.ValidatingType = typeof(int);
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(188, 199);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(182, 28);
            this.msktelefon.TabIndex = 9;
            this.msktelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // mskhesapno
            // 
            this.mskhesapno.Enabled = false;
            this.mskhesapno.Location = new System.Drawing.Point(188, 256);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(150, 28);
            this.mskhesapno.TabIndex = 10;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(188, 316);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(150, 28);
            this.txtsifre.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 510);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskhesapno);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}