namespace _PresentationLayer
{
    partial class Login
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.txtUserPas = new System.Windows.Forms.TextBox();
            this.lblUserPas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(167, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(60, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(192, 131);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 2;
            this.BtnEnter.Text = "Giriş";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // txtUserPas
            // 
            this.txtUserPas.Location = new System.Drawing.Point(167, 82);
            this.txtUserPas.Name = "txtUserPas";
            this.txtUserPas.Size = new System.Drawing.Size(100, 22);
            this.txtUserPas.TabIndex = 0;
            // 
            // lblUserPas
            // 
            this.lblUserPas.AutoSize = true;
            this.lblUserPas.Location = new System.Drawing.Point(60, 85);
            this.lblUserPas.Name = "lblUserPas";
            this.lblUserPas.Size = new System.Drawing.Size(37, 17);
            this.lblUserPas.TabIndex = 1;
            this.lblUserPas.Text = "Şifre";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 223);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.lblUserPas);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserPas);
            this.Controls.Add(this.txtUserName);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.TextBox txtUserPas;
        private System.Windows.Forms.Label lblUserPas;
    }
}