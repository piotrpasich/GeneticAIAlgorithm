namespace GenApp
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
            this.pop1 = new System.Windows.Forms.TextBox();
            this.best = new System.Windows.Forms.TextBox();
            this.pop4 = new System.Windows.Forms.TextBox();
            this.pop3 = new System.Windows.Forms.TextBox();
            this.pop2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.val1 = new System.Windows.Forms.TextBox();
            this.bestVal = new System.Windows.Forms.TextBox();
            this.val4 = new System.Windows.Forms.TextBox();
            this.val3 = new System.Windows.Forms.TextBox();
            this.val2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.val5 = new System.Windows.Forms.TextBox();
            this.pop5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.averageVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pop1
            // 
            this.pop1.Location = new System.Drawing.Point(12, 34);
            this.pop1.Name = "pop1";
            this.pop1.Size = new System.Drawing.Size(162, 20);
            this.pop1.TabIndex = 0;
            // 
            // best
            // 
            this.best.Location = new System.Drawing.Point(12, 199);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(162, 20);
            this.best.TabIndex = 1;
            // 
            // pop4
            // 
            this.pop4.Location = new System.Drawing.Point(12, 112);
            this.pop4.Name = "pop4";
            this.pop4.Size = new System.Drawing.Size(162, 20);
            this.pop4.TabIndex = 2;
            // 
            // pop3
            // 
            this.pop3.Location = new System.Drawing.Point(12, 86);
            this.pop3.Name = "pop3";
            this.pop3.Size = new System.Drawing.Size(162, 20);
            this.pop3.TabIndex = 3;
            // 
            // pop2
            // 
            this.pop2.Location = new System.Drawing.Point(12, 60);
            this.pop2.Name = "pop2";
            this.pop2.Size = new System.Drawing.Size(162, 20);
            this.pop2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "populacja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ocena";
            // 
            // val1
            // 
            this.val1.Location = new System.Drawing.Point(206, 34);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(57, 20);
            this.val1.TabIndex = 7;
            // 
            // bestVal
            // 
            this.bestVal.Location = new System.Drawing.Point(206, 199);
            this.bestVal.Name = "bestVal";
            this.bestVal.Size = new System.Drawing.Size(57, 20);
            this.bestVal.TabIndex = 8;
            // 
            // val4
            // 
            this.val4.Location = new System.Drawing.Point(206, 112);
            this.val4.Name = "val4";
            this.val4.Size = new System.Drawing.Size(57, 20);
            this.val4.TabIndex = 9;
            // 
            // val3
            // 
            this.val3.Location = new System.Drawing.Point(206, 86);
            this.val3.Name = "val3";
            this.val3.Size = new System.Drawing.Size(57, 20);
            this.val3.TabIndex = 10;
            // 
            // val2
            // 
            this.val2.Location = new System.Drawing.Point(206, 60);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(57, 20);
            this.val2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Od pocz¹tku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Nast populacja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Najlepszy osobnik we wszystkich pokoleniach";
            // 
            // val5
            // 
            this.val5.Location = new System.Drawing.Point(206, 142);
            this.val5.Name = "val5";
            this.val5.Size = new System.Drawing.Size(57, 20);
            this.val5.TabIndex = 16;
            // 
            // pop5
            // 
            this.pop5.Location = new System.Drawing.Point(12, 142);
            this.pop5.Name = "pop5";
            this.pop5.Size = new System.Drawing.Size(162, 20);
            this.pop5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // averageVal
            // 
            this.averageVal.Location = new System.Drawing.Point(206, 267);
            this.averageVal.Name = "averageVal";
            this.averageVal.Size = new System.Drawing.Size(56, 20);
            this.averageVal.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.averageVal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.val5);
            this.Controls.Add(this.pop5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.val2);
            this.Controls.Add(this.val3);
            this.Controls.Add(this.val4);
            this.Controls.Add(this.bestVal);
            this.Controls.Add(this.val1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pop2);
            this.Controls.Add(this.pop3);
            this.Controls.Add(this.pop4);
            this.Controls.Add(this.best);
            this.Controls.Add(this.pop1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pop1;
        private System.Windows.Forms.TextBox best;
        private System.Windows.Forms.TextBox pop4;
        private System.Windows.Forms.TextBox pop3;
        private System.Windows.Forms.TextBox pop2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox val1;
        private System.Windows.Forms.TextBox bestVal;
        private System.Windows.Forms.TextBox val4;
        private System.Windows.Forms.TextBox val3;
        private System.Windows.Forms.TextBox val2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox val5;
        private System.Windows.Forms.TextBox pop5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox averageVal;
    }
}

