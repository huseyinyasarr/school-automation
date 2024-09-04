namespace SchoolAutomation
{
    partial class ImportFileScreen
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
            this.dataGridView_ImportData = new System.Windows.Forms.DataGridView();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_ImportFile = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ImportData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ImportData
            // 
            this.dataGridView_ImportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ImportData.Location = new System.Drawing.Point(12, 15);
            this.dataGridView_ImportData.Name = "dataGridView_ImportData";
            this.dataGridView_ImportData.RowHeadersWidth = 51;
            this.dataGridView_ImportData.RowTemplate.Height = 24;
            this.dataGridView_ImportData.Size = new System.Drawing.Size(969, 423);
            this.dataGridView_ImportData.TabIndex = 0;
            this.dataGridView_ImportData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ImportData_CellContentClick);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(171, 453);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(507, 22);
            this.textBox_FilePath.TabIndex = 7;
            // 
            // button_ImportFile
            // 
            this.button_ImportFile.Location = new System.Drawing.Point(12, 450);
            this.button_ImportFile.Name = "button_ImportFile";
            this.button_ImportFile.Size = new System.Drawing.Size(128, 28);
            this.button_ImportFile.TabIndex = 6;
            this.button_ImportFile.Text = "Dosya Seç";
            this.button_ImportFile.UseVisualStyleBackColor = true;
            this.button_ImportFile.Click += new System.EventHandler(this.button_ImportFile_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(838, 450);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(128, 28);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Kaydet";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(704, 450);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(128, 28);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "İptal";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // ImportFileScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 487);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_FilePath);
            this.Controls.Add(this.button_ImportFile);
            this.Controls.Add(this.dataGridView_ImportData);
            this.Name = "ImportFileScreen";
            this.Text = "ImportFileScreen";
            this.Load += new System.EventHandler(this.ImportFileScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ImportData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ImportData;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_ImportFile;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
    }
}