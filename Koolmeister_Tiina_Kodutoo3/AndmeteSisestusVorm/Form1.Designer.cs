namespace AndmeteSisestusVorm
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
            this.pere2 = new System.Windows.Forms.Label();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.uuenda = new System.Windows.Forms.Button();
            this.kustuta = new System.Windows.Forms.Button();
            this.lisa = new System.Windows.Forms.Button();
            this.nimi = new System.Windows.Forms.TextBox();
            this.isikukood = new System.Windows.Forms.MaskedTextBox();
            this.nimi_txt = new System.Windows.Forms.Label();
            this.isikukood_txt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TK_save = new System.Windows.Forms.Button();
            this.vaata = new System.Windows.Forms.Button();
            this.XX_Nimekiri = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.group1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pere2
            // 
            this.pere2.AutoSize = true;
            this.pere2.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pere2.Location = new System.Drawing.Point(12, 11);
            this.pere2.Name = "pere2";
            this.pere2.Size = new System.Drawing.Size(832, 41);
            this.pere2.TabIndex = 0;
            this.pere2.Text = "XX - Perekonnanime kaks esimest tähte";
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.group1.Controls.Add(this.uuenda);
            this.group1.Controls.Add(this.kustuta);
            this.group1.Controls.Add(this.lisa);
            this.group1.Controls.Add(this.nimi);
            this.group1.Controls.Add(this.isikukood);
            this.group1.Controls.Add(this.nimi_txt);
            this.group1.Controls.Add(this.isikukood_txt);
            this.group1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.group1.Location = new System.Drawing.Point(12, 55);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(828, 231);
            this.group1.TabIndex = 1;
            this.group1.TabStop = false;
            // 
            // uuenda
            // 
            this.uuenda.BackColor = System.Drawing.SystemColors.Highlight;
            this.uuenda.Location = new System.Drawing.Point(307, 157);
            this.uuenda.Name = "uuenda";
            this.uuenda.Size = new System.Drawing.Size(234, 59);
            this.uuenda.TabIndex = 8;
            this.uuenda.Text = "Update";
            this.uuenda.UseVisualStyleBackColor = false;
            this.uuenda.Click += new System.EventHandler(this.uuenda_Click);
            // 
            // kustuta
            // 
            this.kustuta.BackColor = System.Drawing.SystemColors.Highlight;
            this.kustuta.Location = new System.Drawing.Point(588, 157);
            this.kustuta.Name = "kustuta";
            this.kustuta.Size = new System.Drawing.Size(234, 59);
            this.kustuta.TabIndex = 7;
            this.kustuta.Text = "Delete";
            this.kustuta.UseVisualStyleBackColor = false;
            this.kustuta.Click += new System.EventHandler(this.kustuta_Click);
            // 
            // lisa
            // 
            this.lisa.BackColor = System.Drawing.SystemColors.Highlight;
            this.lisa.Location = new System.Drawing.Point(25, 157);
            this.lisa.Name = "lisa";
            this.lisa.Size = new System.Drawing.Size(234, 59);
            this.lisa.TabIndex = 6;
            this.lisa.Text = "Add";
            this.lisa.UseVisualStyleBackColor = false;
            this.lisa.Click += new System.EventHandler(this.lisa_Click);
            // 
            // nimi
            // 
            this.nimi.Location = new System.Drawing.Point(259, 81);
            this.nimi.Name = "nimi";
            this.nimi.Size = new System.Drawing.Size(563, 49);
            this.nimi.TabIndex = 5;
            // 
            // isikukood
            // 
            this.isikukood.Location = new System.Drawing.Point(259, 26);
            this.isikukood.Mask = "00000000000";
            this.isikukood.Name = "isikukood";
            this.isikukood.Size = new System.Drawing.Size(563, 49);
            this.isikukood.TabIndex = 4;
            this.isikukood.ValidatingType = typeof(int);
            // 
            // nimi_txt
            // 
            this.nimi_txt.AutoSize = true;
            this.nimi_txt.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.nimi_txt.Location = new System.Drawing.Point(6, 84);
            this.nimi_txt.Name = "nimi_txt";
            this.nimi_txt.Size = new System.Drawing.Size(106, 41);
            this.nimi_txt.TabIndex = 3;
            this.nimi_txt.Text = "Nimi";
            // 
            // isikukood_txt
            // 
            this.isikukood_txt.AutoSize = true;
            this.isikukood_txt.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.isikukood_txt.Location = new System.Drawing.Point(6, 29);
            this.isikukood_txt.Name = "isikukood_txt";
            this.isikukood_txt.Size = new System.Drawing.Size(216, 41);
            this.isikukood_txt.TabIndex = 2;
            this.isikukood_txt.Text = "Isikukood";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.TK_save);
            this.groupBox1.Controls.Add(this.vaata);
            this.groupBox1.Controls.Add(this.XX_Nimekiri);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 339);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // TK_save
            // 
            this.TK_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.TK_save.Location = new System.Drawing.Point(307, 263);
            this.TK_save.Name = "TK_save";
            this.TK_save.Size = new System.Drawing.Size(234, 59);
            this.TK_save.TabIndex = 10;
            this.TK_save.Text = "Write";
            this.TK_save.UseVisualStyleBackColor = false;
            this.TK_save.Click += new System.EventHandler(this.TK_save_Click);
            // 
            // vaata
            // 
            this.vaata.BackColor = System.Drawing.SystemColors.Highlight;
            this.vaata.Location = new System.Drawing.Point(25, 263);
            this.vaata.Name = "vaata";
            this.vaata.Size = new System.Drawing.Size(234, 59);
            this.vaata.TabIndex = 9;
            this.vaata.Text = "Read";
            this.vaata.UseVisualStyleBackColor = false;
            this.vaata.Click += new System.EventHandler(this.vaata_Click);
            // 
            // XX_Nimekiri
            // 
            this.XX_Nimekiri.FormattingEnabled = true;
            this.XX_Nimekiri.ItemHeight = 41;
            this.XX_Nimekiri.Location = new System.Drawing.Point(7, 27);
            this.XX_Nimekiri.Name = "XX_Nimekiri";
            this.XX_Nimekiri.Size = new System.Drawing.Size(815, 209);
            this.XX_Nimekiri.TabIndex = 0;
            this.XX_Nimekiri.SelectedIndexChanged += new System.EventHandler(this.XX_Nimekiri_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "TK_OpenDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.pere2);
            this.Name = "Form1";
            this.Text = "Andmete sisestamise vorm";
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pere2;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Button uuenda;
        private System.Windows.Forms.Button kustuta;
        private System.Windows.Forms.Button lisa;
        private System.Windows.Forms.TextBox nimi;
        private System.Windows.Forms.MaskedTextBox isikukood;
        private System.Windows.Forms.Label nimi_txt;
        private System.Windows.Forms.Label isikukood_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TK_save;
        private System.Windows.Forms.Button vaata;
        private System.Windows.Forms.ListBox XX_Nimekiri;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

