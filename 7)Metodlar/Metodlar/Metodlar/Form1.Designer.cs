namespace Metodlar
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Tem = new System.Windows.Forms.Button();
            this.Rem = new System.Windows.Forms.Button();
            this.Dol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 37);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 37);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 300);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 37);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(75, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 37);
            this.textBox4.TabIndex = 2;
            // 
            // Tem
            // 
            this.Tem.Location = new System.Drawing.Point(404, 64);
            this.Tem.Name = "Tem";
            this.Tem.Size = new System.Drawing.Size(223, 34);
            this.Tem.TabIndex = 4;
            this.Tem.Text = "Temizle";
            this.Tem.UseVisualStyleBackColor = true;
            this.Tem.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rem
            // 
            this.Rem.Location = new System.Drawing.Point(404, 142);
            this.Rem.Name = "Rem";
            this.Rem.Size = new System.Drawing.Size(223, 34);
            this.Rem.TabIndex = 5;
            this.Rem.Text = "Renklendir";
            this.Rem.UseVisualStyleBackColor = true;
            this.Rem.Click += new System.EventHandler(this.Rem_Click);
            // 
            // Dol
            // 
            this.Dol.Location = new System.Drawing.Point(404, 223);
            this.Dol.Name = "Dol";
            this.Dol.Size = new System.Drawing.Size(223, 34);
            this.Dol.TabIndex = 6;
            this.Dol.Text = "Doldur";
            this.Dol.UseVisualStyleBackColor = true;
            this.Dol.Click += new System.EventHandler(this.Dol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 437);
            this.Controls.Add(this.Dol);
            this.Controls.Add(this.Rem);
            this.Controls.Add(this.Tem);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Tem;
        private System.Windows.Forms.Button Rem;
        private System.Windows.Forms.Button Dol;
    }
}

