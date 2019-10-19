namespace Morse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMorse = new System.Windows.Forms.TextBox();
            this.btnMorse = new System.Windows.Forms.Button();
            this.lbMorse = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakterler :";
            // 
            // txtMorse
            // 
            this.txtMorse.Location = new System.Drawing.Point(255, 61);
            this.txtMorse.Name = "txtMorse";
            this.txtMorse.Size = new System.Drawing.Size(100, 22);
            this.txtMorse.TabIndex = 1;
            // 
            // btnMorse
            // 
            this.btnMorse.Location = new System.Drawing.Point(228, 111);
            this.btnMorse.Name = "btnMorse";
            this.btnMorse.Size = new System.Drawing.Size(127, 40);
            this.btnMorse.TabIndex = 2;
            this.btnMorse.Text = "Dönüştür";
            this.btnMorse.UseVisualStyleBackColor = true;
            this.btnMorse.Click += new System.EventHandler(this.btnMorse_Click);
            // 
            // lbMorse
            // 
            this.lbMorse.FormattingEnabled = true;
            this.lbMorse.ItemHeight = 16;
            this.lbMorse.Location = new System.Drawing.Point(160, 178);
            this.lbMorse.Name = "lbMorse";
            this.lbMorse.Size = new System.Drawing.Size(236, 148);
            this.lbMorse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "LÜTFEN YAZARKEN BÜYÜK HARFLERİ KULLANALIM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMorse);
            this.Controls.Add(this.btnMorse);
            this.Controls.Add(this.txtMorse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMorse;
        private System.Windows.Forms.Button btnMorse;
        private System.Windows.Forms.ListBox lbMorse;
        private System.Windows.Forms.Label label2;
    }
}

