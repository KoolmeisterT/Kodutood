namespace FormApp_2019_02_13
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
            this.components = new System.ComponentModel.Container();
            this.TK_timer = new System.Windows.Forms.Timer(this.components);
            this.TK_lbl_Time = new System.Windows.Forms.Label();
            this.TK_rb1 = new System.Windows.Forms.RadioButton();
            this.TK_rb2 = new System.Windows.Forms.RadioButton();
            this.TK_rb3 = new System.Windows.Forms.RadioButton();
            this.TK_txt1 = new System.Windows.Forms.TextBox();
            this.TK_lbl1 = new System.Windows.Forms.Label();
            this.TK_check1 = new System.Windows.Forms.CheckBox();
            this.TK_txt2 = new System.Windows.Forms.TextBox();
            this.TK_lisada = new System.Windows.Forms.Button();
            this.TK_list1 = new System.Windows.Forms.ListBox();
            this.TK_check2 = new System.Windows.Forms.CheckBox();
            this.TK_del1 = new System.Windows.Forms.Button();
            this.TK_muuda = new System.Windows.Forms.Button();
            this.TK_btn_13_03_19 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TK_timer
            // 
            this.TK_timer.Tick += new System.EventHandler(this.TK_timer_Tick);
            // 
            // TK_lbl_Time
            // 
            this.TK_lbl_Time.BackColor = System.Drawing.SystemColors.Info;
            this.TK_lbl_Time.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TK_lbl_Time.Location = new System.Drawing.Point(54, 44);
            this.TK_lbl_Time.Name = "TK_lbl_Time";
            this.TK_lbl_Time.Size = new System.Drawing.Size(858, 33);
            this.TK_lbl_Time.TabIndex = 0;
            this.TK_lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TK_rb1
            // 
            this.TK_rb1.AutoSize = true;
            this.TK_rb1.Location = new System.Drawing.Point(60, 114);
            this.TK_rb1.Name = "TK_rb1";
            this.TK_rb1.Size = new System.Drawing.Size(127, 26);
            this.TK_rb1.TabIndex = 1;
            this.TK_rb1.TabStop = true;
            this.TK_rb1.Text = "Date+time";
            this.TK_rb1.UseVisualStyleBackColor = true;
            this.TK_rb1.CheckedChanged += new System.EventHandler(this.TK_rb1_CheckedChanged);
            // 
            // TK_rb2
            // 
            this.TK_rb2.AutoSize = true;
            this.TK_rb2.Location = new System.Drawing.Point(60, 168);
            this.TK_rb2.Name = "TK_rb2";
            this.TK_rb2.Size = new System.Drawing.Size(72, 26);
            this.TK_rb2.TabIndex = 2;
            this.TK_rb2.TabStop = true;
            this.TK_rb2.Text = "Time";
            this.TK_rb2.UseVisualStyleBackColor = true;
            this.TK_rb2.CheckedChanged += new System.EventHandler(this.TK_rb2_CheckedChanged);
            // 
            // TK_rb3
            // 
            this.TK_rb3.AutoSize = true;
            this.TK_rb3.Location = new System.Drawing.Point(60, 223);
            this.TK_rb3.Name = "TK_rb3";
            this.TK_rb3.Size = new System.Drawing.Size(72, 26);
            this.TK_rb3.TabIndex = 3;
            this.TK_rb3.TabStop = true;
            this.TK_rb3.Text = "Stop";
            this.TK_rb3.UseVisualStyleBackColor = true;
            this.TK_rb3.CheckedChanged += new System.EventHandler(this.TK_rb3_CheckedChanged);
            // 
            // TK_txt1
            // 
            this.TK_txt1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TK_txt1.Location = new System.Drawing.Point(59, 279);
            this.TK_txt1.Name = "TK_txt1";
            this.TK_txt1.Size = new System.Drawing.Size(590, 28);
            this.TK_txt1.TabIndex = 4;
            this.TK_txt1.TextChanged += new System.EventHandler(this.TK_txt1_TextChanged);
            // 
            // TK_lbl1
            // 
            this.TK_lbl1.BackColor = System.Drawing.SystemColors.Info;
            this.TK_lbl1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TK_lbl1.Location = new System.Drawing.Point(60, 343);
            this.TK_lbl1.Name = "TK_lbl1";
            this.TK_lbl1.Size = new System.Drawing.Size(589, 36);
            this.TK_lbl1.TabIndex = 5;
            this.TK_lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TK_check1
            // 
            this.TK_check1.AutoSize = true;
            this.TK_check1.Checked = true;
            this.TK_check1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TK_check1.Location = new System.Drawing.Point(697, 282);
            this.TK_check1.Name = "TK_check1";
            this.TK_check1.Size = new System.Drawing.Size(161, 26);
            this.TK_check1.TabIndex = 6;
            this.TK_check1.Text = "suured tähed";
            this.TK_check1.UseVisualStyleBackColor = true;
            this.TK_check1.CheckedChanged += new System.EventHandler(this.TK_check1_CheckedChanged);
            // 
            // TK_txt2
            // 
            this.TK_txt2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TK_txt2.Location = new System.Drawing.Point(59, 412);
            this.TK_txt2.Name = "TK_txt2";
            this.TK_txt2.Size = new System.Drawing.Size(590, 28);
            this.TK_txt2.TabIndex = 7;
            // 
            // TK_lisada
            // 
            this.TK_lisada.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TK_lisada.Location = new System.Drawing.Point(707, 414);
            this.TK_lisada.Name = "TK_lisada";
            this.TK_lisada.Size = new System.Drawing.Size(124, 29);
            this.TK_lisada.TabIndex = 9;
            this.TK_lisada.Text = "-->";
            this.TK_lisada.UseVisualStyleBackColor = false;
            this.TK_lisada.Click += new System.EventHandler(this.TK_lisada_Click);
            // 
            // TK_list1
            // 
            this.TK_list1.FormattingEnabled = true;
            this.TK_list1.ItemHeight = 21;
            this.TK_list1.Location = new System.Drawing.Point(906, 413);
            this.TK_list1.Name = "TK_list1";
            this.TK_list1.Size = new System.Drawing.Size(399, 235);
            this.TK_list1.TabIndex = 10;
            // 
            // TK_check2
            // 
            this.TK_check2.AutoSize = true;
            this.TK_check2.Location = new System.Drawing.Point(906, 666);
            this.TK_check2.Name = "TK_check2";
            this.TK_check2.Size = new System.Drawing.Size(150, 26);
            this.TK_check2.TabIndex = 11;
            this.TK_check2.Text = "Järjestatud";
            this.TK_check2.UseVisualStyleBackColor = true;
            this.TK_check2.CheckedChanged += new System.EventHandler(this.TK_check2_CheckedChanged);
            // 
            // TK_del1
            // 
            this.TK_del1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TK_del1.Location = new System.Drawing.Point(707, 449);
            this.TK_del1.Name = "TK_del1";
            this.TK_del1.Size = new System.Drawing.Size(124, 29);
            this.TK_del1.TabIndex = 12;
            this.TK_del1.Text = "Delete";
            this.TK_del1.UseVisualStyleBackColor = false;
            this.TK_del1.Click += new System.EventHandler(this.TK_del1_Click);
            // 
            // TK_muuda
            // 
            this.TK_muuda.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TK_muuda.Location = new System.Drawing.Point(707, 484);
            this.TK_muuda.Name = "TK_muuda";
            this.TK_muuda.Size = new System.Drawing.Size(124, 29);
            this.TK_muuda.TabIndex = 13;
            this.TK_muuda.Text = "Update";
            this.TK_muuda.UseVisualStyleBackColor = false;
            this.TK_muuda.Click += new System.EventHandler(this.TK_muuda_Click);
            // 
            // TK_btn_13_03_19
            // 
            this.TK_btn_13_03_19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TK_btn_13_03_19.Location = new System.Drawing.Point(1147, 40);
            this.TK_btn_13_03_19.Name = "TK_btn_13_03_19";
            this.TK_btn_13_03_19.Size = new System.Drawing.Size(233, 63);
            this.TK_btn_13_03_19.TabIndex = 14;
            this.TK_btn_13_03_19.Text = "13.03.2019";
            this.TK_btn_13_03_19.UseVisualStyleBackColor = false;
            this.TK_btn_13_03_19.Click += new System.EventHandler(this.TK_btn_13_03_19_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.TK_lisada;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1400, 759);
            this.Controls.Add(this.TK_btn_13_03_19);
            this.Controls.Add(this.TK_muuda);
            this.Controls.Add(this.TK_del1);
            this.Controls.Add(this.TK_check2);
            this.Controls.Add(this.TK_list1);
            this.Controls.Add(this.TK_lisada);
            this.Controls.Add(this.TK_txt2);
            this.Controls.Add(this.TK_check1);
            this.Controls.Add(this.TK_lbl1);
            this.Controls.Add(this.TK_txt1);
            this.Controls.Add(this.TK_rb3);
            this.Controls.Add(this.TK_rb2);
            this.Controls.Add(this.TK_rb1);
            this.Controls.Add(this.TK_lbl_Time);
            this.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TK_timer;
        private System.Windows.Forms.Label TK_lbl_Time;
        private System.Windows.Forms.RadioButton TK_rb1;
        private System.Windows.Forms.RadioButton TK_rb2;
        private System.Windows.Forms.RadioButton TK_rb3;
        private System.Windows.Forms.TextBox TK_txt1;
        private System.Windows.Forms.Label TK_lbl1;
        private System.Windows.Forms.CheckBox TK_check1;
        private System.Windows.Forms.TextBox TK_txt2;
        private System.Windows.Forms.Button TK_lisada;
        private System.Windows.Forms.ListBox TK_list1;
        private System.Windows.Forms.CheckBox TK_check2;
        private System.Windows.Forms.Button TK_del1;
        private System.Windows.Forms.Button TK_muuda;
        private System.Windows.Forms.Button TK_btn_13_03_19;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

