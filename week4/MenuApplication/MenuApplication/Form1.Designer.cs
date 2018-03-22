namespace MenuApplication
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.greenColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.blueColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arialFont = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanFont = new System.Windows.Forms.ToolStripMenuItem();
            this.serifFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.italicsStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu,
            this.toolStripSeparator2,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileMenu.Size = new System.Drawing.Size(44, 24);
            this.fileMenu.Text = "&File";
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenu.Size = new System.Drawing.Size(195, 26);
            this.openMenu.Text = "&Open C:\\";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitMenu.Size = new System.Drawing.Size(195, 26);
            this.exitMenu.Text = "&Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.toolStripSeparator1,
            this.styleToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editMenu.Size = new System.Drawing.Size(47, 24);
            this.editMenu.Text = "&Edit";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redColorMenu,
            this.greenColorMenu,
            this.blueColorMenu});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // redColorMenu
            // 
            this.redColorMenu.CheckOnClick = true;
            this.redColorMenu.Name = "redColorMenu";
            this.redColorMenu.Size = new System.Drawing.Size(123, 26);
            this.redColorMenu.Text = "Red";
            this.redColorMenu.Click += new System.EventHandler(this.colorPicker);
            // 
            // greenColorMenu
            // 
            this.greenColorMenu.CheckOnClick = true;
            this.greenColorMenu.Name = "greenColorMenu";
            this.greenColorMenu.Size = new System.Drawing.Size(123, 26);
            this.greenColorMenu.Text = "Green";
            this.greenColorMenu.Click += new System.EventHandler(this.colorPicker);
            // 
            // blueColorMenu
            // 
            this.blueColorMenu.CheckOnClick = true;
            this.blueColorMenu.Name = "blueColorMenu";
            this.blueColorMenu.Size = new System.Drawing.Size(123, 26);
            this.blueColorMenu.Text = "Blue";
            this.blueColorMenu.Click += new System.EventHandler(this.colorPicker);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arialFont,
            this.timesNewRomanFont,
            this.serifFont,
            this.toolStripMenuItem1,
            this.boldStyle,
            this.italicsStyle});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // arialFont
            // 
            this.arialFont.CheckOnClick = true;
            this.arialFont.Name = "arialFont";
            this.arialFont.Size = new System.Drawing.Size(208, 26);
            this.arialFont.Text = "Arial";
            this.arialFont.Click += new System.EventHandler(this.stylePicker);
            // 
            // timesNewRomanFont
            // 
            this.timesNewRomanFont.CheckOnClick = true;
            this.timesNewRomanFont.Name = "timesNewRomanFont";
            this.timesNewRomanFont.Size = new System.Drawing.Size(208, 26);
            this.timesNewRomanFont.Text = "Times New Roman";
            this.timesNewRomanFont.Click += new System.EventHandler(this.stylePicker);
            // 
            // serifFont
            // 
            this.serifFont.CheckOnClick = true;
            this.serifFont.Name = "serifFont";
            this.serifFont.Size = new System.Drawing.Size(208, 26);
            this.serifFont.Text = "Serif";
            this.serifFont.Click += new System.EventHandler(this.stylePicker);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // boldStyle
            // 
            this.boldStyle.CheckOnClick = true;
            this.boldStyle.Name = "boldStyle";
            this.boldStyle.Size = new System.Drawing.Size(208, 26);
            this.boldStyle.Text = "Bold";
            this.boldStyle.Click += new System.EventHandler(this.stylePicker);
            // 
            // italicsStyle
            // 
            this.italicsStyle.CheckOnClick = true;
            this.italicsStyle.Name = "italicsStyle";
            this.italicsStyle.Size = new System.Drawing.Size(208, 26);
            this.italicsStyle.Text = "Italics";
            this.italicsStyle.Click += new System.EventHandler(this.stylePicker);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testing Style Execution";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redColorMenu;
        private System.Windows.Forms.ToolStripMenuItem greenColorMenu;
        private System.Windows.Forms.ToolStripMenuItem blueColorMenu;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arialFont;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanFont;
        private System.Windows.Forms.ToolStripMenuItem serifFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem boldStyle;
        private System.Windows.Forms.ToolStripMenuItem italicsStyle;
        private System.Windows.Forms.Label label1;
    }
}

