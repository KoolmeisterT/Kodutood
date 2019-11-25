namespace FormApp_2019_02_13
{
    partial class TK_Form_13_03_19
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
            this.TK_Menu = new System.Windows.Forms.MenuStrip();
            this.TK_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TK_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.TK_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.TK_OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.TK_label = new System.Windows.Forms.Label();
            this.TK_list1 = new System.Windows.Forms.ListBox();
            this.TK_lbe_time = new System.Windows.Forms.Label();
            this.TK_lbl_arv = new System.Windows.Forms.Label();
            this.TK_muuda = new System.Windows.Forms.Button();
            this.TK_del1 = new System.Windows.Forms.Button();
            this.TK_lisada = new System.Windows.Forms.Button();
            this.TK_txt1 = new System.Windows.Forms.TextBox();
            this.TK_save_dialog = new System.Windows.Forms.SaveFileDialog();
            this.TK_btn_juhuarvud = new System.Windows.Forms.Button();
            this.TK_btn_juhuarv1 = new System.Windows.Forms.Button();
            this.TK_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TK_Menu
            // 
            this.TK_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TK_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TK_File});
            this.TK_Menu.Location = new System.Drawing.Point(0, 0);
            this.TK_Menu.Name = "TK_Menu";
            this.TK_Menu.Size = new System.Drawing.Size(1820, 39);
            this.TK_Menu.TabIndex = 0;
            this.TK_Menu.Text = "menuStrip1";
            // 
            // TK_File
            // 
            this.TK_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TK_Open,
            this.TK_Save});
            this.TK_File.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TK_File.Name = "TK_File";
            this.TK_File.Size = new System.Drawing.Size(94, 35);
            this.TK_File.Text = "File";
            // 
            // TK_Open
            // 
            this.TK_Open.Name = "TK_Open";
            this.TK_Open.Size = new System.Drawing.Size(247, 36);
            this.TK_Open.Text = "Open file";
            this.TK_Open.Click += new System.EventHandler(this.TK_Open_Click);
            // 
            // TK_Save
            // 
            this.TK_Save.Name = "TK_Save";
            this.TK_Save.Size = new System.Drawing.Size(247, 36);
            this.TK_Save.Text = "Save file";
            this.TK_Save.Click += new System.EventHandler(this.TK_Save_Click);
            // 
            // TK_OpenDialog
            // 
            this.TK_OpenDialog.FileName = "openFileDialog1";
            // 
            // TK_label
            // 
            this.TK_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TK_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TK_label.Location = new System.Drawing.Point(12, 39);
            this.TK_label.Name = "TK_label";
            this.TK_label.Size = new System.Drawing.Size(1796, 29);
            this.TK_label.TabIndex = 1;
            // 
            // TK_list1
            // 
            this.TK_list1.FormattingEnabled = true;
            this.TK_list1.HorizontalScrollbar = true;
            this.TK_list1.ItemHeight = 31;
            this.TK_list1.Location = new System.Drawing.Point(729, 133);
            this.TK_list1.Name = "TK_list1";
            this.TK_list1.Size = new System.Drawing.Size(1079, 283);
            this.TK_list1.TabIndex = 2;
            this.TK_list1.SelectedIndexChanged += new System.EventHandler(this.TK_list1_SelectedIndexChanged);
            // 
            // TK_lbe_time
            // 
            this.TK_lbe_time.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TK_lbe_time.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TK_lbe_time.Location = new System.Drawing.Point(1236, 85);
            this.TK_lbe_time.Name = "TK_lbe_time";
            this.TK_lbe_time.Size = new System.Drawing.Size(278, 29);
            this.TK_lbe_time.TabIndex = 3;
            // 
            // TK_lbl_arv
            // 
            this.TK_lbl_arv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TK_lbl_arv.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TK_lbl_arv.Location = new System.Drawing.Point(1530, 85);
            this.TK_lbl_arv.Name = "TK_lbl_arv";
            this.TK_lbl_arv.Size = new System.Drawing.Size(278, 29);
            this.TK_lbl_arv.TabIndex = 4;
            // 
            // TK_muuda
            // 
            this.TK_muuda.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TK_muuda.Location = new System.Drawing.Point(533, 245);
            this.TK_muuda.Name = "TK_muuda";
            this.TK_muuda.Size = new System.Drawing.Size(190, 38);
            this.TK_muuda.TabIndex = 18;
            this.TK_muuda.Text = "Update";
            this.TK_muuda.UseVisualStyleBackColor = false;
            this.TK_muuda.Click += new System.EventHandler(this.TK_muuda_Click);
            // 
            // TK_del1
            // 
            this.TK_del1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TK_del1.Location = new System.Drawing.Point(533, 188);
            this.TK_del1.Name = "TK_del1";
            this.TK_del1.Size = new System.Drawing.Size(190, 38);
            this.TK_del1.TabIndex = 17;
            this.TK_del1.Text = "Delete";
            this.TK_del1.UseVisualStyleBackColor = false;
            this.TK_del1.Click += new System.EventHandler(this.TK_del1_Click);
            // 
            // TK_lisada
            // 
            this.TK_lisada.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TK_lisada.Location = new System.Drawing.Point(533, 133);
            this.TK_lisada.Name = "TK_lisada";
            this.TK_lisada.Size = new System.Drawing.Size(190, 38);
            this.TK_lisada.TabIndex = 15;
            this.TK_lisada.Text = "-->";
            this.TK_lisada.UseVisualStyleBackColor = false;
            this.TK_lisada.Click += new System.EventHandler(this.TK_lisada_Click);
            // 
            // TK_txt1
            // 
            this.TK_txt1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TK_txt1.Location = new System.Drawing.Point(16, 133);
            this.TK_txt1.Name = "TK_txt1";
            this.TK_txt1.Size = new System.Drawing.Size(500, 38);
            this.TK_txt1.TabIndex = 14;
            // 
            // TK_btn_juhuarvud
            // 
            this.TK_btn_juhuarvud.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TK_btn_juhuarvud.Location = new System.Drawing.Point(533, 305);
            this.TK_btn_juhuarvud.Name = "TK_btn_juhuarvud";
            this.TK_btn_juhuarvud.Size = new System.Drawing.Size(190, 38);
            this.TK_btn_juhuarvud.TabIndex = 19;
            this.TK_btn_juhuarvud.Text = "Juhuarvud";
            this.TK_btn_juhuarvud.UseVisualStyleBackColor = false;
            this.TK_btn_juhuarvud.Click += new System.EventHandler(this.TK_btn_juhuarvud_Click);
            // 
            // TK_btn_juhuarv1
            // 
            this.TK_btn_juhuarv1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TK_btn_juhuarv1.Location = new System.Drawing.Point(533, 360);
            this.TK_btn_juhuarv1.Name = "TK_btn_juhuarv1";
            this.TK_btn_juhuarv1.Size = new System.Drawing.Size(190, 38);
            this.TK_btn_juhuarv1.TabIndex = 20;
            this.TK_btn_juhuarv1.Text = "Juhuarv 1";
            this.TK_btn_juhuarv1.UseVisualStyleBackColor = false;
            this.TK_btn_juhuarv1.Click += new System.EventHandler(this.TK_btn_juhuarv1_Click);
            // 
            // TK_Form_13_03_19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 899);
            this.Controls.Add(this.TK_btn_juhuarv1);
            this.Controls.Add(this.TK_btn_juhuarvud);
            this.Controls.Add(this.TK_muuda);
            this.Controls.Add(this.TK_del1);
            this.Controls.Add(this.TK_lisada);
            this.Controls.Add(this.TK_txt1);
            this.Controls.Add(this.TK_lbl_arv);
            this.Controls.Add(this.TK_lbe_time);
            this.Controls.Add(this.TK_list1);
            this.Controls.Add(this.TK_label);
            this.Controls.Add(this.TK_Menu);
            this.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MainMenuStrip = this.TK_Menu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TK_Form_13_03_19";
            this.Text = "TK_Form_13_03_19";
            this.TK_Menu.ResumeLayout(false);
            this.TK_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TK_Menu;
        private System.Windows.Forms.ToolStripMenuItem TK_File;
        private System.Windows.Forms.ToolStripMenuItem TK_Open;
        private System.Windows.Forms.ToolStripMenuItem TK_Save;
        private System.Windows.Forms.OpenFileDialog TK_OpenDialog;
        private System.Windows.Forms.Label TK_label;
        private System.Windows.Forms.ListBox TK_list1;
        private System.Windows.Forms.Label TK_lbe_time;
        private System.Windows.Forms.Label TK_lbl_arv;
        private System.Windows.Forms.Button TK_muuda;
        private System.Windows.Forms.Button TK_del1;
        private System.Windows.Forms.Button TK_lisada;
        private System.Windows.Forms.TextBox TK_txt1;
        private System.Windows.Forms.SaveFileDialog TK_save_dialog;
        private System.Windows.Forms.Button TK_btn_juhuarvud;
        private System.Windows.Forms.Button TK_btn_juhuarv1;
    }
}