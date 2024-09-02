namespace SchoolAutomation
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
            this.textBox_Student_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Student_FirstName = new System.Windows.Forms.TextBox();
            this.label_Student_Password = new System.Windows.Forms.Label();
            this.label_Student_Address = new System.Windows.Forms.Label();
            this.label_Student_ID = new System.Windows.Forms.Label();
            this.textBox_Student_Password = new System.Windows.Forms.TextBox();
            this.textBox_Student_Address = new System.Windows.Forms.TextBox();
            this.textBox_Student_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Student_Save_Edit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Student_Save_Edit);
            this.panel1.Controls.Add(this.textBox_Student_LastName);
            this.panel1.Controls.Add(this.textBox_Student_FirstName);
            this.panel1.Controls.Add(this.label_Student_Password);
            this.panel1.Controls.Add(this.label_Student_Address);
            this.panel1.Controls.Add(this.label_Student_ID);
            this.panel1.Controls.Add(this.textBox_Student_Password);
            this.panel1.Controls.Add(this.textBox_Student_Address);
            this.panel1.Controls.Add(this.textBox_Student_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 252);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_Student_LastName
            // 
            this.textBox_Student_LastName.Location = new System.Drawing.Point(439, 134);
            this.textBox_Student_LastName.Name = "textBox_Student_LastName";
            this.textBox_Student_LastName.Size = new System.Drawing.Size(100, 22);
            this.textBox_Student_LastName.TabIndex = 8;
            // 
            // textBox_Student_FirstName
            // 
            this.textBox_Student_FirstName.Location = new System.Drawing.Point(439, 74);
            this.textBox_Student_FirstName.Name = "textBox_Student_FirstName";
            this.textBox_Student_FirstName.Size = new System.Drawing.Size(100, 22);
            this.textBox_Student_FirstName.TabIndex = 7;
            // 
            // label_Student_Password
            // 
            this.label_Student_Password.AutoSize = true;
            this.label_Student_Password.Location = new System.Drawing.Point(32, 175);
            this.label_Student_Password.Name = "label_Student_Password";
            this.label_Student_Password.Size = new System.Drawing.Size(34, 16);
            this.label_Student_Password.TabIndex = 6;
            this.label_Student_Password.Text = "Şifre";
            // 
            // label_Student_Address
            // 
            this.label_Student_Address.AutoSize = true;
            this.label_Student_Address.Location = new System.Drawing.Point(32, 115);
            this.label_Student_Address.Name = "label_Student_Address";
            this.label_Student_Address.Size = new System.Drawing.Size(43, 16);
            this.label_Student_Address.TabIndex = 5;
            this.label_Student_Address.Text = "Adres";
            // 
            // label_Student_ID
            // 
            this.label_Student_ID.AutoSize = true;
            this.label_Student_ID.Location = new System.Drawing.Point(35, 55);
            this.label_Student_ID.Name = "label_Student_ID";
            this.label_Student_ID.Size = new System.Drawing.Size(103, 16);
            this.label_Student_ID.TabIndex = 4;
            this.label_Student_ID.Text = "Kimlik Numarası";
            // 
            // textBox_Student_Password
            // 
            this.textBox_Student_Password.Location = new System.Drawing.Point(35, 195);
            this.textBox_Student_Password.Name = "textBox_Student_Password";
            this.textBox_Student_Password.Size = new System.Drawing.Size(166, 22);
            this.textBox_Student_Password.TabIndex = 3;
            // 
            // textBox_Student_Address
            // 
            this.textBox_Student_Address.Location = new System.Drawing.Point(35, 135);
            this.textBox_Student_Address.Name = "textBox_Student_Address";
            this.textBox_Student_Address.Size = new System.Drawing.Size(166, 22);
            this.textBox_Student_Address.TabIndex = 2;
            // 
            // textBox_Student_ID
            // 
            this.textBox_Student_ID.Location = new System.Drawing.Point(35, 75);
            this.textBox_Student_ID.Name = "textBox_Student_ID";
            this.textBox_Student_ID.ReadOnly = true;
            this.textBox_Student_ID.Size = new System.Drawing.Size(166, 22);
            this.textBox_Student_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button_Student_Save_Edit
            // 
            this.button_Student_Save_Edit.Location = new System.Drawing.Point(439, 193);
            this.button_Student_Save_Edit.Name = "button_Student_Save_Edit";
            this.button_Student_Save_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Student_Save_Edit.TabIndex = 9;
            this.button_Student_Save_Edit.Text = "Kaydet";
            this.button_Student_Save_Edit.UseVisualStyleBackColor = true;
            this.button_Student_Save_Edit.Click += new System.EventHandler(this.button_Student_Save_Edit_Click);
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "StudentScreen";
            this.Text = "StudentScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentScreen_FormClosed);
            this.Load += new System.EventHandler(this.StudentScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox_Student_LastName;
        private System.Windows.Forms.TextBox textBox_Student_FirstName;
        private System.Windows.Forms.Button button_Student_Save_Edit;
    }
}