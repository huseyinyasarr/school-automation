﻿namespace SchoolAutomation
{
    partial class StudentScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Student_Save_Edit = new System.Windows.Forms.Button();
            this.label_Student_Address = new System.Windows.Forms.Label();
            this.label_Student_ID = new System.Windows.Forms.Label();
            this.textBox_Student_Address = new System.Windows.Forms.TextBox();
            this.textBox_Student_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Student_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.textBox_Student_NewPassword = new System.Windows.Forms.TextBox();
            this.textBox_Student_Password = new System.Windows.Forms.TextBox();
            this.label_Student_Password = new System.Windows.Forms.Label();
            this.button_ChangePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Student_Save_Edit);
            this.panel1.Controls.Add(this.label_Student_Address);
            this.panel1.Controls.Add(this.label_Student_ID);
            this.panel1.Controls.Add(this.textBox_Student_Address);
            this.panel1.Controls.Add(this.textBox_Student_ID);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 245);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hoşgeldin";
            // 
            // button_Student_Save_Edit
            // 
            this.button_Student_Save_Edit.Location = new System.Drawing.Point(126, 163);
            this.button_Student_Save_Edit.Name = "button_Student_Save_Edit";
            this.button_Student_Save_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Student_Save_Edit.TabIndex = 9;
            this.button_Student_Save_Edit.Text = "Kaydet";
            this.button_Student_Save_Edit.UseVisualStyleBackColor = true;
            this.button_Student_Save_Edit.Click += new System.EventHandler(this.button_Student_Save_Edit_Click);
            // 
            // label_Student_Address
            // 
            this.label_Student_Address.AutoSize = true;
            this.label_Student_Address.Location = new System.Drawing.Point(32, 99);
            this.label_Student_Address.Name = "label_Student_Address";
            this.label_Student_Address.Size = new System.Drawing.Size(43, 16);
            this.label_Student_Address.TabIndex = 5;
            this.label_Student_Address.Text = "Adres";
            // 
            // label_Student_ID
            // 
            this.label_Student_ID.AutoSize = true;
            this.label_Student_ID.Location = new System.Drawing.Point(35, 39);
            this.label_Student_ID.Name = "label_Student_ID";
            this.label_Student_ID.Size = new System.Drawing.Size(103, 16);
            this.label_Student_ID.TabIndex = 4;
            this.label_Student_ID.Text = "Kimlik Numarası";
            // 
            // textBox_Student_Address
            // 
            this.textBox_Student_Address.Location = new System.Drawing.Point(35, 119);
            this.textBox_Student_Address.Name = "textBox_Student_Address";
            this.textBox_Student_Address.Size = new System.Drawing.Size(166, 22);
            this.textBox_Student_Address.TabIndex = 2;
            // 
            // textBox_Student_ID
            // 
            this.textBox_Student_ID.Location = new System.Drawing.Point(35, 59);
            this.textBox_Student_ID.Name = "textBox_Student_ID";
            this.textBox_Student_ID.ReadOnly = true;
            this.textBox_Student_ID.Size = new System.Drawing.Size(166, 22);
            this.textBox_Student_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(235, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ChangePassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Student_ConfirmNewPassword);
            this.groupBox1.Controls.Add(this.textBox_Student_NewPassword);
            this.groupBox1.Controls.Add(this.textBox_Student_Password);
            this.groupBox1.Controls.Add(this.label_Student_Password);
            this.groupBox1.Location = new System.Drawing.Point(266, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 209);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Değiştir";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifreni Onayla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yeni Şifre";
            // 
            // textBox_Student_ConfirmNewPassword
            // 
            this.textBox_Student_ConfirmNewPassword.Location = new System.Drawing.Point(21, 142);
            this.textBox_Student_ConfirmNewPassword.Name = "textBox_Student_ConfirmNewPassword";
            this.textBox_Student_ConfirmNewPassword.PasswordChar = '*';
            this.textBox_Student_ConfirmNewPassword.Size = new System.Drawing.Size(166, 22);
            this.textBox_Student_ConfirmNewPassword.TabIndex = 8;
            // 
            // textBox_Student_NewPassword
            // 
            this.textBox_Student_NewPassword.Location = new System.Drawing.Point(21, 91);
            this.textBox_Student_NewPassword.Name = "textBox_Student_NewPassword";
            this.textBox_Student_NewPassword.PasswordChar = '*';
            this.textBox_Student_NewPassword.Size = new System.Drawing.Size(166, 22);
            this.textBox_Student_NewPassword.TabIndex = 7;
            // 
            // textBox_Student_Password
            // 
            this.textBox_Student_Password.Location = new System.Drawing.Point(21, 38);
            this.textBox_Student_Password.Name = "textBox_Student_Password";
            this.textBox_Student_Password.PasswordChar = '*';
            this.textBox_Student_Password.Size = new System.Drawing.Size(166, 22);
            this.textBox_Student_Password.TabIndex = 3;
            // 
            // label_Student_Password
            // 
            this.label_Student_Password.AutoSize = true;
            this.label_Student_Password.Location = new System.Drawing.Point(18, 19);
            this.label_Student_Password.Name = "label_Student_Password";
            this.label_Student_Password.Size = new System.Drawing.Size(63, 16);
            this.label_Student_Password.TabIndex = 6;
            this.label_Student_Password.Text = "Eski Şifre";
            // 
            // button_ChangePassword
            // 
            this.button_ChangePassword.Location = new System.Drawing.Point(112, 170);
            this.button_ChangePassword.Name = "button_ChangePassword";
            this.button_ChangePassword.Size = new System.Drawing.Size(75, 23);
            this.button_ChangePassword.TabIndex = 11;
            this.button_ChangePassword.Text = "Değiştir";
            this.button_ChangePassword.UseVisualStyleBackColor = true;
            this.button_ChangePassword.Click += new System.EventHandler(this.button_ChangePassword_Click);
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "StudentScreen";
            this.Text = "StudentScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentScreen_FormClosed);
            this.Load += new System.EventHandler(this.StudentScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Student_Password;
        private System.Windows.Forms.Label label_Student_Address;
        private System.Windows.Forms.Label label_Student_ID;
        private System.Windows.Forms.TextBox textBox_Student_Password;
        private System.Windows.Forms.TextBox textBox_Student_Address;
        private System.Windows.Forms.TextBox textBox_Student_ID;
        private System.Windows.Forms.Button button_Student_Save_Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Student_ConfirmNewPassword;
        private System.Windows.Forms.TextBox textBox_Student_NewPassword;
        private System.Windows.Forms.Button button_ChangePassword;
    }
}