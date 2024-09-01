﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolAutomation
{
    public partial class NewRegistration : Form
    {
        public NewRegistration()
        {
            InitializeComponent();
        }

        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");

        

        public void Save()
        {
            connectionString.Open();

            //SqlCommand write = new SqlCommand("INSERT INTO student FirstName=@FirstName, LastName=@LastName, Address=@Address WHERE IdentificationNumber=@IdentificationNumber", connectionString);


            String write = "INSERT INTO dbo.student (IdentificationNumber, Class, FirstName,LastName,Address) VALUES (@IdentificationNumber,@Class,@FirstName,@LastName, @Address)";

            SqlCommand command = new SqlCommand(write, connectionString);
            command.Parameters.Add("@IdentificationNumber", textBox_ID.Text);
            command.Parameters.Add("@Class", Convert.ToInt32(textBox_Class.Text));
            command.Parameters.Add("@FirstName", textBox_FirstName.Text);
            command.Parameters.Add("@LastName", textBox_LastName.Text);
            command.Parameters.Add("@Address", textBox_Address.Text);

            command.ExecuteNonQuery();


            MessageBox.Show("Kayıt başarılı", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Clear();
            connectionString.Close();

        }

        public void Clear()
        {
            textBox_Address.Text = "";
            textBox_Class.Text = "";
            textBox_FirstName.Text = "";
            textBox_LastName.Text = "";
            textBox_ID.Text = "";

        }

        private void NewRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        public int YesOrNo()
        {
            try
            {
                if (textBox_ID.Text == "" || textBox_FirstName.Text == "" || textBox_LastName.Text == "" || Convert.ToInt32(textBox_Class.Text) < 0 || Convert.ToInt32(textBox_Class.Text) > 4 || textBox_Address.Text == "")
                {
                    MessageBox.Show("Tüm bilgileri doğru girdiğinizden emin olunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }

                else
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }


        }

        private void button_Save_Registration_Click(object sender, EventArgs e)
        {
            var i = YesOrNo();

            if (i == 0)
            {

            }

            else
            {
                Save();
                Clear();
                this.Close();
            }

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            var i = YesOrNo();
            if (i == 0)
            {

            }

            else
            {
                Save();
                
                Clear();
                
            }

        }

        private void textBox_Class_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Class_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Yalnızca rakam giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Yalnızca sayı giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
