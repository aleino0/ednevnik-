
namespace ednevnik_
{
    partial class Raspored
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
            this.rasp = new System.Windows.Forms.Button();
            this.izostanci = new System.Windows.Forms.Button();
            this.ispiti = new System.Windows.Forms.Button();
            this.ocjene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.raspored_disp = new System.Windows.Forms.RichTextBox();
            this.novi_raspored = new System.Windows.Forms.Button();
            this.razredi = new System.Windows.Forms.ComboBox();
            this.ime_rasporeda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rasp
            // 
            this.rasp.Location = new System.Drawing.Point(592, 44);
            this.rasp.Margin = new System.Windows.Forms.Padding(4);
            this.rasp.Name = "rasp";
            this.rasp.Size = new System.Drawing.Size(180, 38);
            this.rasp.TabIndex = 12;
            this.rasp.Text = "Raspored";
            this.rasp.UseVisualStyleBackColor = true;
            // 
            // izostanci
            // 
            this.izostanci.Location = new System.Drawing.Point(419, 44);
            this.izostanci.Margin = new System.Windows.Forms.Padding(4);
            this.izostanci.Name = "izostanci";
            this.izostanci.Size = new System.Drawing.Size(180, 38);
            this.izostanci.TabIndex = 11;
            this.izostanci.Text = "izostanci";
            this.izostanci.UseVisualStyleBackColor = true;
            this.izostanci.Click += new System.EventHandler(this.izostanci_Click);
            // 
            // ispiti
            // 
            this.ispiti.Location = new System.Drawing.Point(245, 44);
            this.ispiti.Margin = new System.Windows.Forms.Padding(4);
            this.ispiti.Name = "ispiti";
            this.ispiti.Size = new System.Drawing.Size(180, 38);
            this.ispiti.TabIndex = 10;
            this.ispiti.Text = "ispiti";
            this.ispiti.UseVisualStyleBackColor = true;
            this.ispiti.Click += new System.EventHandler(this.ispiti_Click);
            // 
            // ocjene
            // 
            this.ocjene.Location = new System.Drawing.Point(71, 44);
            this.ocjene.Margin = new System.Windows.Forms.Padding(4);
            this.ocjene.Name = "ocjene";
            this.ocjene.Size = new System.Drawing.Size(180, 38);
            this.ocjene.TabIndex = 9;
            this.ocjene.Text = "ocjene";
            this.ocjene.UseVisualStyleBackColor = true;
            this.ocjene.Click += new System.EventHandler(this.ocjene_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ocjene / ispiti / izostanci / raspored";
            // 
            // raspored_disp
            // 
            this.raspored_disp.Location = new System.Drawing.Point(71, 89);
            this.raspored_disp.Name = "raspored_disp";
            this.raspored_disp.ReadOnly = true;
            this.raspored_disp.Size = new System.Drawing.Size(574, 350);
            this.raspored_disp.TabIndex = 14;
            this.raspored_disp.Text = "";
            // 
            // novi_raspored
            // 
            this.novi_raspored.Location = new System.Drawing.Point(6, 53);
            this.novi_raspored.Name = "novi_raspored";
            this.novi_raspored.Size = new System.Drawing.Size(131, 23);
            this.novi_raspored.TabIndex = 15;
            this.novi_raspored.Text = "dodaj raspored";
            this.novi_raspored.UseVisualStyleBackColor = true;
            this.novi_raspored.Click += new System.EventHandler(this.novi_raspored_Click);
            // 
            // razredi
            // 
            this.razredi.FormattingEnabled = true;
            this.razredi.Items.AddRange(new object[] {
            "1.d"});
            this.razredi.Location = new System.Drawing.Point(651, 89);
            this.razredi.Name = "razredi";
            this.razredi.Size = new System.Drawing.Size(121, 24);
            this.razredi.TabIndex = 16;
            // 
            // ime_rasporeda
            // 
            this.ime_rasporeda.Location = new System.Drawing.Point(6, 25);
            this.ime_rasporeda.Name = "ime_rasporeda";
            this.ime_rasporeda.Size = new System.Drawing.Size(100, 22);
            this.ime_rasporeda.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ime_rasporeda);
            this.groupBox1.Controls.Add(this.novi_raspored);
            this.groupBox1.Location = new System.Drawing.Point(651, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "stvaranje rasporeda";
            // 
            // Raspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.razredi);
            this.Controls.Add(this.raspored_disp);
            this.Controls.Add(this.rasp);
            this.Controls.Add(this.izostanci);
            this.Controls.Add(this.ispiti);
            this.Controls.Add(this.ocjene);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Raspored";
            this.Text = "Raspored";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rasp;
        private System.Windows.Forms.Button izostanci;
        private System.Windows.Forms.Button ispiti;
        private System.Windows.Forms.Button ocjene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox raspored_disp;
        private System.Windows.Forms.Button novi_raspored;
        private System.Windows.Forms.ComboBox razredi;
        private System.Windows.Forms.TextBox ime_rasporeda;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}