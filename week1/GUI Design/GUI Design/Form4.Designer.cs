namespace GUI_Design
{
    partial class Form4
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
            this.txt_screen = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_modulo = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_decimal = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_factorial = new System.Windows.Forms.Button();
            this.btn_hex = new System.Windows.Forms.Button();
            this.btn_binary = new System.Windows.Forms.Button();
            this.btn_oct = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_screen
            // 
            this.txt_screen.Location = new System.Drawing.Point(12, 33);
            this.txt_screen.Name = "txt_screen";
            this.txt_screen.ReadOnly = true;
            this.txt_screen.Size = new System.Drawing.Size(584, 22);
            this.txt_screen.TabIndex = 0;
            this.txt_screen.Text = "0";
            this.txt_screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_screen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 99);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(143, 99);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 23);
            this.btn_equal.TabIndex = 3;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(278, 99);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(75, 23);
            this.btn_on.TabIndex = 4;
            this.btn_on.Text = "ON/";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(401, 99);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 5;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(12, 159);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(143, 159);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 7;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(278, 159);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 23);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_00
            // 
            this.btn_00.Location = new System.Drawing.Point(401, 159);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(75, 23);
            this.btn_00.TabIndex = 9;
            this.btn_00.Text = "00";
            this.btn_00.UseVisualStyleBackColor = true;
            this.btn_00.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(12, 219);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 23);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(143, 219);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 23);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(278, 219);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 23);
            this.btn_7.TabIndex = 12;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_modulo
            // 
            this.btn_modulo.Location = new System.Drawing.Point(401, 219);
            this.btn_modulo.Name = "btn_modulo";
            this.btn_modulo.Size = new System.Drawing.Size(75, 23);
            this.btn_modulo.TabIndex = 13;
            this.btn_modulo.Text = "%";
            this.btn_modulo.UseVisualStyleBackColor = true;
            this.btn_modulo.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(12, 279);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 23);
            this.btn_8.TabIndex = 14;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(143, 279);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 23);
            this.btn_9.TabIndex = 15;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(278, 279);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 23);
            this.btn_0.TabIndex = 16;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(401, 279);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(75, 23);
            this.btn_mul.TabIndex = 17;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // btn_decimal
            // 
            this.btn_decimal.Location = new System.Drawing.Point(12, 336);
            this.btn_decimal.Name = "btn_decimal";
            this.btn_decimal.Size = new System.Drawing.Size(75, 23);
            this.btn_decimal.TabIndex = 18;
            this.btn_decimal.Text = ".";
            this.btn_decimal.UseVisualStyleBackColor = true;
            this.btn_decimal.Click += new System.EventHandler(this.btn_decimal_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(143, 336);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(278, 336);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 20;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(401, 336);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 21;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.Button_Operator_Click);
            // 
            // btn_factorial
            // 
            this.btn_factorial.Location = new System.Drawing.Point(521, 99);
            this.btn_factorial.Name = "btn_factorial";
            this.btn_factorial.Size = new System.Drawing.Size(75, 23);
            this.btn_factorial.TabIndex = 22;
            this.btn_factorial.Text = "n!";
            this.btn_factorial.UseVisualStyleBackColor = true;
            this.btn_factorial.Click += new System.EventHandler(this.Button_Function_Click);
            // 
            // btn_hex
            // 
            this.btn_hex.Location = new System.Drawing.Point(521, 159);
            this.btn_hex.Name = "btn_hex";
            this.btn_hex.Size = new System.Drawing.Size(75, 23);
            this.btn_hex.TabIndex = 23;
            this.btn_hex.Text = "hex";
            this.btn_hex.UseVisualStyleBackColor = true;
            this.btn_hex.Click += new System.EventHandler(this.Button_Function_Click);
            // 
            // btn_binary
            // 
            this.btn_binary.Location = new System.Drawing.Point(521, 219);
            this.btn_binary.Name = "btn_binary";
            this.btn_binary.Size = new System.Drawing.Size(75, 23);
            this.btn_binary.TabIndex = 24;
            this.btn_binary.Text = "bin";
            this.btn_binary.UseVisualStyleBackColor = true;
            this.btn_binary.Click += new System.EventHandler(this.Button_Function_Click);
            // 
            // btn_oct
            // 
            this.btn_oct.Location = new System.Drawing.Point(521, 279);
            this.btn_oct.Name = "btn_oct";
            this.btn_oct.Size = new System.Drawing.Size(75, 23);
            this.btn_oct.TabIndex = 25;
            this.btn_oct.Text = "oct";
            this.btn_oct.UseVisualStyleBackColor = true;
            this.btn_oct.Click += new System.EventHandler(this.Button_Function_Click);
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(521, 336);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 26;
            this.btn_log.Text = "log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.Button_Function_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 378);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_oct);
            this.Controls.Add(this.btn_binary);
            this.Controls.Add(this.btn_hex);
            this.Controls.Add(this.btn_factorial);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_decimal);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_modulo);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_00);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_on);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_screen);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_screen;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_modulo;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_decimal;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_factorial;
        private System.Windows.Forms.Button btn_hex;
        private System.Windows.Forms.Button btn_binary;
        private System.Windows.Forms.Button btn_oct;
        private System.Windows.Forms.Button btn_log;
    }
}