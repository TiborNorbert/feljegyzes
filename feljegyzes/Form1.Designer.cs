namespace feljegyzes
{
    partial class feljegyzes
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
            this.szovegrich = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nevetxts = new System.Windows.Forms.TextBox();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.rogzites = new System.Windows.Forms.Button();
            this.megnyit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.modosit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // szovegrich
            // 
            this.szovegrich.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.szovegrich.Location = new System.Drawing.Point(0, 282);
            this.szovegrich.Name = "szovegrich";
            this.szovegrich.Size = new System.Drawing.Size(800, 168);
            this.szovegrich.TabIndex = 0;
            this.szovegrich.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(307, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feljegyzes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(58, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Neve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(58, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dátum";
            // 
            // nevetxts
            // 
            this.nevetxts.Location = new System.Drawing.Point(155, 78);
            this.nevetxts.Name = "nevetxts";
            this.nevetxts.Size = new System.Drawing.Size(146, 20);
            this.nevetxts.TabIndex = 4;
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(155, 131);
            this.datum.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(193, 20);
            this.datum.TabIndex = 5;
            // 
            // rogzites
            // 
            this.rogzites.Location = new System.Drawing.Point(480, 75);
            this.rogzites.Name = "rogzites";
            this.rogzites.Size = new System.Drawing.Size(137, 21);
            this.rogzites.TabIndex = 6;
            this.rogzites.Text = "Save";
            this.rogzites.UseVisualStyleBackColor = true;
            this.rogzites.Click += new System.EventHandler(this.rogzites_Click);
            // 
            // megnyit
            // 
            this.megnyit.Location = new System.Drawing.Point(480, 125);
            this.megnyit.Name = "megnyit";
            this.megnyit.Size = new System.Drawing.Size(136, 25);
            this.megnyit.TabIndex = 7;
            this.megnyit.Text = "Megnyitas";
            this.megnyit.UseVisualStyleBackColor = true;
            this.megnyit.Click += new System.EventHandler(this.megnyit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // modosit
            // 
            this.modosit.Location = new System.Drawing.Point(481, 174);
            this.modosit.Name = "modosit";
            this.modosit.Size = new System.Drawing.Size(136, 23);
            this.modosit.TabIndex = 8;
            this.modosit.Text = "modositas";
            this.modosit.UseVisualStyleBackColor = true;
            this.modosit.Click += new System.EventHandler(this.modosit_Click);
            // 
            // feljegyzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modosit);
            this.Controls.Add(this.megnyit);
            this.Controls.Add(this.rogzites);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.nevetxts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szovegrich);
            this.Name = "feljegyzes";
            this.Text = "Feljegyzes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox szovegrich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nevetxts;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Button rogzites;
        private System.Windows.Forms.Button megnyit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button modosit;
    }
}

