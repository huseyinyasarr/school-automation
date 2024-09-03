namespace SchoolAutomation
{
    partial class AutomationLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomationLoginForm));
            this.groupBox_Student_Login = new System.Windows.Forms.GroupBox();
            this.label_Student_Password = new System.Windows.Forms.Label();
            this.textBox_Student_Password = new System.Windows.Forms.TextBox();
            this.textBox_Student_ID = new System.Windows.Forms.TextBox();
            this.label_Student_ID = new System.Windows.Forms.Label();
            this.button_Student_Login = new System.Windows.Forms.Button();
            this.groupBox_Teacher_Login = new System.Windows.Forms.GroupBox();
            this.label_Teacher_Password = new System.Windows.Forms.Label();
            this.textBox_Teacher_Password = new System.Windows.Forms.TextBox();
            this.textBox_Teacher_ID = new System.Windows.Forms.TextBox();
            this.label_Teacher_ID = new System.Windows.Forms.Label();
            this.button_Teacher_Login = new System.Windows.Forms.Button();
            this.groupBox_Student_Login.SuspendLayout();
            this.groupBox_Teacher_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Student_Login
            // 
            this.groupBox_Student_Login.Controls.Add(this.label_Student_Password);
            this.groupBox_Student_Login.Controls.Add(this.textBox_Student_Password);
            this.groupBox_Student_Login.Controls.Add(this.textBox_Student_ID);
            this.groupBox_Student_Login.Controls.Add(this.label_Student_ID);
            this.groupBox_Student_Login.Controls.Add(this.button_Student_Login);
            this.groupBox_Student_Login.Location = new System.Drawing.Point(254, 12);
            this.groupBox_Student_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Student_Login.Name = "groupBox_Student_Login";
            this.groupBox_Student_Login.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Student_Login.Size = new System.Drawing.Size(234, 254);
            this.groupBox_Student_Login.TabIndex = 0;
            this.groupBox_Student_Login.TabStop = false;
            this.groupBox_Student_Login.Text = "Öğrenci Giriş";
            this.groupBox_Student_Login.Enter += new System.EventHandler(this.groupBox_Student_Login_Enter);
            // 
            // label_Student_Password
            // 
            this.label_Student_Password.AutoSize = true;
            this.label_Student_Password.Location = new System.Drawing.Point(101, 122);
            this.label_Student_Password.Name = "label_Student_Password";
            this.label_Student_Password.Size = new System.Drawing.Size(35, 16);
            this.label_Student_Password.TabIndex = 4;
            this.label_Student_Password.Text = "Şifre";
            // 
            // textBox_Student_Password
            // 
            this.textBox_Student_Password.Location = new System.Drawing.Point(34, 145);
            this.textBox_Student_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Student_Password.Name = "textBox_Student_Password";
            this.textBox_Student_Password.Size = new System.Drawing.Size(163, 24);
            this.textBox_Student_Password.TabIndex = 3;
            this.textBox_Student_Password.TextChanged += new System.EventHandler(this.textBox_Student_Password_TextChanged);
            // 
            // textBox_Student_ID
            // 
            this.textBox_Student_ID.Location = new System.Drawing.Point(34, 66);
            this.textBox_Student_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Student_ID.Name = "textBox_Student_ID";
            this.textBox_Student_ID.Size = new System.Drawing.Size(163, 24);
            this.textBox_Student_ID.TabIndex = 2;
            this.textBox_Student_ID.TextChanged += new System.EventHandler(this.textBox_Student_ID_TextChanged);
            // 
            // label_Student_ID
            // 
            this.label_Student_ID.AutoSize = true;
            this.label_Student_ID.Location = new System.Drawing.Point(71, 44);
            this.label_Student_ID.Name = "label_Student_ID";
            this.label_Student_ID.Size = new System.Drawing.Size(101, 16);
            this.label_Student_ID.TabIndex = 1;
            this.label_Student_ID.Text = "Kimlik Numarası";
            // 
            // button_Student_Login
            // 
            this.button_Student_Login.Location = new System.Drawing.Point(69, 188);
            this.button_Student_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Student_Login.Name = "button_Student_Login";
            this.button_Student_Login.Size = new System.Drawing.Size(98, 28);
            this.button_Student_Login.TabIndex = 0;
            this.button_Student_Login.Text = "Giriş";
            this.button_Student_Login.UseVisualStyleBackColor = true;
            this.button_Student_Login.Click += new System.EventHandler(this.button_Student_Login_Click);
            // 
            // groupBox_Teacher_Login
            // 
            this.groupBox_Teacher_Login.Controls.Add(this.label_Teacher_Password);
            this.groupBox_Teacher_Login.Controls.Add(this.textBox_Teacher_Password);
            this.groupBox_Teacher_Login.Controls.Add(this.textBox_Teacher_ID);
            this.groupBox_Teacher_Login.Controls.Add(this.label_Teacher_ID);
            this.groupBox_Teacher_Login.Controls.Add(this.button_Teacher_Login);
            this.groupBox_Teacher_Login.Location = new System.Drawing.Point(11, 12);
            this.groupBox_Teacher_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Teacher_Login.Name = "groupBox_Teacher_Login";
            this.groupBox_Teacher_Login.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Teacher_Login.Size = new System.Drawing.Size(234, 254);
            this.groupBox_Teacher_Login.TabIndex = 5;
            this.groupBox_Teacher_Login.TabStop = false;
            this.groupBox_Teacher_Login.Text = "Öğretmen Giriş";
            this.groupBox_Teacher_Login.Enter += new System.EventHandler(this.groupBox_Teacher_Login_Enter);
            // 
            // label_Teacher_Password
            // 
            this.label_Teacher_Password.AutoSize = true;
            this.label_Teacher_Password.Location = new System.Drawing.Point(101, 122);
            this.label_Teacher_Password.Name = "label_Teacher_Password";
            this.label_Teacher_Password.Size = new System.Drawing.Size(35, 16);
            this.label_Teacher_Password.TabIndex = 4;
            this.label_Teacher_Password.Text = "Şifre";
            // 
            // textBox_Teacher_Password
            // 
            this.textBox_Teacher_Password.Location = new System.Drawing.Point(34, 145);
            this.textBox_Teacher_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Teacher_Password.Name = "textBox_Teacher_Password";
            this.textBox_Teacher_Password.Size = new System.Drawing.Size(163, 24);
            this.textBox_Teacher_Password.TabIndex = 3;
            this.textBox_Teacher_Password.TextChanged += new System.EventHandler(this.textBox_Teacher_Password_TextChanged);
            // 
            // textBox_Teacher_ID
            // 
            this.textBox_Teacher_ID.Location = new System.Drawing.Point(34, 66);
            this.textBox_Teacher_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Teacher_ID.Name = "textBox_Teacher_ID";
            this.textBox_Teacher_ID.Size = new System.Drawing.Size(163, 24);
            this.textBox_Teacher_ID.TabIndex = 2;
            // 
            // label_Teacher_ID
            // 
            this.label_Teacher_ID.AutoSize = true;
            this.label_Teacher_ID.Location = new System.Drawing.Point(71, 44);
            this.label_Teacher_ID.Name = "label_Teacher_ID";
            this.label_Teacher_ID.Size = new System.Drawing.Size(101, 16);
            this.label_Teacher_ID.TabIndex = 1;
            this.label_Teacher_ID.Text = "Kimlik Numarası";
            // 
            // button_Teacher_Login
            // 
            this.button_Teacher_Login.Location = new System.Drawing.Point(69, 188);
            this.button_Teacher_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Teacher_Login.Name = "button_Teacher_Login";
            this.button_Teacher_Login.Size = new System.Drawing.Size(98, 28);
            this.button_Teacher_Login.TabIndex = 0;
            this.button_Teacher_Login.Text = "Giriş";
            this.button_Teacher_Login.UseVisualStyleBackColor = true;
            this.button_Teacher_Login.Click += new System.EventHandler(this.button_Teacher_Login_Click);
            // 
            // AutomationLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 278);
            this.Controls.Add(this.groupBox_Teacher_Login);
            this.Controls.Add(this.groupBox_Student_Login);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AutomationLoginForm";
            this.Text = "Sistem Giriş Ekranı";
            this.Load += new System.EventHandler(this.AutomationLoginForm_Load);
            this.groupBox_Student_Login.ResumeLayout(false);
            this.groupBox_Student_Login.PerformLayout();
            this.groupBox_Teacher_Login.ResumeLayout(false);
            this.groupBox_Teacher_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Student_Login;
        private System.Windows.Forms.Button button_Student_Login;
        private System.Windows.Forms.TextBox textBox_Student_Password;
        private System.Windows.Forms.TextBox textBox_Student_ID;
        private System.Windows.Forms.Label label_Student_ID;
        private System.Windows.Forms.Label label_Student_Password;
        private System.Windows.Forms.GroupBox groupBox_Teacher_Login;
        private System.Windows.Forms.Label label_Teacher_Password;
        private System.Windows.Forms.TextBox textBox_Teacher_Password;
        private System.Windows.Forms.TextBox textBox_Teacher_ID;
        private System.Windows.Forms.Label label_Teacher_ID;
        private System.Windows.Forms.Button button_Teacher_Login;
    }
}

