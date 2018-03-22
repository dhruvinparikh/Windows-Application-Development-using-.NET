namespace GUI_Design
{
    partial class Paintbrush
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
            this.SuspendLayout();
            // 
            // Paintbrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Paintbrush";
            this.Text = "Paintbrush";
            this.Load += new System.EventHandler(this.Paintbrush_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paint_Mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paint_Mouse_Move);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paint_Mouse_Up);
            this.ResumeLayout(false);

        }

        #endregion
    }
}