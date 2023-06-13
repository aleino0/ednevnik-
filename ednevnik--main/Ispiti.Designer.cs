
namespace ednevnik_
{
    partial class Ispiti
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
            this.raspored = new System.Windows.Forms.Button();
            this.izostanci = new System.Windows.Forms.Button();
            this.Ispi = new System.Windows.Forms.Button();
            this.ocjene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // raspored
            // 
            this.raspored.Location = new System.Drawing.Point(448, 42);
            this.raspored.Name = "raspored";
            this.raspored.Size = new System.Drawing.Size(135, 31);
            this.raspored.TabIndex = 12;
            this.raspored.Text = "raspored";
            this.raspored.UseVisualStyleBackColor = true;
            this.raspored.Click += new System.EventHandler(this.raspored_Click);
            // 
            // izostanci
            // 
            this.izostanci.Location = new System.Drawing.Point(318, 42);
            this.izostanci.Name = "izostanci";
            this.izostanci.Size = new System.Drawing.Size(135, 31);
            this.izostanci.TabIndex = 11;
            this.izostanci.Text = "izostanci";
            this.izostanci.UseVisualStyleBackColor = true;
            this.izostanci.Click += new System.EventHandler(this.izostanci_Click);
            // 
            // Ispi
            // 
            this.Ispi.Location = new System.Drawing.Point(187, 42);
            this.Ispi.Name = "Ispi";
            this.Ispi.Size = new System.Drawing.Size(135, 31);
            this.Ispi.TabIndex = 10;
            this.Ispi.Text = "Ispiti";
            this.Ispi.UseVisualStyleBackColor = true;
            // 
            // ocjene
            // 
            this.ocjene.Location = new System.Drawing.Point(57, 42);
            this.ocjene.Name = "ocjene";
            this.ocjene.Size = new System.Drawing.Size(135, 31);
            this.ocjene.TabIndex = 9;
            this.ocjene.Text = "ocjene";
            this.ocjene.UseVisualStyleBackColor = true;
            this.ocjene.Click += new System.EventHandler(this.ocjene_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ocjene / ispiti / izostanci / raspored";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Ispiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 386);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.raspored);
            this.Controls.Add(this.izostanci);
            this.Controls.Add(this.Ispi);
            this.Controls.Add(this.ocjene);
            this.Controls.Add(this.label1);
            this.Name = "Ispiti";
            this.Text = "Ispiti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button raspored;
        private System.Windows.Forms.Button izostanci;
        private System.Windows.Forms.Button Ispi;
        private System.Windows.Forms.Button ocjene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}