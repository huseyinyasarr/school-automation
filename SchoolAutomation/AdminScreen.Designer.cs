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
            this.dataGridView_AdminScreen = new System.Windows.Forms.DataGridView();
            this.button_New_Registration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdminScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_AdminScreen
            // 
            this.dataGridView_AdminScreen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AdminScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AdminScreen.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_AdminScreen.Name = "dataGridView_AdminScreen";
            this.dataGridView_AdminScreen.RowHeadersWidth = 51;
            this.dataGridView_AdminScreen.RowTemplate.Height = 24;
            this.dataGridView_AdminScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_AdminScreen.Size = new System.Drawing.Size(776, 235);
            this.dataGridView_AdminScreen.TabIndex = 0;
            this.dataGridView_AdminScreen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_New_Registration
            // 
            this.button_New_Registration.Location = new System.Drawing.Point(690, 257);
            this.button_New_Registration.Name = "button_New_Registration";
            this.button_New_Registration.Size = new System.Drawing.Size(98, 28);
            this.button_New_Registration.TabIndex = 1;
            this.button_New_Registration.Text = "Yeni Kayıt";
            this.button_New_Registration.UseVisualStyleBackColor = true;
            this.button_New_Registration.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.button_New_Registration);
            this.Controls.Add(this.dataGridView_AdminScreen);
            this.Name = "AdminScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdminScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AdminScreen;
        private System.Windows.Forms.Button button_New_Registration;
    }
}