namespace SchoolAutomation
{
    partial class NewRegistration
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Class = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Class = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.button_Save_Registration = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(134, 24);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(168, 22);
            this.textBox_ID.TabIndex = 0;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_Class
            // 
            this.textBox_Class.Location = new System.Drawing.Point(134, 60);
            this.textBox_Class.Name = "textBox_Class";
            this.textBox_Class.Size = new System.Drawing.Size(168, 22);
            this.textBox_Class.TabIndex = 0;
            this.textBox_Class.TextChanged += new System.EventHandler(this.textBox_Class_TextChanged);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(134, 96);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(168, 22);
            this.textBox_FirstName.TabIndex = 0;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(134, 132);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(168, 22);
            this.textBox_LastName.TabIndex = 0;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(134, 168);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(168, 22);
            this.textBox_Address.TabIndex = 0;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(16, 27);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(103, 16);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "Kimlik Numarası";
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Location = new System.Drawing.Point(16, 63);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(35, 16);
            this.label_Class.TabIndex = 1;
            this.label_Class.Text = "Sınıfı";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(16, 99);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(31, 16);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "İsim";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(16, 135);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(55, 16);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Soyisim";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(16, 171);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(43, 16);
            this.label_Address.TabIndex = 1;
            this.label_Address.Text = "Adres";
            // 
            // button_Save_Registration
            // 
            this.button_Save_Registration.Location = new System.Drawing.Point(389, 238);
            this.button_Save_Registration.Name = "button_Save_Registration";
            this.button_Save_Registration.Size = new System.Drawing.Size(98, 28);
            this.button_Save_Registration.TabIndex = 2;
            this.button_Save_Registration.Text = "Kaydet";
            this.button_Save_Registration.UseVisualStyleBackColor = true;
            this.button_Save_Registration.Click += new System.EventHandler(this.button_Save_Registration_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(271, 238);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(98, 28);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "İptal";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(154, 238);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(98, 28);
            this.button_Apply.TabIndex = 3;
            this.button_Apply.Text = "Uygula";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // NewRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 278);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save_Registration);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_Class);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_Class);
            this.Controls.Add(this.textBox_ID);
            this.Name = "NewRegistration";
            this.Text = "Öğrenci Kayıt Sistemi";
            this.Load += new System.EventHandler(this.NewRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Class;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Button button_Save_Registration;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Apply;
    }
}