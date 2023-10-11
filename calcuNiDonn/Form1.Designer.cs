namespace calcuNiDonn
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
            this.t_display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_clear = new System.Windows.Forms.Button();
            this.b_percent = new System.Windows.Forms.Button();
            this.b_pow = new System.Windows.Forms.Button();
            this.b_divide = new System.Windows.Forms.Button();
            this.b_times = new System.Windows.Forms.Button();
            this.b_9 = new System.Windows.Forms.Button();
            this.b_8 = new System.Windows.Forms.Button();
            this.b_7 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_6 = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_1 = new System.Windows.Forms.Button();
            this.b_00 = new System.Windows.Forms.Button();
            this.b_0 = new System.Windows.Forms.Button();
            this.b_dot = new System.Windows.Forms.Button();
            this.b_equals = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_display
            // 
            this.t_display.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_display.Location = new System.Drawing.Point(12, 12);
            this.t_display.Name = "t_display";
            this.t_display.ReadOnly = true;
            this.t_display.Size = new System.Drawing.Size(401, 66);
            this.t_display.TabIndex = 0;
            this.t_display.Text = "0";
            this.t_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.b_clear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_percent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_pow, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_divide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_times, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_minus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_add, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.b_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.b_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.b_1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.b_00, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.b_0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.b_dot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.b_equals, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 403);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // b_clear
            // 
            this.b_clear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_clear.Location = new System.Drawing.Point(3, 3);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(94, 74);
            this.b_clear.TabIndex = 0;
            this.b_clear.Text = "C";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // b_percent
            // 
            this.b_percent.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_percent.Location = new System.Drawing.Point(103, 3);
            this.b_percent.Name = "b_percent";
            this.b_percent.Size = new System.Drawing.Size(94, 74);
            this.b_percent.TabIndex = 0;
            this.b_percent.Text = "√";
            this.b_percent.UseVisualStyleBackColor = true;
            this.b_percent.Click += new System.EventHandler(this.b_percent_Click);
            // 
            // b_pow
            // 
            this.b_pow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pow.Location = new System.Drawing.Point(203, 3);
            this.b_pow.Name = "b_pow";
            this.b_pow.Size = new System.Drawing.Size(94, 74);
            this.b_pow.TabIndex = 0;
            this.b_pow.Text = "^";
            this.b_pow.UseVisualStyleBackColor = true;
            this.b_pow.Click += new System.EventHandler(this.b_pow_Click);
            // 
            // b_divide
            // 
            this.b_divide.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_divide.Location = new System.Drawing.Point(303, 3);
            this.b_divide.Name = "b_divide";
            this.b_divide.Size = new System.Drawing.Size(94, 74);
            this.b_divide.TabIndex = 0;
            this.b_divide.Text = "÷";
            this.b_divide.UseVisualStyleBackColor = true;
            this.b_divide.Click += new System.EventHandler(this.b_divide_Click);
            // 
            // b_times
            // 
            this.b_times.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_times.Location = new System.Drawing.Point(303, 83);
            this.b_times.Name = "b_times";
            this.b_times.Size = new System.Drawing.Size(94, 74);
            this.b_times.TabIndex = 0;
            this.b_times.Text = "*";
            this.b_times.UseVisualStyleBackColor = true;
            this.b_times.Click += new System.EventHandler(this.b_times_Click);
            // 
            // b_9
            // 
            this.b_9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_9.Location = new System.Drawing.Point(203, 83);
            this.b_9.Name = "b_9";
            this.b_9.Size = new System.Drawing.Size(94, 74);
            this.b_9.TabIndex = 0;
            this.b_9.Text = "9";
            this.b_9.UseVisualStyleBackColor = true;
            this.b_9.Click += new System.EventHandler(this.b_9_Click);
            // 
            // b_8
            // 
            this.b_8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_8.Location = new System.Drawing.Point(103, 83);
            this.b_8.Name = "b_8";
            this.b_8.Size = new System.Drawing.Size(94, 74);
            this.b_8.TabIndex = 0;
            this.b_8.Text = "8";
            this.b_8.UseVisualStyleBackColor = true;
            this.b_8.Click += new System.EventHandler(this.b_8_Click);
            // 
            // b_7
            // 
            this.b_7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_7.Location = new System.Drawing.Point(3, 83);
            this.b_7.Name = "b_7";
            this.b_7.Size = new System.Drawing.Size(94, 74);
            this.b_7.TabIndex = 0;
            this.b_7.Text = "7";
            this.b_7.UseVisualStyleBackColor = true;
            this.b_7.Click += new System.EventHandler(this.b_7_Click);
            // 
            // b_4
            // 
            this.b_4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_4.Location = new System.Drawing.Point(3, 163);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(94, 74);
            this.b_4.TabIndex = 0;
            this.b_4.Text = "4";
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.Click += new System.EventHandler(this.b_4_Click);
            // 
            // b_5
            // 
            this.b_5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_5.Location = new System.Drawing.Point(103, 163);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(94, 74);
            this.b_5.TabIndex = 0;
            this.b_5.Text = "5";
            this.b_5.UseVisualStyleBackColor = true;
            this.b_5.Click += new System.EventHandler(this.b_5_Click);
            // 
            // b_6
            // 
            this.b_6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_6.Location = new System.Drawing.Point(203, 163);
            this.b_6.Name = "b_6";
            this.b_6.Size = new System.Drawing.Size(94, 74);
            this.b_6.TabIndex = 0;
            this.b_6.Text = "6";
            this.b_6.UseVisualStyleBackColor = true;
            this.b_6.Click += new System.EventHandler(this.b_6_Click);
            // 
            // b_minus
            // 
            this.b_minus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_minus.Location = new System.Drawing.Point(303, 163);
            this.b_minus.Name = "b_minus";
            this.b_minus.Size = new System.Drawing.Size(94, 74);
            this.b_minus.TabIndex = 0;
            this.b_minus.Text = "-";
            this.b_minus.UseVisualStyleBackColor = true;
            this.b_minus.Click += new System.EventHandler(this.b_minus_Click);
            // 
            // b_add
            // 
            this.b_add.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_add.Location = new System.Drawing.Point(303, 243);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(94, 74);
            this.b_add.TabIndex = 0;
            this.b_add.Text = "+";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_3
            // 
            this.b_3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_3.Location = new System.Drawing.Point(203, 243);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(94, 74);
            this.b_3.TabIndex = 0;
            this.b_3.Text = "3";
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.Click += new System.EventHandler(this.b_3_Click);
            // 
            // b_2
            // 
            this.b_2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_2.Location = new System.Drawing.Point(103, 243);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(94, 74);
            this.b_2.TabIndex = 0;
            this.b_2.Text = "2";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // b_1
            // 
            this.b_1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_1.Location = new System.Drawing.Point(3, 243);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(94, 74);
            this.b_1.TabIndex = 0;
            this.b_1.Text = "1";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // b_00
            // 
            this.b_00.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_00.Location = new System.Drawing.Point(3, 323);
            this.b_00.Name = "b_00";
            this.b_00.Size = new System.Drawing.Size(94, 74);
            this.b_00.TabIndex = 0;
            this.b_00.Text = "+/-";
            this.b_00.UseVisualStyleBackColor = true;
            this.b_00.Click += new System.EventHandler(this.b_00_Click);
            // 
            // b_0
            // 
            this.b_0.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_0.Location = new System.Drawing.Point(103, 323);
            this.b_0.Name = "b_0";
            this.b_0.Size = new System.Drawing.Size(94, 74);
            this.b_0.TabIndex = 0;
            this.b_0.Text = "0";
            this.b_0.UseVisualStyleBackColor = true;
            this.b_0.Click += new System.EventHandler(this.b_0_Click);
            // 
            // b_dot
            // 
            this.b_dot.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_dot.Location = new System.Drawing.Point(203, 323);
            this.b_dot.Name = "b_dot";
            this.b_dot.Size = new System.Drawing.Size(94, 74);
            this.b_dot.TabIndex = 0;
            this.b_dot.Text = ".";
            this.b_dot.UseVisualStyleBackColor = true;
            this.b_dot.Click += new System.EventHandler(this.b_dot_Click);
            // 
            // b_equals
            // 
            this.b_equals.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_equals.Location = new System.Drawing.Point(303, 323);
            this.b_equals.Name = "b_equals";
            this.b_equals.Size = new System.Drawing.Size(94, 74);
            this.b_equals.TabIndex = 0;
            this.b_equals.Text = "=";
            this.b_equals.UseVisualStyleBackColor = true;
            this.b_equals.Click += new System.EventHandler(this.b_equals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.t_display);
            this.Name = "Form1";
            this.Text = "Calculator ni donn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.Button b_percent;
        private System.Windows.Forms.Button b_pow;
        private System.Windows.Forms.Button b_divide;
        private System.Windows.Forms.Button b_times;
        private System.Windows.Forms.Button b_9;
        private System.Windows.Forms.Button b_8;
        private System.Windows.Forms.Button b_7;
        private System.Windows.Forms.Button b_4;
        private System.Windows.Forms.Button b_5;
        private System.Windows.Forms.Button b_6;
        private System.Windows.Forms.Button b_minus;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_3;
        private System.Windows.Forms.Button b_2;
        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.Button b_00;
        private System.Windows.Forms.Button b_0;
        private System.Windows.Forms.Button b_dot;
        private System.Windows.Forms.Button b_equals;
    }
}

