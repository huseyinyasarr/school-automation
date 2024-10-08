﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SchoolAutomation
{
    public partial class StudentScreen : Form
    {
        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");

        public string id;
        protected string pass = "";


        public StudentScreen()
        {
            InitializeComponent();

           

        }

        

        private void StudentScreen_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Restart();
            Environment.Exit(0);
        }

        protected void StudentScreen_Load(object sender, EventArgs e)
        {
            
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("select *from student WHERE IdentificationNumber like '" + id + "' ", connectionString);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox_FirstNameAndLastName.Text =reader["Firstname"].ToString() + " " + reader["LastName"];
                textBox_Student_ID.Text = id;
                textBox_Student_Address.Text = reader["Address"].ToString();
                textBox_Class.Text = reader["Class"].ToString();
                pass = reader["Password"].ToString();
                
            }

            connectionString.Close();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button_Student_Save_Edit_Click(object sender, EventArgs e)
        {
            connectionString.Open();

            
            SqlCommand write = new SqlCommand("UPDATE student SET Address=@Address WHERE IdentificationNumber=@IdentificationNumber", connectionString);

            

            write.Parameters.AddWithValue("@IdentificationNumber", id);
            write.Parameters.AddWithValue("@Address", textBox_Student_Address.Text);

            write.ExecuteNonQuery();
            connectionString.Close();


            MessageBox.Show("Kayıt başarılı", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_ChangePassword_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox_Student_Password.Text) || string.IsNullOrEmpty(textBox_Student_NewPassword.Text) || string.IsNullOrEmpty(textBox_Student_ConfirmNewPassword.Text) || PasswordEncryptor.MD5Hash(textBox_Student_Password.Text) != pass || textBox_Student_NewPassword.Text != textBox_Student_ConfirmNewPassword.Text )
            {
                MessageBox.Show("Hatalı Şifre!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Student_Password.Clear();
                textBox_Student_NewPassword.Clear();
                textBox_Student_ConfirmNewPassword.Clear();
            }

            else
            {
                connectionString.Open();


                SqlCommand write = new SqlCommand("UPDATE student SET Password=@Password WHERE IdentificationNumber like '" + id + "' ", connectionString);



                write.Parameters.AddWithValue("@Password", PasswordEncryptor.MD5Hash(textBox_Student_NewPassword.Text));

                write.ExecuteNonQuery();
                connectionString.Close();


                MessageBox.Show("Şifre Değiştirme başarılı", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
