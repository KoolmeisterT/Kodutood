namespace Koolmeister_Tiina_Kodutoo2
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
            this.uus_mang = new System.Windows.Forms.Button();
            this.mangi1 = new System.Windows.Forms.Button();
            this.mangi2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nr1 = new System.Windows.Forms.Label();
            this.nr2 = new System.Windows.Forms.Label();
            this.nr3 = new System.Windows.Forms.Label();
            this.nr4 = new System.Windows.Forms.Label();
            this.punktid1 = new System.Windows.Forms.Label();
            this.punktid2 = new System.Windows.Forms.Label();
            this.tulemus = new System.Windows.Forms.Label();
            this.pilt2 = new System.Windows.Forms.PictureBox();
            this.pilt1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pilt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt1)).BeginInit();
            this.SuspendLayout();
            // 
            // uus_mang
            // 
            this.uus_mang.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.uus_mang.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.uus_mang.ForeColor = System.Drawing.Color.DarkRed;
            this.uus_mang.Location = new System.Drawing.Point(230, 444);
            this.uus_mang.Margin = new System.Windows.Forms.Padding(2);
            this.uus_mang.Name = "uus_mang";
            this.uus_mang.Size = new System.Drawing.Size(433, 55);
            this.uus_mang.TabIndex = 0;
            this.uus_mang.Text = "Alusta uut mängu";
            this.uus_mang.UseVisualStyleBackColor = false;
            this.uus_mang.Click += new System.EventHandler(this.uus_mang_Click);
            // 
            // mangi1
            // 
            this.mangi1.BackColor = System.Drawing.SystemColors.Highlight;
            this.mangi1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.mangi1.Location = new System.Drawing.Point(11, 366);
            this.mangi1.Margin = new System.Windows.Forms.Padding(2);
            this.mangi1.Name = "mangi1";
            this.mangi1.Size = new System.Drawing.Size(307, 45);
            this.mangi1.TabIndex = 1;
            this.mangi1.Text = "Mängib Juku";
            this.mangi1.UseVisualStyleBackColor = false;
            this.mangi1.Click += new System.EventHandler(this.mangi1_Click);
            // 
            // mangi2
            // 
            this.mangi2.BackColor = System.Drawing.SystemColors.Highlight;
            this.mangi2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.mangi2.Location = new System.Drawing.Point(577, 366);
            this.mangi2.Margin = new System.Windows.Forms.Padding(2);
            this.mangi2.Name = "mangi2";
            this.mangi2.Size = new System.Drawing.Size(307, 45);
            this.mangi2.TabIndex = 2;
            this.mangi2.Text = "Mängib Peeter";
            this.mangi2.UseVisualStyleBackColor = false;
            this.mangi2.Click += new System.EventHandler(this.mangi2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Esimene mängija\r\nJuku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(612, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teine mängija\r\nPeeter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(81, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Punktid:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(645, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Punktid:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(38, 532);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tulemus:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nr1
            // 
            this.nr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nr1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nr1.Location = new System.Drawing.Point(11, 223);
            this.nr1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nr1.Name = "nr1";
            this.nr1.Size = new System.Drawing.Size(149, 124);
            this.nr1.TabIndex = 8;
            this.nr1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nr2
            // 
            this.nr2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nr2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr2.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nr2.Location = new System.Drawing.Point(169, 223);
            this.nr2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nr2.Name = "nr2";
            this.nr2.Size = new System.Drawing.Size(149, 124);
            this.nr2.TabIndex = 9;
            this.nr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nr3
            // 
            this.nr3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nr3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nr3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr3.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nr3.Location = new System.Drawing.Point(577, 223);
            this.nr3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nr3.Name = "nr3";
            this.nr3.Size = new System.Drawing.Size(149, 124);
            this.nr3.TabIndex = 10;
            this.nr3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nr4
            // 
            this.nr4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nr4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nr4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr4.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nr4.Location = new System.Drawing.Point(735, 223);
            this.nr4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nr4.Name = "nr4";
            this.nr4.Size = new System.Drawing.Size(149, 124);
            this.nr4.TabIndex = 11;
            this.nr4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punktid1
            // 
            this.punktid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punktid1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.punktid1.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.punktid1.Location = new System.Drawing.Point(11, 122);
            this.punktid1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.punktid1.Name = "punktid1";
            this.punktid1.Size = new System.Drawing.Size(307, 92);
            this.punktid1.TabIndex = 12;
            this.punktid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punktid2
            // 
            this.punktid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punktid2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.punktid2.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.punktid2.Location = new System.Drawing.Point(577, 122);
            this.punktid2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.punktid2.Name = "punktid2";
            this.punktid2.Size = new System.Drawing.Size(307, 92);
            this.punktid2.TabIndex = 13;
            this.punktid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tulemus
            // 
            this.tulemus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tulemus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tulemus.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tulemus.Location = new System.Drawing.Point(230, 516);
            this.tulemus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tulemus.Name = "tulemus";
            this.tulemus.Size = new System.Drawing.Size(433, 79);
            this.tulemus.TabIndex = 14;
            this.tulemus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pilt2
            // 
            this.pilt2.Image = global::Koolmeister_Tiina_Kodutoo2.Properties.Resources.Male_Face_H2_icon;
            this.pilt2.Location = new System.Drawing.Point(450, 20);
            this.pilt2.Name = "pilt2";
            this.pilt2.Size = new System.Drawing.Size(127, 129);
            this.pilt2.TabIndex = 16;
            this.pilt2.TabStop = false;
            // 
            // pilt1
            // 
            this.pilt1.Image = global::Koolmeister_Tiina_Kodutoo2.Properties.Resources.Male_Face_A3_icon;
            this.pilt1.Location = new System.Drawing.Point(317, 20);
            this.pilt1.Name = "pilt1";
            this.pilt1.Size = new System.Drawing.Size(127, 129);
            this.pilt1.TabIndex = 15;
            this.pilt1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 615);
            this.Controls.Add(this.pilt2);
            this.Controls.Add(this.pilt1);
            this.Controls.Add(this.tulemus);
            this.Controls.Add(this.punktid2);
            this.Controls.Add(this.punktid1);
            this.Controls.Add(this.nr4);
            this.Controls.Add(this.nr3);
            this.Controls.Add(this.nr2);
            this.Controls.Add(this.nr1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mangi2);
            this.Controls.Add(this.mangi1);
            this.Controls.Add(this.uus_mang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Täring (Bones)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uus_mang;
        private System.Windows.Forms.Button mangi1;
        private System.Windows.Forms.Button mangi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nr1;
        private System.Windows.Forms.Label nr2;
        private System.Windows.Forms.Label nr3;
        private System.Windows.Forms.Label nr4;
        private System.Windows.Forms.Label punktid1;
        private System.Windows.Forms.Label punktid2;
        private System.Windows.Forms.Label tulemus;
        private System.Windows.Forms.PictureBox pilt1;
        private System.Windows.Forms.PictureBox pilt2;
    }
}

