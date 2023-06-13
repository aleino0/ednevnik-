
namespace ednevnik_
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
            this.predmeti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ocjene = new System.Windows.Forms.Button();
            this.ispiti = new System.Windows.Forms.Button();
            this.izostanci = new System.Windows.Forms.Button();
            this.raspored = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucRazred = new System.Windows.Forms.TextBox();
            this.ucMail = new System.Windows.Forms.TextBox();
            this.ucGod = new System.Windows.Forms.TextBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.ucSpol = new System.Windows.Forms.TextBox();
            this.ucIme = new System.Windows.Forms.TextBox();
            this.ucPrezime = new System.Windows.Forms.TextBox();
            this.ucenici = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // predmeti
            // 
            this.predmeti.FormattingEnabled = true;
            this.predmeti.ItemHeight = 16;
            this.predmeti.Items.AddRange(new object[] {
            "Hrvatski",
            "Matematika",
            "Engleski"});
            this.predmeti.Location = new System.Drawing.Point(83, 140);
            this.predmeti.Margin = new System.Windows.Forms.Padding(4);
            this.predmeti.Name = "predmeti";
            this.predmeti.Size = new System.Drawing.Size(353, 180);
            this.predmeti.TabIndex = 0;
            this.predmeti.TabStop = false;
            this.predmeti.SelectedIndexChanged += new System.EventHandler(this.predmeti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ocjene / ispiti / izostanci / raspored";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "predmeti";
            // 
            // ocjene
            // 
            this.ocjene.Location = new System.Drawing.Point(99, 49);
            this.ocjene.Margin = new System.Windows.Forms.Padding(4);
            this.ocjene.Name = "ocjene";
            this.ocjene.Size = new System.Drawing.Size(180, 38);
            this.ocjene.TabIndex = 4;
            this.ocjene.TabStop = false;
            this.ocjene.Text = "ocjene";
            this.ocjene.UseVisualStyleBackColor = true;
            // 
            // ispiti
            // 
            this.ispiti.Location = new System.Drawing.Point(273, 49);
            this.ispiti.Margin = new System.Windows.Forms.Padding(4);
            this.ispiti.Name = "ispiti";
            this.ispiti.Size = new System.Drawing.Size(180, 38);
            this.ispiti.TabIndex = 5;
            this.ispiti.TabStop = false;
            this.ispiti.Text = "ispiti";
            this.ispiti.UseVisualStyleBackColor = true;
            this.ispiti.Click += new System.EventHandler(this.ispiti_Click);
            // 
            // izostanci
            // 
            this.izostanci.Location = new System.Drawing.Point(447, 49);
            this.izostanci.Margin = new System.Windows.Forms.Padding(4);
            this.izostanci.Name = "izostanci";
            this.izostanci.Size = new System.Drawing.Size(180, 38);
            this.izostanci.TabIndex = 6;
            this.izostanci.TabStop = false;
            this.izostanci.Text = "izostanci";
            this.izostanci.UseVisualStyleBackColor = true;
            this.izostanci.Click += new System.EventHandler(this.izostanci_Click);
            // 
            // raspored
            // 
            this.raspored.Location = new System.Drawing.Point(620, 49);
            this.raspored.Margin = new System.Windows.Forms.Padding(4);
            this.raspored.Name = "raspored";
            this.raspored.Size = new System.Drawing.Size(180, 38);
            this.raspored.TabIndex = 7;
            this.raspored.TabStop = false;
            this.raspored.Text = "raspored";
            this.raspored.UseVisualStyleBackColor = true;
            this.raspored.Click += new System.EventHandler(this.raspored_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ucRazred);
            this.groupBox1.Controls.Add(this.ucMail);
            this.groupBox1.Controls.Add(this.ucGod);
            this.groupBox1.Controls.Add(this.dodaj);
            this.groupBox1.Controls.Add(this.ucSpol);
            this.groupBox1.Controls.Add(this.ucIme);
            this.groupBox1.Controls.Add(this.ucPrezime);
            this.groupBox1.Location = new System.Drawing.Point(458, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi ucenik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "razred";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "godine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "spol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ime";
            // 
            // ucRazred
            // 
            this.ucRazred.Location = new System.Drawing.Point(162, 90);
            this.ucRazred.Name = "ucRazred";
            this.ucRazred.Size = new System.Drawing.Size(100, 22);
            this.ucRazred.TabIndex = 4;
            // 
            // ucMail
            // 
            this.ucMail.Location = new System.Drawing.Point(162, 140);
            this.ucMail.Name = "ucMail";
            this.ucMail.Size = new System.Drawing.Size(100, 22);
            this.ucMail.TabIndex = 5;
            // 
            // ucGod
            // 
            this.ucGod.Location = new System.Drawing.Point(162, 38);
            this.ucGod.Name = "ucGod";
            this.ucGod.Size = new System.Drawing.Size(100, 22);
            this.ucGod.TabIndex = 3;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(277, 139);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(125, 23);
            this.dodaj.TabIndex = 6;
            this.dodaj.Text = "dodaj ucenika";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // ucSpol
            // 
            this.ucSpol.Location = new System.Drawing.Point(7, 140);
            this.ucSpol.Name = "ucSpol";
            this.ucSpol.Size = new System.Drawing.Size(100, 22);
            this.ucSpol.TabIndex = 2;
            // 
            // ucIme
            // 
            this.ucIme.Location = new System.Drawing.Point(7, 38);
            this.ucIme.Name = "ucIme";
            this.ucIme.Size = new System.Drawing.Size(100, 22);
            this.ucIme.TabIndex = 0;
            // 
            // ucPrezime
            // 
            this.ucPrezime.Location = new System.Drawing.Point(7, 90);
            this.ucPrezime.Name = "ucPrezime";
            this.ucPrezime.Size = new System.Drawing.Size(100, 22);
            this.ucPrezime.TabIndex = 1;
            // 
            // ucenici
            // 
            this.ucenici.FormattingEnabled = true;
            this.ucenici.Location = new System.Drawing.Point(458, 327);
            this.ucenici.Name = "ucenici";
            this.ucenici.Size = new System.Drawing.Size(121, 24);
            this.ucenici.TabIndex = 9;
            this.ucenici.TabStop = false;
            this.ucenici.SelectedIndexChanged += new System.EventHandler(this.ucenici_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 465);
            this.Controls.Add(this.ucenici);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.raspored);
            this.Controls.Add(this.izostanci);
            this.Controls.Add(this.ispiti);
            this.Controls.Add(this.ocjene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predmeti);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "e-dnevnik";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox predmeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ocjene;
        private System.Windows.Forms.Button ispiti;
        private System.Windows.Forms.Button izostanci;
        private System.Windows.Forms.Button raspored;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ucRazred;
        private System.Windows.Forms.TextBox ucMail;
        private System.Windows.Forms.TextBox ucGod;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.TextBox ucSpol;
        private System.Windows.Forms.TextBox ucIme;
        private System.Windows.Forms.TextBox ucPrezime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ucenici;
    }
}

