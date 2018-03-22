namespace lecture2
{
    partial class SameEventOnAllOptions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_OKCancel = new System.Windows.Forms.RadioButton();
            this.rb_YesNoCancel = new System.Windows.Forms.RadioButton();
            this.rb_OK = new System.Windows.Forms.RadioButton();
            this.rb_YesNo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_WARNING = new System.Windows.Forms.RadioButton();
            this.rb_ERROR = new System.Windows.Forms.RadioButton();
            this.rb_QUESTION = new System.Windows.Forms.RadioButton();
            this.rb_INFORMATION = new System.Windows.Forms.RadioButton();
            this.btn_Display = new System.Windows.Forms.Button();
            this.txt_Screen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_OKCancel);
            this.groupBox1.Controls.Add(this.rb_YesNoCancel);
            this.groupBox1.Controls.Add(this.rb_OK);
            this.groupBox1.Controls.Add(this.rb_YesNo);
            this.groupBox1.Location = new System.Drawing.Point(21, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BType";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_OKCancel
            // 
            this.rb_OKCancel.AutoSize = true;
            this.rb_OKCancel.Location = new System.Drawing.Point(6, 99);
            this.rb_OKCancel.Name = "rb_OKCancel";
            this.rb_OKCancel.Size = new System.Drawing.Size(90, 21);
            this.rb_OKCancel.TabIndex = 4;
            this.rb_OKCancel.TabStop = true;
            this.rb_OKCancel.Text = "OkCancel";
            this.rb_OKCancel.UseVisualStyleBackColor = true;
            this.rb_OKCancel.CheckedChanged += new System.EventHandler(this.ButtonType_CheckedChanged);
            // 
            // rb_YesNoCancel
            // 
            this.rb_YesNoCancel.AutoSize = true;
            this.rb_YesNoCancel.Location = new System.Drawing.Point(6, 45);
            this.rb_YesNoCancel.Name = "rb_YesNoCancel";
            this.rb_YesNoCancel.Size = new System.Drawing.Size(114, 21);
            this.rb_YesNoCancel.TabIndex = 2;
            this.rb_YesNoCancel.TabStop = true;
            this.rb_YesNoCancel.Text = "YesNoCancel";
            this.rb_YesNoCancel.UseVisualStyleBackColor = true;
            this.rb_YesNoCancel.CheckedChanged += new System.EventHandler(this.ButtonType_CheckedChanged);
            // 
            // rb_OK
            // 
            this.rb_OK.AutoSize = true;
            this.rb_OK.Location = new System.Drawing.Point(6, 72);
            this.rb_OK.Name = "rb_OK";
            this.rb_OK.Size = new System.Drawing.Size(49, 21);
            this.rb_OK.TabIndex = 1;
            this.rb_OK.TabStop = true;
            this.rb_OK.Text = "OK";
            this.rb_OK.UseVisualStyleBackColor = true;
            this.rb_OK.CheckedChanged += new System.EventHandler(this.ButtonType_CheckedChanged);
            // 
            // rb_YesNo
            // 
            this.rb_YesNo.AutoSize = true;
            this.rb_YesNo.Location = new System.Drawing.Point(6, 21);
            this.rb_YesNo.Name = "rb_YesNo";
            this.rb_YesNo.Size = new System.Drawing.Size(71, 21);
            this.rb_YesNo.TabIndex = 0;
            this.rb_YesNo.TabStop = true;
            this.rb_YesNo.Text = "YesNo";
            this.rb_YesNo.UseVisualStyleBackColor = true;
            this.rb_YesNo.CheckedChanged += new System.EventHandler(this.ButtonType_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_WARNING);
            this.groupBox2.Controls.Add(this.rb_ERROR);
            this.groupBox2.Controls.Add(this.rb_QUESTION);
            this.groupBox2.Controls.Add(this.rb_INFORMATION);
            this.groupBox2.Location = new System.Drawing.Point(170, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IconType";
            // 
            // rb_WARNING
            // 
            this.rb_WARNING.AutoSize = true;
            this.rb_WARNING.Location = new System.Drawing.Point(0, 99);
            this.rb_WARNING.Name = "rb_WARNING";
            this.rb_WARNING.Size = new System.Drawing.Size(95, 21);
            this.rb_WARNING.TabIndex = 8;
            this.rb_WARNING.TabStop = true;
            this.rb_WARNING.Text = "WARNING";
            this.rb_WARNING.UseVisualStyleBackColor = true;
            this.rb_WARNING.CheckedChanged += new System.EventHandler(this.IconType_CheckedChanged);
            // 
            // rb_ERROR
            // 
            this.rb_ERROR.AutoSize = true;
            this.rb_ERROR.Location = new System.Drawing.Point(0, 72);
            this.rb_ERROR.Name = "rb_ERROR";
            this.rb_ERROR.Size = new System.Drawing.Size(79, 21);
            this.rb_ERROR.TabIndex = 7;
            this.rb_ERROR.TabStop = true;
            this.rb_ERROR.Text = "ERROR";
            this.rb_ERROR.UseVisualStyleBackColor = true;
            this.rb_ERROR.CheckedChanged += new System.EventHandler(this.IconType_CheckedChanged);
            // 
            // rb_QUESTION
            // 
            this.rb_QUESTION.AutoSize = true;
            this.rb_QUESTION.Location = new System.Drawing.Point(0, 45);
            this.rb_QUESTION.Name = "rb_QUESTION";
            this.rb_QUESTION.Size = new System.Drawing.Size(101, 21);
            this.rb_QUESTION.TabIndex = 6;
            this.rb_QUESTION.TabStop = true;
            this.rb_QUESTION.Text = "QUESTION";
            this.rb_QUESTION.UseVisualStyleBackColor = true;
            this.rb_QUESTION.CheckedChanged += new System.EventHandler(this.IconType_CheckedChanged);
            // 
            // rb_INFORMATION
            // 
            this.rb_INFORMATION.AutoSize = true;
            this.rb_INFORMATION.Location = new System.Drawing.Point(0, 21);
            this.rb_INFORMATION.Name = "rb_INFORMATION";
            this.rb_INFORMATION.Size = new System.Drawing.Size(124, 21);
            this.rb_INFORMATION.TabIndex = 5;
            this.rb_INFORMATION.TabStop = true;
            this.rb_INFORMATION.Text = "INFORMATION";
            this.rb_INFORMATION.UseVisualStyleBackColor = true;
            this.rb_INFORMATION.CheckedChanged += new System.EventHandler(this.IconType_CheckedChanged);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(117, 226);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(88, 33);
            this.btn_Display.TabIndex = 5;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // txt_Screen
            // 
            this.txt_Screen.Location = new System.Drawing.Point(33, 22);
            this.txt_Screen.Name = "txt_Screen";
            this.txt_Screen.Size = new System.Drawing.Size(278, 22);
            this.txt_Screen.TabIndex = 6;
            this.txt_Screen.Text = "Welcome To Event Handling";
            // 
            // SameEventOnAllOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 271);
            this.Controls.Add(this.txt_Screen);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SameEventOnAllOptions";
            this.Text = "SameEventOnAllOptions";
            this.Load += new System.EventHandler(this.SameEventOnAllOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_OKCancel;
        private System.Windows.Forms.RadioButton rb_YesNoCancel;
        private System.Windows.Forms.RadioButton rb_OK;
        private System.Windows.Forms.RadioButton rb_YesNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_WARNING;
        private System.Windows.Forms.RadioButton rb_ERROR;
        private System.Windows.Forms.RadioButton rb_QUESTION;
        private System.Windows.Forms.RadioButton rb_INFORMATION;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.TextBox txt_Screen;
    }
}