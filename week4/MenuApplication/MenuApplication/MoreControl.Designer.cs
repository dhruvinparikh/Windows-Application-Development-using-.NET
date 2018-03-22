namespace MenuApplication
{
    partial class MoreControl
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
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Location = new System.Drawing.Point(350, 335);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(137, 17);
            this.linkHelp.TabIndex = 0;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Visit Online For Help";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.onlineHelp);
            // 
            // backLink
            // 
            this.backLink.AutoSize = true;
            this.backLink.Location = new System.Drawing.Point(350, 286);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(62, 17);
            this.backLink.TabIndex = 1;
            this.backLink.TabStop = true;
            this.backLink.Text = "Go Back";
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back);
            // 
            // MoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 374);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.linkHelp);
            this.Name = "MoreControl";
            this.Text = "MoreControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.LinkLabel backLink;
    }
}