
namespace ednevnik_
{
    partial class Izostanci
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
            this.Izo = new System.Windows.Forms.Button();
            this.ispiti = new System.Windows.Forms.Button();
            this.ocjene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // raspored
            // 
            this.raspored.Location = new System.Drawing.Point(433, 28);
            this.raspored.Name = "raspored";
            this.raspored.Size = new System.Drawing.Size(135, 31);
            this.raspored.TabIndex = 12;
            this.raspored.Text = "raspored";
            this.raspored.UseVisualStyleBackColor = true;
            this.raspored.Click += new System.EventHandler(this.raspored_Click);
            // 
            // Izo
            // 
            this.Izo.Location = new System.Drawing.Point(303, 28);
            this.Izo.Name = "Izo";
            this.Izo.Size = new System.Drawing.Size(135, 31);
            this.Izo.TabIndex = 11;
            this.Izo.Text = "Izostanci";
            this.Izo.UseVisualStyleBackColor = true;
            // 
            // ispiti
            // 
            this.ispiti.Location = new System.Drawing.Point(173, 28);
            this.ispiti.Name = "ispiti";
            this.ispiti.Size = new System.Drawing.Size(135, 31);
            this.ispiti.TabIndex = 10;
            this.ispiti.Text = "ispiti";
            this.ispiti.UseVisualStyleBackColor = true;
            this.ispiti.Click += new System.EventHandler(this.ispiti_Click);
            // 
            // ocjene
            // 
            this.ocjene.Location = new System.Drawing.Point(42, 28);
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
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ocjene / ispiti / izostanci / raspored";
            // 
            // Izostanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 380);
            this.Controls.Add(this.raspored);
            this.Controls.Add(this.Izo);
            this.Controls.Add(this.ispiti);
            this.Controls.Add(this.ocjene);
            this.Controls.Add(this.label1);
            this.Name = "Izostanci";
            this.Text = "Izostanci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button raspored;
        private System.Windows.Forms.Button Izo;
        private System.Windows.Forms.Button ispiti;
        private System.Windows.Forms.Button ocjene;
        private System.Windows.Forms.Label label1;
    }
}