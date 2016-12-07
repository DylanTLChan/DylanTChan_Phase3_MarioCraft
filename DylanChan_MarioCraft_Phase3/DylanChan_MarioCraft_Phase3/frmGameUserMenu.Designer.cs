namespace DylanChan_MarioCraft_Phase3
{
    partial class frmGameUserMenu
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
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRetriveEmail = new System.Windows.Forms.Label();
            this.lblRetrivePass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLogOut = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(406, 246);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 0;
            this.btnRetrieve.Text = "Retrive ";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(372, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblRetriveEmail
            // 
            this.lblRetriveEmail.AutoSize = true;
            this.lblRetriveEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblRetriveEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetriveEmail.Location = new System.Drawing.Point(260, 146);
            this.lblRetriveEmail.Name = "lblRetriveEmail";
            this.lblRetriveEmail.Size = new System.Drawing.Size(65, 25);
            this.lblRetriveEmail.TabIndex = 2;
            this.lblRetriveEmail.Text = "Email";
            // 
            // lblRetrivePass
            // 
            this.lblRetrivePass.AutoSize = true;
            this.lblRetrivePass.BackColor = System.Drawing.Color.Transparent;
            this.lblRetrivePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetrivePass.Location = new System.Drawing.Point(260, 187);
            this.lblRetrivePass.Name = "lblRetrivePass";
            this.lblRetrivePass.Size = new System.Drawing.Size(106, 25);
            this.lblRetrivePass.TabIndex = 3;
            this.lblRetrivePass.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(372, 192);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(720, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLogOut
            // 
            this.txtLogOut.Location = new System.Drawing.Point(2, 321);
            this.txtLogOut.Name = "txtLogOut";
            this.txtLogOut.Size = new System.Drawing.Size(75, 23);
            this.txtLogOut.TabIndex = 6;
            this.txtLogOut.Text = "Log Out";
            this.txtLogOut.UseVisualStyleBackColor = true;
            this.txtLogOut.Click += new System.EventHandler(this.txtLogOut_Click);
            // 
            // txtItem
            // 
            this.txtItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtItem.Location = new System.Drawing.Point(372, 100);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 7;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(260, 100);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(49, 25);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Item";
            // 
            // frmGameUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DylanChan_MarioCraft_Phase3.Properties.Resources.Mario_Wallpaper;
            this.ClientSize = new System.Drawing.Size(797, 347);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtLogOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRetrivePass);
            this.Controls.Add(this.lblRetriveEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRetrieve);
            this.Name = "frmGameUserMenu";
            this.Text = "GameUserMenu";
            this.Load += new System.EventHandler(this.GameUserMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRetriveEmail;
        private System.Windows.Forms.Label lblRetrivePass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button txtLogOut;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
    }
}