﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolAutomation
{
    public partial class AutomationLoginForm : Form
    {

        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");



        public AutomationLoginForm()
        {
            InitializeComponent();
        }

        private void AutomationLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Student_Login_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand command = new SqlCommand("select * from student where IdentificationNumber='" + textBox_Student_ID.Text + "' and Password='" + PasswordEncryptor.MD5Hash(textBox_Student_Password.Text) + "'", connectionString);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                StudentScreen studentScreen = new StudentScreen();
                studentScreen.id = textBox_Student_ID.Text;
                studentScreen.Show();

                
            }
            else
            {
                reader.Close();
                MessageBox.Show("Kimlik numarası ya da Şifre hatalı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Student_ID.Clear();
                textBox_Student_Password.Clear();
            }

            connectionString.Close();


        }


        private void button_Teacher_Login_Click(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand command = new SqlCommand("select * from teacher where IdentificationNumber='" + textBox_Teacher_ID.Text + "' and Password='" + PasswordEncryptor.MD5Hash(textBox_Teacher_Password.Text) + "'", connectionString);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();

                AdminScreen adminScreen = new AdminScreen();
                adminScreen.id = textBox_Teacher_ID.Text;
                adminScreen.Show();

            }
            else
            {
                reader.Close();
                MessageBox.Show("Kimlik numarası ya da Şifre hatalı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Teacher_ID.Clear();
                textBox_Teacher_Password.Clear();
            }

            connectionString.Close();

        }

        private void groupBox_Teacher_Login_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_Student_Login_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_Student_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Student_Password.PasswordChar = '*';

        }

        private void textBox_Teacher_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Teacher_Password.PasswordChar = '*';
        }

        private void AutomationLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            new AutomationLoginForm().ShowDialog();
        }

        private void textBox_Student_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void AutomationLoginForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
