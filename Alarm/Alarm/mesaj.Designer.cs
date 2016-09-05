namespace Alarm
{
    partial class mesaj
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
            this.ertele = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ertele
            // 
            this.ertele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ertele.BackColor = System.Drawing.Color.Transparent;
            this.ertele.FlatAppearance.BorderSize = 5;
            this.ertele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ertele.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ertele.ForeColor = System.Drawing.Color.Aqua;
            this.ertele.Location = new System.Drawing.Point(-2, 75);
            this.ertele.Name = "ertele";
            this.ertele.Size = new System.Drawing.Size(183, 38);
            this.ertele.TabIndex = 1;
            this.ertele.Text = "Ertele";
            this.ertele.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ertele.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ertele.UseCompatibleTextRendering = true;
            this.ertele.UseVisualStyleBackColor = false;
            // 
            // kapat
            // 
            this.kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kapat.BackColor = System.Drawing.Color.Transparent;
            this.kapat.FlatAppearance.BorderSize = 5;
            this.kapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.ForeColor = System.Drawing.Color.SteelBlue;
            this.kapat.Location = new System.Drawing.Point(238, 75);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(97, 38);
            this.kapat.TabIndex = 2;
            this.kapat.Text = "Durdur";
            this.kapat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kapat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.kapat.UseCompatibleTextRendering = true;
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alarm Mesajı!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(85, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alarm Çalıyor!!";
            // 
            // mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.ertele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 150);
            this.MinimumSize = new System.Drawing.Size(299, 139);
            this.Name = "mesaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Çalıyor!!!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button ertele;
        public System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}