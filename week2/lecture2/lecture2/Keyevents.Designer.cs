namespace lecture2
{
    partial class Keyevents
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
            this.key_info = new System.Windows.Forms.RichTextBox();
            this.txt_screen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // key_info
            // 
            this.key_info.Location = new System.Drawing.Point(61, 167);
            this.key_info.Name = "key_info";
            this.key_info.Size = new System.Drawing.Size(404, 143);
            this.key_info.TabIndex = 0;
            this.key_info.Text = "";
            this.key_info.TextChanged += new System.EventHandler(this.key_info_TextChanged);
            this.key_info.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_info_down);
            // 
            // txt_screen
            // 
            this.txt_screen.Location = new System.Drawing.Point(61, 94);
            this.txt_screen.Name = "txt_screen";
            this.txt_screen.Size = new System.Drawing.Size(404, 22);
            this.txt_screen.TabIndex = 1;
            this.txt_screen.TextChanged += new System.EventHandler(this.txt_screen_TextChanged);
            this.txt_screen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_info_down);
            // 
            // Keyevents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 410);
            this.Controls.Add(this.txt_screen);
            this.Controls.Add(this.key_info);
            this.Name = "Keyevents";
            this.Text = "Keyevents";
            this.Load += new System.EventHandler(this.Keyevents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox key_info;
        private System.Windows.Forms.TextBox txt_screen;
    }
}