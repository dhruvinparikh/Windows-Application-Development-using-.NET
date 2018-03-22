namespace Exercise_1
{
    partial class Drawing_panel
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
            this.gb_color = new System.Windows.Forms.GroupBox();
            this.rb_black = new System.Windows.Forms.RadioButton();
            this.rb_green = new System.Windows.Forms.RadioButton();
            this.rb_blue = new System.Windows.Forms.RadioButton();
            this.rb_red = new System.Windows.Forms.RadioButton();
            this.gb_size = new System.Windows.Forms.GroupBox();
            this.rb_small = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_large = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_color.SuspendLayout();
            this.gb_size.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_color
            // 
            this.gb_color.Controls.Add(this.rb_black);
            this.gb_color.Controls.Add(this.rb_green);
            this.gb_color.Controls.Add(this.rb_blue);
            this.gb_color.Controls.Add(this.rb_red);
            this.gb_color.Location = new System.Drawing.Point(26, 36);
            this.gb_color.Name = "gb_color";
            this.gb_color.Size = new System.Drawing.Size(82, 153);
            this.gb_color.TabIndex = 0;
            this.gb_color.TabStop = false;
            this.gb_color.Text = "Color";
            // 
            // rb_black
            // 
            this.rb_black.AutoSize = true;
            this.rb_black.Location = new System.Drawing.Point(6, 116);
            this.rb_black.Name = "rb_black";
            this.rb_black.Size = new System.Drawing.Size(63, 21);
            this.rb_black.TabIndex = 5;
            this.rb_black.TabStop = true;
            this.rb_black.Text = "Black";
            this.rb_black.UseVisualStyleBackColor = true;
            this.rb_black.CheckedChanged += new System.EventHandler(this.Color_Change);
            // 
            // rb_green
            // 
            this.rb_green.AutoSize = true;
            this.rb_green.Location = new System.Drawing.Point(6, 89);
            this.rb_green.Name = "rb_green";
            this.rb_green.Size = new System.Drawing.Size(69, 21);
            this.rb_green.TabIndex = 4;
            this.rb_green.TabStop = true;
            this.rb_green.Text = "Green";
            this.rb_green.UseVisualStyleBackColor = true;
            this.rb_green.CheckedChanged += new System.EventHandler(this.Color_Change);
            // 
            // rb_blue
            // 
            this.rb_blue.AutoSize = true;
            this.rb_blue.Location = new System.Drawing.Point(6, 59);
            this.rb_blue.Name = "rb_blue";
            this.rb_blue.Size = new System.Drawing.Size(57, 21);
            this.rb_blue.TabIndex = 3;
            this.rb_blue.TabStop = true;
            this.rb_blue.Text = "Blue";
            this.rb_blue.UseVisualStyleBackColor = true;
            this.rb_blue.CheckedChanged += new System.EventHandler(this.Color_Change);
            // 
            // rb_red
            // 
            this.rb_red.AutoSize = true;
            this.rb_red.Location = new System.Drawing.Point(6, 32);
            this.rb_red.Name = "rb_red";
            this.rb_red.Size = new System.Drawing.Size(55, 21);
            this.rb_red.TabIndex = 2;
            this.rb_red.TabStop = true;
            this.rb_red.Text = "Red";
            this.rb_red.UseVisualStyleBackColor = true;
            this.rb_red.CheckedChanged += new System.EventHandler(this.Color_Change);
            // 
            // gb_size
            // 
            this.gb_size.Controls.Add(this.rb_small);
            this.gb_size.Controls.Add(this.rb_medium);
            this.gb_size.Controls.Add(this.rb_large);
            this.gb_size.Location = new System.Drawing.Point(26, 218);
            this.gb_size.Name = "gb_size";
            this.gb_size.Size = new System.Drawing.Size(82, 111);
            this.gb_size.TabIndex = 1;
            this.gb_size.TabStop = false;
            this.gb_size.Text = "Size";
            // 
            // rb_small
            // 
            this.rb_small.AutoSize = true;
            this.rb_small.Location = new System.Drawing.Point(6, 21);
            this.rb_small.Name = "rb_small";
            this.rb_small.Size = new System.Drawing.Size(63, 21);
            this.rb_small.TabIndex = 6;
            this.rb_small.TabStop = true;
            this.rb_small.Text = "Small";
            this.rb_small.UseVisualStyleBackColor = true;
            this.rb_small.CheckedChanged += new System.EventHandler(this.Size_Change);
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(6, 48);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(78, 21);
            this.rb_medium.TabIndex = 7;
            this.rb_medium.TabStop = true;
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            this.rb_medium.CheckedChanged += new System.EventHandler(this.Size_Change);
            // 
            // rb_large
            // 
            this.rb_large.AutoSize = true;
            this.rb_large.Location = new System.Drawing.Point(6, 75);
            this.rb_large.Name = "rb_large";
            this.rb_large.Size = new System.Drawing.Size(66, 21);
            this.rb_large.TabIndex = 8;
            this.rb_large.TabStop = true;
            this.rb_large.Text = "Large";
            this.rb_large.UseVisualStyleBackColor = true;
            this.rb_large.CheckedChanged += new System.EventHandler(this.Size_Change);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(158, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 293);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawEvent_Mouse_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawEvent_Mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawEvent_Mouse_Move);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawEvent_Mouse_Up);
            // 
            // Drawing_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_size);
            this.Controls.Add(this.gb_color);
            this.Name = "Drawing_panel";
            this.Text = "Drawing_panel";
            this.Load += new System.EventHandler(this.Drawing_panel_Load);
            this.gb_color.ResumeLayout(false);
            this.gb_color.PerformLayout();
            this.gb_size.ResumeLayout(false);
            this.gb_size.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_color;
        private System.Windows.Forms.GroupBox gb_size;
        private System.Windows.Forms.RadioButton rb_red;
        private System.Windows.Forms.RadioButton rb_black;
        private System.Windows.Forms.RadioButton rb_green;
        private System.Windows.Forms.RadioButton rb_blue;
        private System.Windows.Forms.RadioButton rb_small;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_large;
        private System.Windows.Forms.Panel panel1;
    }
}