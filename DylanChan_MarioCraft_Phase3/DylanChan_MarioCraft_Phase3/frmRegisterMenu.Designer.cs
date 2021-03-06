﻿namespace DylanChan_MarioCraft_Phase3
{
    partial class frmRegisterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterMenu));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoginPrompt = new System.Windows.Forms.Label();
            this.lblRegInstructions = new System.Windows.Forms.Label();
            this.radBtnShow = new System.Windows.Forms.RadioButton();
            this.btnRadHide = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(372, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(372, 195);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(484, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(484, 201);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(528, 258);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(720, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(720, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DylanChan_MarioCraft_Phase3.Properties.Resources.MarioCraftReg;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 345);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoginPrompt
            // 
            this.lblLoginPrompt.AutoSize = true;
            this.lblLoginPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginPrompt.ForeColor = System.Drawing.Color.White;
            this.lblLoginPrompt.Location = new System.Drawing.Point(557, 6);
            this.lblLoginPrompt.Name = "lblLoginPrompt";
            this.lblLoginPrompt.Size = new System.Drawing.Size(152, 13);
            this.lblLoginPrompt.TabIndex = 7;
            this.lblLoginPrompt.Text = "Click here to go to Login Menu";
            // 
            // lblRegInstructions
            // 
            this.lblRegInstructions.AutoSize = true;
            this.lblRegInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblRegInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegInstructions.ForeColor = System.Drawing.Color.White;
            this.lblRegInstructions.Location = new System.Drawing.Point(360, 101);
            this.lblRegInstructions.Name = "lblRegInstructions";
            this.lblRegInstructions.Size = new System.Drawing.Size(398, 17);
            this.lblRegInstructions.TabIndex = 8;
            this.lblRegInstructions.Text = "Please enter an Email address and Password for registeration";
            // 
            // radBtnShow
            // 
            this.radBtnShow.AutoSize = true;
            this.radBtnShow.BackColor = System.Drawing.Color.Transparent;
            this.radBtnShow.ForeColor = System.Drawing.Color.White;
            this.radBtnShow.Location = new System.Drawing.Point(669, 204);
            this.radBtnShow.Name = "radBtnShow";
            this.radBtnShow.Size = new System.Drawing.Size(52, 17);
            this.radBtnShow.TabIndex = 9;
            this.radBtnShow.TabStop = true;
            this.radBtnShow.Text = "Show";
            this.radBtnShow.UseVisualStyleBackColor = false;
            this.radBtnShow.CheckedChanged += new System.EventHandler(this.radBtnShow_CheckedChanged);
            // 
            // btnRadHide
            // 
            this.btnRadHide.AutoSize = true;
            this.btnRadHide.BackColor = System.Drawing.Color.Transparent;
            this.btnRadHide.ForeColor = System.Drawing.Color.White;
            this.btnRadHide.Location = new System.Drawing.Point(720, 204);
            this.btnRadHide.Name = "btnRadHide";
            this.btnRadHide.Size = new System.Drawing.Size(47, 17);
            this.btnRadHide.TabIndex = 10;
            this.btnRadHide.TabStop = true;
            this.btnRadHide.Text = "Hide";
            this.btnRadHide.UseVisualStyleBackColor = false;
            this.btnRadHide.CheckedChanged += new System.EventHandler(this.btnRadHide_CheckedChanged);
            // 
            // frmRegisterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DylanChan_MarioCraft_Phase3.Properties.Resources.Mario_Wallpaper;
            this.ClientSize = new System.Drawing.Size(797, 347);
            this.Controls.Add(this.btnRadHide);
            this.Controls.Add(this.radBtnShow);
            this.Controls.Add(this.lblRegInstructions);
            this.Controls.Add(this.lblLoginPrompt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegisterMenu";
            this.Text = "frmRegisterMenu";
            this.Load += new System.EventHandler(this.frmRegisterMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLoginPrompt;
        private System.Windows.Forms.Label lblRegInstructions;
        private System.Windows.Forms.RadioButton radBtnShow;
        private System.Windows.Forms.RadioButton btnRadHide;
    }
}