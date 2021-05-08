
namespace matematyka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butSuma = new System.Windows.Forms.Button();
            this.butIloczyn = new System.Windows.Forms.Button();
            this.butWyjscie = new System.Windows.Forms.Button();
            this.textWynik = new System.Windows.Forms.TextBox();
            this.textZ = new System.Windows.Forms.TextBox();
            this.textY = new System.Windows.Forms.TextBox();
            this.textX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSuma
            // 
            this.butSuma.Location = new System.Drawing.Point(498, 116);
            this.butSuma.Name = "butSuma";
            this.butSuma.Size = new System.Drawing.Size(75, 23);
            this.butSuma.TabIndex = 0;
            this.butSuma.Text = "Suma";
            this.butSuma.UseVisualStyleBackColor = true;
            this.butSuma.Click += new System.EventHandler(this.butSuma_Click);
            // 
            // butIloczyn
            // 
            this.butIloczyn.Location = new System.Drawing.Point(498, 182);
            this.butIloczyn.Name = "butIloczyn";
            this.butIloczyn.Size = new System.Drawing.Size(75, 23);
            this.butIloczyn.TabIndex = 1;
            this.butIloczyn.Text = "Iloczyn";
            this.butIloczyn.UseVisualStyleBackColor = true;
            this.butIloczyn.Click += new System.EventHandler(this.butIloczyn_Click);
            // 
            // butWyjscie
            // 
            this.butWyjscie.Location = new System.Drawing.Point(498, 251);
            this.butWyjscie.Name = "butWyjscie";
            this.butWyjscie.Size = new System.Drawing.Size(75, 23);
            this.butWyjscie.TabIndex = 2;
            this.butWyjscie.Text = "Wyjscie";
            this.butWyjscie.UseVisualStyleBackColor = true;
            this.butWyjscie.Click += new System.EventHandler(this.butWyjscie_Click);
            // 
            // textWynik
            // 
            this.textWynik.Location = new System.Drawing.Point(277, 291);
            this.textWynik.Name = "textWynik";
            this.textWynik.Size = new System.Drawing.Size(100, 23);
            this.textWynik.TabIndex = 3;
            // 
            // textZ
            // 
            this.textZ.Location = new System.Drawing.Point(277, 222);
            this.textZ.Name = "textZ";
            this.textZ.Size = new System.Drawing.Size(100, 23);
            this.textZ.TabIndex = 4;
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(277, 159);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(100, 23);
            this.textY.TabIndex = 5;
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(277, 90);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(100, 23);
            this.textX.TabIndex = 6;
            this.textX.TextChanged += new System.EventHandler(this.textX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "z";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.textZ);
            this.Controls.Add(this.textWynik);
            this.Controls.Add(this.butWyjscie);
            this.Controls.Add(this.butIloczyn);
            this.Controls.Add(this.butSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSuma;
        private System.Windows.Forms.Button butIloczyn;
        private System.Windows.Forms.Button butWyjscie;
        private System.Windows.Forms.TextBox textWynik;
        private System.Windows.Forms.TextBox textZ;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

