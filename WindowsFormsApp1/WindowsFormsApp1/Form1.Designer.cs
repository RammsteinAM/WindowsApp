namespace WindowsFormsApp1
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.button1 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iAgree = new System.Windows.Forms.CheckBox();
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
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(79, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 154);
            this.button1.TabIndex = 4;
            this.button1.Text = "Մուտք";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(112, 17);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(135, 20);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.Leave += new System.EventHandler(this.usernameLeave);
            // 
            // password
            // 
            this.password.Enabled = false;
            this.password.Location = new System.Drawing.Point(112, 48);
            this.password.Name = "password";
            this.password.PasswordChar = '☺';
            this.password.Size = new System.Drawing.Size(135, 20);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged_1);
            this.password.Leave += new System.EventHandler(this.passwordLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Օգտվողի անուն";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Գաղտնաբառ";
            // 
            // iAgree
            // 
            this.iAgree.AutoSize = true;
            this.iAgree.Enabled = false;
            this.iAgree.Location = new System.Drawing.Point(47, 80);
            this.iAgree.Name = "iAgree";
            this.iAgree.Size = new System.Drawing.Size(168, 17);
            this.iAgree.TabIndex = 3;
            this.iAgree.Text = "Ընդունում եմ պայմանները։";
            this.iAgree.UseVisualStyleBackColor = true;
            this.iAgree.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // usernameOK
            // 
            this.usernameOK.Image = global::WindowsFormsApp1.Properties.Resources.green;
            this.usernameOK.Location = new System.Drawing.Point(253, 20);
            this.usernameOK.Name = "usernameOK";
            this.usernameOK.Size = new System.Drawing.Size(15, 15);
            this.usernameOK.TabIndex = 5;
            this.usernameOK.TabStop = false;
            this.usernameOK.Visible = false;
            // 
            // passwordOK
            // 
            this.passwordOK.Image = global::WindowsFormsApp1.Properties.Resources.green;
            this.passwordOK.Location = new System.Drawing.Point(253, 51);
            this.passwordOK.Name = "passwordOK";
            this.passwordOK.Size = new System.Drawing.Size(15, 15);
            this.passwordOK.TabIndex = 5;
            this.passwordOK.TabStop = false;
            this.passwordOK.Visible = false;
            // 
            // usernameWrong
            // 
            this.usernameWrong.Image = global::WindowsFormsApp1.Properties.Resources.red;
            this.usernameWrong.Location = new System.Drawing.Point(253, 20);
            this.usernameWrong.Name = "usernameWrong";
            this.usernameWrong.Size = new System.Drawing.Size(15, 15);
            this.usernameWrong.TabIndex = 5;
            this.usernameWrong.TabStop = false;
            this.usernameWrong.Visible = false;
            // 
            // passwordWrong
            // 
            this.passwordWrong.Image = global::WindowsFormsApp1.Properties.Resources.red;
            this.passwordWrong.Location = new System.Drawing.Point(253, 51);
            this.passwordWrong.Name = "passwordWrong";
            this.passwordWrong.Size = new System.Drawing.Size(15, 15);
            this.passwordWrong.TabIndex = 5;
            this.passwordWrong.TabStop = false;
            this.passwordWrong.Visible = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.passwordWrong);
            this.Controls.Add(this.usernameWrong);
            this.Controls.Add(this.passwordOK);
            this.Controls.Add(this.usernameOK);
            this.Controls.Add(this.iAgree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Text = "Մուտք";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usernameOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox iAgree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox usernameOK;
        private System.Windows.Forms.PictureBox passwordOK;
        private System.Windows.Forms.PictureBox usernameWrong;
        private System.Windows.Forms.PictureBox passwordWrong;
    }
}

