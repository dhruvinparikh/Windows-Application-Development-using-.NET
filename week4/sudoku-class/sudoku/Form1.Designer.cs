namespace sudoku
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
            this.sudokulayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.bgtnReset = new System.Windows.Forms.Button();
            this.rbtnbeginner = new System.Windows.Forms.RadioButton();
            this.rbtnintermediate = new System.Windows.Forms.RadioButton();
            this.rbtnExpert = new System.Windows.Forms.RadioButton();
            this.rbtnMaster = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // sudokulayout
            // 
            this.sudokulayout.ColumnCount = 9;
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.sudokulayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sudokulayout.Location = new System.Drawing.Point(67, 95);
            this.sudokulayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sudokulayout.Name = "sudokulayout";
            this.sudokulayout.RowCount = 9;
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.62406F));
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.37594F));
            this.sudokulayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.sudokulayout.Size = new System.Drawing.Size(735, 494);
            this.sudokulayout.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bgtnReset
            // 
            this.bgtnReset.Location = new System.Drawing.Point(643, 4);
            this.bgtnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bgtnReset.Name = "bgtnReset";
            this.bgtnReset.Size = new System.Drawing.Size(70, 26);
            this.bgtnReset.TabIndex = 2;
            this.bgtnReset.Text = "Reset";
            this.bgtnReset.UseVisualStyleBackColor = true;
            this.bgtnReset.Click += new System.EventHandler(this.bgtnReset_Click);
            // 
            // rbtnbeginner
            // 
            this.rbtnbeginner.AutoSize = true;
            this.rbtnbeginner.Location = new System.Drawing.Point(76, 58);
            this.rbtnbeginner.Name = "rbtnbeginner";
            this.rbtnbeginner.Size = new System.Drawing.Size(86, 21);
            this.rbtnbeginner.TabIndex = 0;
            this.rbtnbeginner.TabStop = true;
            this.rbtnbeginner.Text = "Beginner";
            this.rbtnbeginner.UseVisualStyleBackColor = true;
            this.rbtnbeginner.CheckedChanged += new System.EventHandler(this.rbtnCheckedChanged);
            // 
            // rbtnintermediate
            // 
            this.rbtnintermediate.AutoSize = true;
            this.rbtnintermediate.Location = new System.Drawing.Point(277, 58);
            this.rbtnintermediate.Name = "rbtnintermediate";
            this.rbtnintermediate.Size = new System.Drawing.Size(107, 21);
            this.rbtnintermediate.TabIndex = 3;
            this.rbtnintermediate.TabStop = true;
            this.rbtnintermediate.Text = "Intermediate";
            this.rbtnintermediate.UseVisualStyleBackColor = true;
            this.rbtnintermediate.CheckedChanged += new System.EventHandler(this.rbtnCheckedChanged);
            // 
            // rbtnExpert
            // 
            this.rbtnExpert.AutoSize = true;
            this.rbtnExpert.Location = new System.Drawing.Point(494, 58);
            this.rbtnExpert.Name = "rbtnExpert";
            this.rbtnExpert.Size = new System.Drawing.Size(69, 21);
            this.rbtnExpert.TabIndex = 4;
            this.rbtnExpert.TabStop = true;
            this.rbtnExpert.Text = "Expert";
            this.rbtnExpert.UseVisualStyleBackColor = true;
            this.rbtnExpert.CheckedChanged += new System.EventHandler(this.rbtnCheckedChanged);
            // 
            // rbtnMaster
            // 
            this.rbtnMaster.AutoSize = true;
            this.rbtnMaster.Location = new System.Drawing.Point(692, 58);
            this.rbtnMaster.Name = "rbtnMaster";
            this.rbtnMaster.Size = new System.Drawing.Size(72, 21);
            this.rbtnMaster.TabIndex = 5;
            this.rbtnMaster.TabStop = true;
            this.rbtnMaster.Text = "Master";
            this.rbtnMaster.UseVisualStyleBackColor = true;
            this.rbtnMaster.CheckedChanged += new System.EventHandler(this.rbtnCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 631);
            this.Controls.Add(this.rbtnMaster);
            this.Controls.Add(this.rbtnExpert);
            this.Controls.Add(this.rbtnintermediate);
            this.Controls.Add(this.rbtnbeginner);
            this.Controls.Add(this.bgtnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sudokulayout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel sudokulayout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bgtnReset;
        private System.Windows.Forms.RadioButton rbtnbeginner;
        private System.Windows.Forms.RadioButton rbtnintermediate;
        private System.Windows.Forms.RadioButton rbtnExpert;
        private System.Windows.Forms.RadioButton rbtnMaster;
    }
}

