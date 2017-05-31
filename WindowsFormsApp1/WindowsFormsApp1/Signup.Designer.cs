namespace WindowsFormsApp1
{
    partial class SignupForm
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.signupFullName = new System.Windows.Forms.TextBox();
            this.signupUserName = new System.Windows.Forms.TextBox();
            this.signupPassword = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.iAgree = new System.Windows.Forms.CheckBox();
            this.termsLink = new System.Windows.Forms.LinkLabel();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.signupRePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.ButtonCancel.FlatAppearance.BorderSize = 3;
            this.ButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.ButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(32, 210);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(100, 30);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Չեղարկել";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // signupFullName
            // 
            this.signupFullName.Location = new System.Drawing.Point(133, 31);
            this.signupFullName.Name = "signupFullName";
            this.signupFullName.Size = new System.Drawing.Size(135, 20);
            this.signupFullName.TabIndex = 1;
            // 
            // signupUserName
            // 
            this.signupUserName.Location = new System.Drawing.Point(133, 64);
            this.signupUserName.Name = "signupUserName";
            this.signupUserName.Size = new System.Drawing.Size(135, 20);
            this.signupUserName.TabIndex = 2;
            // 
            // signupPassword
            // 
            this.signupPassword.Location = new System.Drawing.Point(133, 97);
            this.signupPassword.Name = "signupPassword";
            this.signupPassword.Size = new System.Drawing.Size(135, 20);
            this.signupPassword.TabIndex = 3;
            this.signupPassword.UseSystemPasswordChar = true;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(10, 34);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(95, 13);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Անուն ազգանուն";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(10, 67);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(73, 13);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "Մուտքանուն";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(10, 100);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Գաղտնաբառ";
            // 
            // iAgree
            // 
            this.iAgree.AutoSize = true;
            this.iAgree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.iAgree.Location = new System.Drawing.Point(15, 174);
            this.iAgree.Name = "iAgree";
            this.iAgree.Size = new System.Drawing.Size(102, 18);
            this.iAgree.TabIndex = 5;
            this.iAgree.Text = "Ընդունում եմ";
            this.iAgree.UseVisualStyleBackColor = true;
            this.iAgree.CheckedChanged += new System.EventHandler(this.iAgree_CheckedChanged);
            // 
            // termsLink
            // 
            this.termsLink.AutoSize = true;
            this.termsLink.Location = new System.Drawing.Point(103, 175);
            this.termsLink.Name = "termsLink";
            this.termsLink.Size = new System.Drawing.Size(76, 13);
            this.termsLink.TabIndex = 6;
            this.termsLink.TabStop = true;
            this.termsLink.Text = "պայմանները։";
            this.termsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowTerms);
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.Enabled = false;
            this.ButtonSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonSignUp.FlatAppearance.BorderSize = 3;
            this.ButtonSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.ButtonSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignUp.Location = new System.Drawing.Point(153, 210);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(100, 30);
            this.ButtonSignUp.TabIndex = 7;
            this.ButtonSignUp.Text = "Գրանցվել";
            this.ButtonSignUp.UseVisualStyleBackColor = true;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // signupRePassword
            // 
            this.signupRePassword.Location = new System.Drawing.Point(133, 133);
            this.signupRePassword.Name = "signupRePassword";
            this.signupRePassword.Size = new System.Drawing.Size(135, 20);
            this.signupRePassword.TabIndex = 4;
            this.signupRePassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Գաղտնաբառ (կրկնեք)";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.termsLink);
            this.Controls.Add(this.iAgree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.signupRePassword);
            this.Controls.Add(this.signupPassword);
            this.Controls.Add(this.signupUserName);
            this.Controls.Add(this.signupFullName);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSignUp);
            this.Name = "SignupForm";
            this.Text = "Գրանցում";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox signupFullName;
        private System.Windows.Forms.TextBox signupUserName;
        private System.Windows.Forms.TextBox signupPassword;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox iAgree;
        private System.Windows.Forms.LinkLabel termsLink;
        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.TextBox signupRePassword;
        private System.Windows.Forms.Label label1;
    }
}