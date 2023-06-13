
namespace ednevnik_
{
    partial class predmet
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
            this.predmeti = new System.Windows.Forms.ComboBox();
            this.fPredmet_ime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // predmeti
            // 
            this.predmeti.FormattingEnabled = true;
            this.predmeti.Items.AddRange(new object[] {
            "Hrvatski",
            "Matematika",
            "Engleski"});
            this.predmeti.Location = new System.Drawing.Point(519, 84);
            this.predmeti.Margin = new System.Windows.Forms.Padding(4);
            this.predmeti.Name = "predmeti";
            this.predmeti.Size = new System.Drawing.Size(160, 24);
            this.predmeti.TabIndex = 2;
            this.predmeti.SelectedIndexChanged += new System.EventHandler(this.predmeti_SelectedIndexChanged);
            // 
            // fPredmet_ime
            // 
            this.fPredmet_ime.AutoSize = true;
            this.fPredmet_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPredmet_ime.Location = new System.Drawing.Point(103, 54);
            this.fPredmet_ime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fPredmet_ime.Name = "fPredmet_ime";
            this.fPredmet_ime.Size = new System.Drawing.Size(171, 32);
            this.fPredmet_ime.TabIndex = 3;
            this.fPredmet_ime.Text = "predmet ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ocjene";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "biljeske";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "predmet select";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(107, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(572, 196);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // predmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 537);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fPredmet_ime);
            this.Controls.Add(this.predmeti);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "predmet";
            this.Text = "predmet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox predmeti;
        private System.Windows.Forms.Label fPredmet_ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}