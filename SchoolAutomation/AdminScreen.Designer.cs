namespace SchoolAutomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.button_New_Registration = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_List = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.label_Teacher_FirstName = new System.Windows.Forms.Label();
            this.textBox_Teacher_ID = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_Address = new System.Windows.Forms.TextBox();
            this.button_Teacher_Save = new System.Windows.Forms.Button();
            this.textBox_Teacher_Password = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_NewPassword = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.button_ChangePassword = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Teacher_Branch = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_FirstName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_New_Registration
            // 
            this.button_New_Registration.Location = new System.Drawing.Point(696, 294);
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
            this.listView1.Location = new System.Drawing.Point(18, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 230);
            this.listView1.TabIndex = 2;
            this.listView1.TileSize = new System.Drawing.Size(271, 36);
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
            this.button_List.Location = new System.Drawing.Point(579, 294);
            this.button_List.Name = "button_List";
            this.button_List.Size = new System.Drawing.Size(98, 28);
            this.button_List.TabIndex = 3;
            this.button_List.Text = "Listele";
            this.button_List.UseVisualStyleBackColor = true;
            this.button_List.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(18, 294);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(98, 28);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "Düzenle";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label_Teacher_FirstName
            // 
            this.label_Teacher_FirstName.AutoSize = true;
            this.label_Teacher_FirstName.Location = new System.Drawing.Point(15, 19);
            this.label_Teacher_FirstName.Name = "label_Teacher_FirstName";
            this.label_Teacher_FirstName.Size = new System.Drawing.Size(44, 16);
            this.label_Teacher_FirstName.TabIndex = 6;
            this.label_Teacher_FirstName.Text = "label1";
            // 
            // textBox_Teacher_ID
            // 
            this.textBox_Teacher_ID.Location = new System.Drawing.Point(18, 49);
            this.textBox_Teacher_ID.Name = "textBox_Teacher_ID";
            this.textBox_Teacher_ID.ReadOnly = true;
            this.textBox_Teacher_ID.Size = new System.Drawing.Size(166, 22);
            this.textBox_Teacher_ID.TabIndex = 7;
            this.textBox_Teacher_ID.TextChanged += new System.EventHandler(this.textBox_Teacher_ID_TextChanged);
            // 
            // textBox_Teacher_Address
            // 
            this.textBox_Teacher_Address.Location = new System.Drawing.Point(18, 265);
            this.textBox_Teacher_Address.Name = "textBox_Teacher_Address";
            this.textBox_Teacher_Address.Size = new System.Drawing.Size(166, 22);
            this.textBox_Teacher_Address.TabIndex = 8;
            this.textBox_Teacher_Address.TextChanged += new System.EventHandler(this.textBox_Teacher_Address_TextChanged);
            // 
            // button_Teacher_Save
            // 
            this.button_Teacher_Save.Location = new System.Drawing.Point(86, 287);
            this.button_Teacher_Save.Name = "button_Teacher_Save";
            this.button_Teacher_Save.Size = new System.Drawing.Size(98, 28);
            this.button_Teacher_Save.TabIndex = 9;
            this.button_Teacher_Save.Text = "Kaydet";
            this.button_Teacher_Save.UseVisualStyleBackColor = true;
            this.button_Teacher_Save.Click += new System.EventHandler(this.button_Teacher_Save_Click);
            // 
            // textBox_Teacher_Password
            // 
            this.textBox_Teacher_Password.Location = new System.Drawing.Point(21, 45);
            this.textBox_Teacher_Password.Name = "textBox_Teacher_Password";
            this.textBox_Teacher_Password.PasswordChar = '*';
            this.textBox_Teacher_Password.Size = new System.Drawing.Size(166, 22);
            this.textBox_Teacher_Password.TabIndex = 10;
            // 
            // textBox_Teacher_NewPassword
            // 
            this.textBox_Teacher_NewPassword.Location = new System.Drawing.Point(21, 98);
            this.textBox_Teacher_NewPassword.Name = "textBox_Teacher_NewPassword";
            this.textBox_Teacher_NewPassword.PasswordChar = '*';
            this.textBox_Teacher_NewPassword.Size = new System.Drawing.Size(166, 22);
            this.textBox_Teacher_NewPassword.TabIndex = 11;
            // 
            // textBox_Teacher_ConfirmNewPassword
            // 
            this.textBox_Teacher_ConfirmNewPassword.Location = new System.Drawing.Point(21, 149);
            this.textBox_Teacher_ConfirmNewPassword.Name = "textBox_Teacher_ConfirmNewPassword";
            this.textBox_Teacher_ConfirmNewPassword.PasswordChar = '*';
            this.textBox_Teacher_ConfirmNewPassword.Size = new System.Drawing.Size(166, 22);
            this.textBox_Teacher_ConfirmNewPassword.TabIndex = 12;
            // 
            // button_ChangePassword
            // 
            this.button_ChangePassword.Location = new System.Drawing.Point(89, 177);
            this.button_ChangePassword.Name = "button_ChangePassword";
            this.button_ChangePassword.Size = new System.Drawing.Size(98, 28);
            this.button_ChangePassword.TabIndex = 13;
            this.button_ChangePassword.Text = "Değiştir";
            this.button_ChangePassword.UseVisualStyleBackColor = true;
            this.button_ChangePassword.Click += new System.EventHandler(this.button_ChangePassword_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Teacher_Branch);
            this.groupBox1.Controls.Add(this.textBox_Teacher_LastName);
            this.groupBox1.Controls.Add(this.textBox_Teacher_FirstName);
            this.groupBox1.Controls.Add(this.textBox_Teacher_Address);
            this.groupBox1.Controls.Add(this.textBox_Teacher_ID);
            this.groupBox1.Controls.Add(this.button_Teacher_Save);
            this.groupBox1.Location = new System.Drawing.Point(12, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 333);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Branş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kimlik Numarası";
            // 
            // textBox_Teacher_Branch
            // 
            this.textBox_Teacher_Branch.Location = new System.Drawing.Point(18, 211);
            this.textBox_Teacher_Branch.Name = "textBox_Teacher_Branch";
            this.textBox_Teacher_Branch.Size = new System.Drawing.Size(166, 22);
            this.textBox_Teacher_Branch.TabIndex = 12;
            // 
            // textBox_Teacher_LastName
            // 
            this.textBox_Teacher_LastName.Location = new System.Drawing.Point(18, 157);
            this.textBox_Teacher_LastName.Name = "textBox_Teacher_LastName";
            this.textBox_Teacher_LastName.Size = new System.Drawing.Size(166, 22);
            this.textBox_Teacher_LastName.TabIndex = 11;
            // 
            // textBox_Teacher_FirstName
            // 
            this.textBox_Teacher_FirstName.Location = new System.Drawing.Point(18, 103);
            this.textBox_Teacher_FirstName.Name = "textBox_Teacher_FirstName";
            this.textBox_Teacher_FirstName.Size = new System.Drawing.Size(166, 22);
            this.textBox_Teacher_FirstName.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.button_New_Registration);
            this.panel1.Controls.Add(this.button_List);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.label_Teacher_FirstName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 338);
            this.panel1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_ChangePassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_Teacher_ConfirmNewPassword);
            this.groupBox2.Controls.Add(this.textBox_Teacher_NewPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Teacher_Password);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(242, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 215);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şifre Değiştir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Şifreni Onayla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Yeni Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Eski Şifre";
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminScreen";
            this.Text = "Öğretmen Ekranı";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label_Teacher_FirstName;
        private System.Windows.Forms.TextBox textBox_Teacher_ID;
        private System.Windows.Forms.TextBox textBox_Teacher_Address;
        private System.Windows.Forms.Button button_Teacher_Save;
        private System.Windows.Forms.TextBox textBox_Teacher_Password;
        private System.Windows.Forms.TextBox textBox_Teacher_NewPassword;
        private System.Windows.Forms.TextBox textBox_Teacher_ConfirmNewPassword;
        private System.Windows.Forms.Button button_ChangePassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Teacher_Branch;
        private System.Windows.Forms.TextBox textBox_Teacher_LastName;
        private System.Windows.Forms.TextBox textBox_Teacher_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}