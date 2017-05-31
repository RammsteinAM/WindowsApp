namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonOpenSignUpForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameOK = new System.Windows.Forms.PictureBox();
            this.passwordOK = new System.Windows.Forms.PictureBox();
            this.usernameWrong = new System.Windows.Forms.PictureBox();
            this.passwordWrong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usernameOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenSignUpForm
            // 
            this.buttonOpenSignUpForm.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenSignUpForm.FlatAppearance.BorderSize = 3;
            this.buttonOpenSignUpForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOpenSignUpForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenSignUpForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSignUpForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpenSignUpForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpenSignUpForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOpenSignUpForm.Location = new System.Drawing.Point(192, 12);
            this.buttonOpenSignUpForm.Name = "buttonOpenSignUpForm";
            this.buttonOpenSignUpForm.Size = new System.Drawing.Size(80, 26);
            this.buttonOpenSignUpForm.TabIndex = 4;
            this.buttonOpenSignUpForm.Text = "Գրանցվել";
            this.buttonOpenSignUpForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOpenSignUpForm.UseVisualStyleBackColor = true;
            this.buttonOpenSignUpForm.Click += new System.EventHandler(this.openSignUp);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(73, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Մուտք";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(111, 59);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(135, 20);
            this.loginUsername.TabIndex = 1;
            this.loginUsername.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.loginUsername.LostFocus += new System.EventHandler(this.usernameLostFocus);
            // 
            // loginPassword
            // 
            this.loginPassword.Enabled = false;
            this.loginPassword.Location = new System.Drawing.Point(111, 97);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(135, 20);
            this.loginPassword.TabIndex = 2;
            this.loginPassword.UseSystemPasswordChar = true;
            this.loginPassword.TextChanged += new System.EventHandler(this.password_TextChanged_1);
            this.loginPassword.GotFocus += new System.EventHandler(this.passwordGotFocus);
            this.loginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginPassword_KeyDown);
            this.loginPassword.Leave += new System.EventHandler(this.passwordLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Օգտվողի անուն";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Գաղտնաբառ";
            // 
            // usernameOK
            // 
            this.usernameOK.Image = global::WindowsFormsApp1.Properties.Resources.green;
            this.usernameOK.Location = new System.Drawing.Point(252, 62);
            this.usernameOK.Name = "usernameOK";
            this.usernameOK.Size = new System.Drawing.Size(15, 15);
            this.usernameOK.TabIndex = 5;
            this.usernameOK.TabStop = false;
            this.usernameOK.Visible = false;
            // 
            // passwordOK
            // 
            this.passwordOK.Image = global::WindowsFormsApp1.Properties.Resources.green;
            this.passwordOK.Location = new System.Drawing.Point(252, 100);
            this.passwordOK.Name = "passwordOK";
            this.passwordOK.Size = new System.Drawing.Size(15, 15);
            this.passwordOK.TabIndex = 5;
            this.passwordOK.TabStop = false;
            this.passwordOK.Visible = false;
            // 
            // usernameWrong
            // 
            this.usernameWrong.Image = global::WindowsFormsApp1.Properties.Resources.red;
            this.usernameWrong.Location = new System.Drawing.Point(252, 62);
            this.usernameWrong.Name = "usernameWrong";
            this.usernameWrong.Size = new System.Drawing.Size(15, 15);
            this.usernameWrong.TabIndex = 5;
            this.usernameWrong.TabStop = false;
            this.usernameWrong.Visible = false;
            // 
            // passwordWrong
            // 
            this.passwordWrong.Image = global::WindowsFormsApp1.Properties.Resources.red;
            this.passwordWrong.Location = new System.Drawing.Point(252, 100);
            this.passwordWrong.Name = "passwordWrong";
            this.passwordWrong.Size = new System.Drawing.Size(15, 15);
            this.passwordWrong.TabIndex = 5;
            this.passwordWrong.TabStop = false;
            this.passwordWrong.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.passwordWrong);
            this.Controls.Add(this.usernameWrong);
            this.Controls.Add(this.passwordOK);
            this.Controls.Add(this.usernameOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.buttonOpenSignUpForm);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Մուտք";
            ((System.ComponentModel.ISupportInitialize)(this.usernameOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenSignUpForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox usernameOK;
        private System.Windows.Forms.PictureBox passwordOK;
        private System.Windows.Forms.PictureBox usernameWrong;
        private System.Windows.Forms.PictureBox passwordWrong;
    }
}

