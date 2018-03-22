namespace lecture2
{
    partial class phone_number
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_screen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number";
            // 
            // txt_screen
            // 
            this.txt_screen.Location = new System.Drawing.Point(147, 66);
            this.txt_screen.Name = "txt_screen";
            this.txt_screen.Size = new System.Drawing.Size(228, 22);
            this.txt_screen.TabIndex = 1;
            this.txt_screen.TextChanged += new System.EventHandler(this.txt_screen_TextChanged);
            this.txt_screen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyevent_press);
            // 
            // phone_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 157);
            this.Controls.Add(this.txt_screen);
            this.Controls.Add(this.label1);
            this.Name = "phone_number";
            this.Text = "phone_number";
            this.Load += new System.EventHandler(this.phone_number_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_screen;
    }
}