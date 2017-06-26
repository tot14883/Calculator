namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.divison = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.but00 = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(271, 102);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(13, 121);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(63, 58);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(82, 121);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(63, 58);
            this.pow.TabIndex = 2;
            this.pow.Text = "Pow";
            this.pow.UseVisualStyleBackColor = true;
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(151, 121);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(63, 58);
            this.sqr.TabIndex = 3;
            this.sqr.Text = "Sqr";
            this.sqr.UseVisualStyleBackColor = true;
            // 
            // divison
            // 
            this.divison.Location = new System.Drawing.Point(220, 121);
            this.divison.Name = "divison";
            this.divison.Size = new System.Drawing.Size(63, 58);
            this.divison.TabIndex = 4;
            this.divison.Text = "/";
            this.divison.UseVisualStyleBackColor = true;
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(219, 185);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(63, 58);
            this.multi.TabIndex = 8;
            this.multi.Text = "x";
            this.multi.UseVisualStyleBackColor = true;
            // 
            // but9
            // 
            this.but9.Location = new System.Drawing.Point(150, 185);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(63, 58);
            this.but9.TabIndex = 7;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // but8
            // 
            this.but8.Location = new System.Drawing.Point(81, 185);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(63, 58);
            this.but8.TabIndex = 6;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but7
            // 
            this.but7.Location = new System.Drawing.Point(12, 185);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(63, 58);
            this.but7.TabIndex = 5;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(219, 249);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(63, 58);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // but6
            // 
            this.but6.Location = new System.Drawing.Point(150, 249);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(63, 58);
            this.but6.TabIndex = 11;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // but5
            // 
            this.but5.Location = new System.Drawing.Point(81, 249);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(63, 58);
            this.but5.TabIndex = 10;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(12, 249);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(63, 58);
            this.but4.TabIndex = 9;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(220, 313);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(63, 58);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(151, 313);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(63, 58);
            this.but3.TabIndex = 15;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(82, 313);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(63, 58);
            this.but2.TabIndex = 14;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(13, 313);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(63, 58);
            this.but1.TabIndex = 13;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(220, 377);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(63, 58);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            // 
            // deci
            // 
            this.deci.Location = new System.Drawing.Point(151, 377);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(63, 58);
            this.deci.TabIndex = 19;
            this.deci.Text = ".";
            this.deci.UseVisualStyleBackColor = true;
            this.deci.Click += new System.EventHandler(this.deci_Click);
            // 
            // but00
            // 
            this.but00.Location = new System.Drawing.Point(82, 377);
            this.but00.Name = "but00";
            this.but00.Size = new System.Drawing.Size(63, 58);
            this.but00.TabIndex = 18;
            this.but00.Text = "00";
            this.but00.UseVisualStyleBackColor = true;
            this.but00.Click += new System.EventHandler(this.but00_Click);
            // 
            // but0
            // 
            this.but0.Location = new System.Drawing.Point(13, 377);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(63, 58);
            this.but0.TabIndex = 17;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 440);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.but00);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.divison);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(308, 479);
            this.MinimumSize = new System.Drawing.Size(308, 479);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button divison;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button but00;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.TextBox textBox1;
    }
}

