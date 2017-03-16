namespace Notes_Tool
{
    partial class f_NotesMain
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
            this.b_Copy = new System.Windows.Forms.Button();
            this.b_Clear = new System.Windows.Forms.Button();
            this.b_Reset = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.cb_TemplateList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Notes = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Copy
            // 
            this.b_Copy.Location = new System.Drawing.Point(8, 384);
            this.b_Copy.Name = "b_Copy";
            this.b_Copy.Size = new System.Drawing.Size(75, 23);
            this.b_Copy.TabIndex = 3;
            this.b_Copy.Text = "Copy";
            this.b_Copy.UseVisualStyleBackColor = true;
            this.b_Copy.Click += new System.EventHandler(this.b_Copy_Click);
            // 
            // b_Clear
            // 
            this.b_Clear.Location = new System.Drawing.Point(408, 384);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(75, 23);
            this.b_Clear.TabIndex = 4;
            this.b_Clear.Text = "Clear";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // b_Reset
            // 
            this.b_Reset.Location = new System.Drawing.Point(496, 384);
            this.b_Reset.Name = "b_Reset";
            this.b_Reset.Size = new System.Drawing.Size(75, 23);
            this.b_Reset.TabIndex = 5;
            this.b_Reset.Text = "Reset";
            this.b_Reset.UseVisualStyleBackColor = true;
            this.b_Reset.Click += new System.EventHandler(this.b_Reset_Click);
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(504, 32);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(75, 23);
            this.b_Add.TabIndex = 1;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // cb_TemplateList
            // 
            this.cb_TemplateList.FormattingEnabled = true;
            this.cb_TemplateList.IntegralHeight = false;
            this.cb_TemplateList.ItemHeight = 13;
            this.cb_TemplateList.Location = new System.Drawing.Point(104, 32);
            this.cb_TemplateList.Name = "cb_TemplateList";
            this.cb_TemplateList.Size = new System.Drawing.Size(393, 21);
            this.cb_TemplateList.TabIndex = 0;
            this.cb_TemplateList.Text = "<None>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Template:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes:";
            // 
            // tb_Notes
            // 
            this.tb_Notes.Location = new System.Drawing.Point(8, 72);
            this.tb_Notes.Multiline = true;
            this.tb_Notes.Name = "tb_Notes";
            this.tb_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Notes.Size = new System.Drawing.Size(568, 304);
            this.tb_Notes.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File,
            this.tsmi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_File
            // 
            this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File_Exit});
            this.tsmi_File.Name = "tsmi_File";
            this.tsmi_File.Size = new System.Drawing.Size(37, 20);
            this.tsmi_File.Text = "File";
            // 
            // tsmi_File_Exit
            // 
            this.tsmi_File_Exit.Name = "tsmi_File_Exit";
            this.tsmi_File_Exit.Size = new System.Drawing.Size(92, 22);
            this.tsmi_File_Exit.Text = "Exit";
            this.tsmi_File_Exit.Click += new System.EventHandler(this.tsmi_File_Exit_Click);
            // 
            // tsmi_Help
            // 
            this.tsmi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Help_About});
            this.tsmi_Help.Name = "tsmi_Help";
            this.tsmi_Help.Size = new System.Drawing.Size(44, 20);
            this.tsmi_Help.Text = "Help";
            // 
            // tsmi_Help_About
            // 
            this.tsmi_Help_About.Name = "tsmi_Help_About";
            this.tsmi_Help_About.Size = new System.Drawing.Size(107, 22);
            this.tsmi_Help_About.Text = "About";
            this.tsmi_Help_About.Click += new System.EventHandler(this.tsmi_Help_About_Click);
            // 
            // f_NotesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 412);
            this.Controls.Add(this.tb_Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_TemplateList);
            this.Controls.Add(this.b_Reset);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.b_Clear);
            this.Controls.Add(this.b_Copy);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "f_NotesMain";
            this.Text = "TSS Notes Tool 0.2.0";
            this.Load += new System.EventHandler(this.f_NotesMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Copy;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.Button b_Reset;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Notes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Help_About;
        private System.Windows.Forms.ComboBox cb_TemplateList;
    }
}

