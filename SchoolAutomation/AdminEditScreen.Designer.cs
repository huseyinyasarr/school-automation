namespace SchoolAutomation
{
    partial class AdminEditScreen
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Edit = new System.Windows.Forms.GroupBox();
            this.button_Save_Edit = new System.Windows.Forms.Button();
            this.textBox_Address_Edit = new System.Windows.Forms.TextBox();
            this.label_Address_Edit = new System.Windows.Forms.Label();
            this.textBox_Class_Edit = new System.Windows.Forms.TextBox();
            this.label_Class_Edit = new System.Windows.Forms.Label();
            this.textBox_LastName_Edit = new System.Windows.Forms.TextBox();
            this.label_LastName_Edit = new System.Windows.Forms.Label();
            this.textBox_FirstName_Edit = new System.Windows.Forms.TextBox();
            this.label_FirstName_Edit = new System.Windows.Forms.Label();
            this.textBox_IdentificationNumber_Edit = new System.Windows.Forms.TextBox();
            this.label_IdentificationNumber_Edit = new System.Windows.Forms.Label();
            this.button_List_Edit = new System.Windows.Forms.Button();
            this.button_Delete_Edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_Edit.SuspendLayout();
            this.SuspendLayout();
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
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 346);
            this.listView1.TabIndex = 0;
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
            this.columnHeader3.Text = "Adı";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 110;
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
            // groupBox_Edit
            // 
            this.groupBox_Edit.Controls.Add(this.button_Save_Edit);
            this.groupBox_Edit.Controls.Add(this.textBox_Address_Edit);
            this.groupBox_Edit.Controls.Add(this.label_Address_Edit);
            this.groupBox_Edit.Controls.Add(this.textBox_Class_Edit);
            this.groupBox_Edit.Controls.Add(this.label_Class_Edit);
            this.groupBox_Edit.Controls.Add(this.textBox_LastName_Edit);
            this.groupBox_Edit.Controls.Add(this.label_LastName_Edit);
            this.groupBox_Edit.Controls.Add(this.textBox_FirstName_Edit);
            this.groupBox_Edit.Controls.Add(this.label_FirstName_Edit);
            this.groupBox_Edit.Controls.Add(this.textBox_IdentificationNumber_Edit);
            this.groupBox_Edit.Controls.Add(this.label_IdentificationNumber_Edit);
            this.groupBox_Edit.Location = new System.Drawing.Point(805, 15);
            this.groupBox_Edit.Name = "groupBox_Edit";
            this.groupBox_Edit.Size = new System.Drawing.Size(227, 344);
            this.groupBox_Edit.TabIndex = 1;
            this.groupBox_Edit.TabStop = false;
            this.groupBox_Edit.Text = "Düzenle";
            // 
            // button_Save_Edit
            // 
            this.button_Save_Edit.Location = new System.Drawing.Point(113, 305);
            this.button_Save_Edit.Name = "button_Save_Edit";
            this.button_Save_Edit.Size = new System.Drawing.Size(98, 28);
            this.button_Save_Edit.TabIndex = 10;
            this.button_Save_Edit.Text = "Kaydet";
            this.button_Save_Edit.UseVisualStyleBackColor = true;
            // 
            // textBox_Address_Edit
            // 
            this.textBox_Address_Edit.Location = new System.Drawing.Point(15, 268);
            this.textBox_Address_Edit.Name = "textBox_Address_Edit";
            this.textBox_Address_Edit.Size = new System.Drawing.Size(196, 22);
            this.textBox_Address_Edit.TabIndex = 9;
            // 
            // label_Address_Edit
            // 
            this.label_Address_Edit.AutoSize = true;
            this.label_Address_Edit.Location = new System.Drawing.Point(14, 244);
            this.label_Address_Edit.Name = "label_Address_Edit";
            this.label_Address_Edit.Size = new System.Drawing.Size(43, 16);
            this.label_Address_Edit.TabIndex = 8;
            this.label_Address_Edit.Text = "Adres";
            // 
            // textBox_Class_Edit
            // 
            this.textBox_Class_Edit.Location = new System.Drawing.Point(15, 214);
            this.textBox_Class_Edit.Name = "textBox_Class_Edit";
            this.textBox_Class_Edit.Size = new System.Drawing.Size(196, 22);
            this.textBox_Class_Edit.TabIndex = 7;
            // 
            // label_Class_Edit
            // 
            this.label_Class_Edit.AutoSize = true;
            this.label_Class_Edit.Location = new System.Drawing.Point(14, 190);
            this.label_Class_Edit.Name = "label_Class_Edit";
            this.label_Class_Edit.Size = new System.Drawing.Size(32, 16);
            this.label_Class_Edit.TabIndex = 6;
            this.label_Class_Edit.Text = "Sınıf";
            // 
            // textBox_LastName_Edit
            // 
            this.textBox_LastName_Edit.Location = new System.Drawing.Point(15, 160);
            this.textBox_LastName_Edit.Name = "textBox_LastName_Edit";
            this.textBox_LastName_Edit.Size = new System.Drawing.Size(196, 22);
            this.textBox_LastName_Edit.TabIndex = 5;
            // 
            // label_LastName_Edit
            // 
            this.label_LastName_Edit.AutoSize = true;
            this.label_LastName_Edit.Location = new System.Drawing.Point(14, 136);
            this.label_LastName_Edit.Name = "label_LastName_Edit";
            this.label_LastName_Edit.Size = new System.Drawing.Size(55, 16);
            this.label_LastName_Edit.TabIndex = 4;
            this.label_LastName_Edit.Text = "Soyisim";
            // 
            // textBox_FirstName_Edit
            // 
            this.textBox_FirstName_Edit.Location = new System.Drawing.Point(15, 106);
            this.textBox_FirstName_Edit.Name = "textBox_FirstName_Edit";
            this.textBox_FirstName_Edit.Size = new System.Drawing.Size(196, 22);
            this.textBox_FirstName_Edit.TabIndex = 3;
            // 
            // label_FirstName_Edit
            // 
            this.label_FirstName_Edit.AutoSize = true;
            this.label_FirstName_Edit.Location = new System.Drawing.Point(14, 82);
            this.label_FirstName_Edit.Name = "label_FirstName_Edit";
            this.label_FirstName_Edit.Size = new System.Drawing.Size(31, 16);
            this.label_FirstName_Edit.TabIndex = 2;
            this.label_FirstName_Edit.Text = "İsim";
            // 
            // textBox_IdentificationNumber_Edit
            // 
            this.textBox_IdentificationNumber_Edit.Location = new System.Drawing.Point(15, 52);
            this.textBox_IdentificationNumber_Edit.Name = "textBox_IdentificationNumber_Edit";
            this.textBox_IdentificationNumber_Edit.Size = new System.Drawing.Size(196, 22);
            this.textBox_IdentificationNumber_Edit.TabIndex = 1;
            // 
            // label_IdentificationNumber_Edit
            // 
            this.label_IdentificationNumber_Edit.AutoSize = true;
            this.label_IdentificationNumber_Edit.Location = new System.Drawing.Point(14, 28);
            this.label_IdentificationNumber_Edit.Name = "label_IdentificationNumber_Edit";
            this.label_IdentificationNumber_Edit.Size = new System.Drawing.Size(103, 16);
            this.label_IdentificationNumber_Edit.TabIndex = 0;
            this.label_IdentificationNumber_Edit.Text = "Kimlik Numarası";
            // 
            // button_List_Edit
            // 
            this.button_List_Edit.Location = new System.Drawing.Point(23, 323);
            this.button_List_Edit.Name = "button_List_Edit";
            this.button_List_Edit.Size = new System.Drawing.Size(98, 28);
            this.button_List_Edit.TabIndex = 2;
            this.button_List_Edit.Text = "Listele";
            this.button_List_Edit.UseVisualStyleBackColor = true;
            this.button_List_Edit.Click += new System.EventHandler(this.button_List_Edit_Click);
            // 
            // button_Delete_Edit
            // 
            this.button_Delete_Edit.Location = new System.Drawing.Point(130, 323);
            this.button_Delete_Edit.Name = "button_Delete_Edit";
            this.button_Delete_Edit.Size = new System.Drawing.Size(98, 28);
            this.button_Delete_Edit.TabIndex = 3;
            this.button_Delete_Edit.Text = "Sil";
            this.button_Delete_Edit.UseVisualStyleBackColor = true;
            this.button_Delete_Edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminEditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Delete_Edit);
            this.Controls.Add(this.button_List_Edit);
            this.Controls.Add(this.groupBox_Edit);
            this.Controls.Add(this.listView1);
            this.Name = "AdminEditScreen";
            this.Text = "AdminEditScreen";
            this.groupBox_Edit.ResumeLayout(false);
            this.groupBox_Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox_Edit;
        private System.Windows.Forms.Label label_IdentificationNumber_Edit;
        private System.Windows.Forms.TextBox textBox_IdentificationNumber_Edit;
        private System.Windows.Forms.TextBox textBox_Address_Edit;
        private System.Windows.Forms.Label label_Address_Edit;
        private System.Windows.Forms.TextBox textBox_Class_Edit;
        private System.Windows.Forms.Label label_Class_Edit;
        private System.Windows.Forms.TextBox textBox_LastName_Edit;
        private System.Windows.Forms.Label label_LastName_Edit;
        private System.Windows.Forms.TextBox textBox_FirstName_Edit;
        private System.Windows.Forms.Label label_FirstName_Edit;
        private System.Windows.Forms.Button button_Save_Edit;
        private System.Windows.Forms.Button button_List_Edit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button_Delete_Edit;
        private System.Windows.Forms.Button button1;
    }
}