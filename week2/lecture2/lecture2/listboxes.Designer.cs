namespace lecture2
{
    partial class listboxes
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
            this.lb_left = new System.Windows.Forms.ListBox();
            this.lb_right = new System.Windows.Forms.ListBox();
            this.txt_screen = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_shift = new System.Windows.Forms.Button();
            this.btn_unshift = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_left
            // 
            this.lb_left.FormattingEnabled = true;
            this.lb_left.ItemHeight = 16;
            this.lb_left.Location = new System.Drawing.Point(31, 130);
            this.lb_left.Name = "lb_left";
            this.lb_left.Size = new System.Drawing.Size(170, 308);
            this.lb_left.TabIndex = 0;
            // 
            // lb_right
            // 
            this.lb_right.FormattingEnabled = true;
            this.lb_right.ItemHeight = 16;
            this.lb_right.Location = new System.Drawing.Point(480, 130);
            this.lb_right.Name = "lb_right";
            this.lb_right.Size = new System.Drawing.Size(171, 308);
            this.lb_right.TabIndex = 1;
            // 
            // txt_screen
            // 
            this.txt_screen.Location = new System.Drawing.Point(31, 47);
            this.txt_screen.Name = "txt_screen";
            this.txt_screen.Size = new System.Drawing.Size(400, 22);
            this.txt_screen.TabIndex = 2;
            this.txt_screen.Text = "0";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(533, 46);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_shift
            // 
            this.btn_shift.Location = new System.Drawing.Point(304, 228);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(75, 23);
            this.btn_shift.TabIndex = 4;
            this.btn_shift.Text = "----->";
            this.btn_shift.UseVisualStyleBackColor = true;
            this.btn_shift.Click += new System.EventHandler(this.btn_shift_Click);
            // 
            // btn_unshift
            // 
            this.btn_unshift.Location = new System.Drawing.Point(304, 292);
            this.btn_unshift.Name = "btn_unshift";
            this.btn_unshift.Size = new System.Drawing.Size(75, 23);
            this.btn_unshift.TabIndex = 5;
            this.btn_unshift.Text = "<-----";
            this.btn_unshift.UseVisualStyleBackColor = true;
            this.btn_unshift.Click += new System.EventHandler(this.btn_unshift_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(304, 363);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 6;
            this.btn_display.Text = "display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // listboxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 478);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_unshift);
            this.Controls.Add(this.btn_shift);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_screen);
            this.Controls.Add(this.lb_right);
            this.Controls.Add(this.lb_left);
            this.Name = "listboxes";
            this.Text = "listboxes";
            this.Load += new System.EventHandler(this.listboxes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_left;
        private System.Windows.Forms.ListBox lb_right;
        private System.Windows.Forms.TextBox txt_screen;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_shift;
        private System.Windows.Forms.Button btn_unshift;
        private System.Windows.Forms.Button btn_display;
    }
}