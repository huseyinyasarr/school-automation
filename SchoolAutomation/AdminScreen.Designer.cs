﻿namespace SchoolAutomation
{
    partial class AdminScreen
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
            this.button_New_Registration = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_List = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.Hoşgeldin = new System.Windows.Forms.Label();
            this.label_Teacher_FirstName = new System.Windows.Forms.Label();
            this.textBox_Teacher_ID = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_Address = new System.Windows.Forms.TextBox();
            this.button_Teacher_Save = new System.Windows.Forms.Button();
            this.textBox_Teacher_Password = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_NewPassword = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.button_ChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_New_Registration
            // 
            this.button_New_Registration.Location = new System.Drawing.Point(690, 348);
            this.button_New_Registration.Name = "button_New_Registration";
            this.button_New_Registration.Size = new System.Drawing.Size(98, 28);
            this.button_New_Registration.TabIndex = 1;
            this.button_New_Registration.Text = "Yeni Kayıt";
            this.button_New_Registration.UseVisualStyleBackColor = true;
            this.button_New_Registration.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 230);
            this.listView1.TabIndex = 2;
            this.listView1.TileSize = new System.Drawing.Size(270, 36);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kimlik Numarası";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sınıfı";
            this.columnHeader4.Width = 61;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 259;
            // 
            // button_List
            // 
            this.button_List.Location = new System.Drawing.Point(573, 348);
            this.button_List.Name = "button_List";
            this.button_List.Size = new System.Drawing.Size(98, 28);
            this.button_List.TabIndex = 3;
            this.button_List.Text = "Listele";
            this.button_List.UseVisualStyleBackColor = true;
            this.button_List.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(12, 348);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(98, 28);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "Düzenle";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // Hoşgeldin
            // 
            this.Hoşgeldin.AutoSize = true;
            this.Hoşgeldin.Location = new System.Drawing.Point(15, 9);
            this.Hoşgeldin.Name = "Hoşgeldin";
            this.Hoşgeldin.Size = new System.Drawing.Size(44, 16);
            this.Hoşgeldin.TabIndex = 5;
            this.Hoşgeldin.Text = "label1";
            // 
            // label_Teacher_FirstName
            // 
            this.label_Teacher_FirstName.AutoSize = true;
            this.label_Teacher_FirstName.Location = new System.Drawing.Point(66, 9);
            this.label_Teacher_FirstName.Name = "label_Teacher_FirstName";
            this.label_Teacher_FirstName.Size = new System.Drawing.Size(44, 16);
            this.label_Teacher_FirstName.TabIndex = 6;
            this.label_Teacher_FirstName.Text = "label1";
            // 
            // textBox_Teacher_ID
            // 
            this.textBox_Teacher_ID.Location = new System.Drawing.Point(12, 40);
            this.textBox_Teacher_ID.Name = "textBox_Teacher_ID";
            this.textBox_Teacher_ID.ReadOnly = true;
            this.textBox_Teacher_ID.Size = new System.Drawing.Size(100, 22);
            this.textBox_Teacher_ID.TabIndex = 7;
            // 
            // textBox_Teacher_Address
            // 
            this.textBox_Teacher_Address.Location = new System.Drawing.Point(241, 40);
            this.textBox_Teacher_Address.Name = "textBox_Teacher_Address";
            this.textBox_Teacher_Address.Size = new System.Drawing.Size(100, 22);
            this.textBox_Teacher_Address.TabIndex = 8;
            // 
            // button_Teacher_Save
            // 
            this.button_Teacher_Save.Location = new System.Drawing.Point(288, 74);
            this.button_Teacher_Save.Name = "button_Teacher_Save";
            this.button_Teacher_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Teacher_Save.TabIndex = 9;
            this.button_Teacher_Save.Text = "Kaydet";
            this.button_Teacher_Save.UseVisualStyleBackColor = true;
            this.button_Teacher_Save.Click += new System.EventHandler(this.button_Teacher_Save_Click);
            // 
            // textBox_Teacher_Password
            // 
            this.textBox_Teacher_Password.Location = new System.Drawing.Point(484, 13);
            this.textBox_Teacher_Password.Name = "textBox_Teacher_Password";
            this.textBox_Teacher_Password.Size = new System.Drawing.Size(100, 22);
            this.textBox_Teacher_Password.TabIndex = 10;
            // 
            // textBox_Teacher_NewPassword
            // 
            this.textBox_Teacher_NewPassword.Location = new System.Drawing.Point(484, 42);
            this.textBox_Teacher_NewPassword.Name = "textBox_Teacher_NewPassword";
            this.textBox_Teacher_NewPassword.Size = new System.Drawing.Size(100, 22);
            this.textBox_Teacher_NewPassword.TabIndex = 11;
            // 
            // textBox_Teacher_ConfirmNewPassword
            // 
            this.textBox_Teacher_ConfirmNewPassword.Location = new System.Drawing.Point(484, 71);
            this.textBox_Teacher_ConfirmNewPassword.Name = "textBox_Teacher_ConfirmNewPassword";
            this.textBox_Teacher_ConfirmNewPassword.Size = new System.Drawing.Size(100, 22);
            this.textBox_Teacher_ConfirmNewPassword.TabIndex = 12;
            // 
            // button_ChangePassword
            // 
            this.button_ChangePassword.Location = new System.Drawing.Point(636, 74);
            this.button_ChangePassword.Name = "button_ChangePassword";
            this.button_ChangePassword.Size = new System.Drawing.Size(75, 23);
            this.button_ChangePassword.TabIndex = 13;
            this.button_ChangePassword.Text = "Değiştir";
            this.button_ChangePassword.UseVisualStyleBackColor = true;
            this.button_ChangePassword.Click += new System.EventHandler(this.button_ChangePassword_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.button_ChangePassword);
            this.Controls.Add(this.textBox_Teacher_ConfirmNewPassword);
            this.Controls.Add(this.textBox_Teacher_NewPassword);
            this.Controls.Add(this.textBox_Teacher_Password);
            this.Controls.Add(this.button_Teacher_Save);
            this.Controls.Add(this.textBox_Teacher_Address);
            this.Controls.Add(this.textBox_Teacher_ID);
            this.Controls.Add(this.label_Teacher_FirstName);
            this.Controls.Add(this.Hoşgeldin);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_List);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_New_Registration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_New_Registration;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label Hoşgeldin;
        private System.Windows.Forms.Label label_Teacher_FirstName;
        private System.Windows.Forms.TextBox textBox_Teacher_ID;
        private System.Windows.Forms.TextBox textBox_Teacher_Address;
        private System.Windows.Forms.Button button_Teacher_Save;
        private System.Windows.Forms.TextBox textBox_Teacher_Password;
        private System.Windows.Forms.TextBox textBox_Teacher_NewPassword;
        private System.Windows.Forms.TextBox textBox_Teacher_ConfirmNewPassword;
        private System.Windows.Forms.Button button_ChangePassword;
    }
}