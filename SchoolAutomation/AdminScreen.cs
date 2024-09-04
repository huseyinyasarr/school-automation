using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolAutomation
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            List();
        }

        SqlConnection connectionString = new SqlConnection("Server=(localdb)\\localDB1;Database=SchoolDb;Trusted_Connection=True;");

        public string id;
        protected string pass = "";



        public void List()
        {
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("select *from student", connectionString);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();


                item.Text = reader.GetString(0);
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader["Class"].ToString());
                item.SubItems.Add(reader.GetString(4));





                listView1.Items.Add(item);


            }
            connectionString.Close();

        }



        private void AdminScreen_Load(object sender, EventArgs e)
        {
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("select *from teacher WHERE IdentificationNumber like '" + id + "' ", connectionString);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                label_Teacher_FirstName.Text = "Hoşgeldin" + reader["Firstname"].ToString() + " " + reader["LastName"];
                textBox_Teacher_ID.Text = id;
                textBox_Teacher_Address.Text = reader["Address"].ToString();
                textBox_Teacher_FirstName.Text = reader["FirstName"].ToString();
                textBox_Teacher_LastName.Text = reader["LastName"].ToString();
                textBox_Teacher_Branch.Text = reader["Branch"].ToString();

                pass = reader["Password"].ToString();

            }

            connectionString.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewRegistration().ShowDialog();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            listView1.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clear();
            List();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            new AdminEditScreen().ShowDialog();
        }

        private void button_Teacher_Save_Click(object sender, EventArgs e)
        {
            connectionString.Open();


            SqlCommand write = new SqlCommand("UPDATE teacher SET Address=@Address WHERE IdentificationNumber=@IdentificationNumber", connectionString);



            write.Parameters.AddWithValue("@IdentificationNumber", id);
            write.Parameters.AddWithValue("@Address", textBox_Teacher_Address.Text);

            write.ExecuteNonQuery();
            connectionString.Close();


            MessageBox.Show("Kayıt başarılı", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_ChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Teacher_Password.Text) || string.IsNullOrEmpty(textBox_Teacher_NewPassword.Text) || string.IsNullOrEmpty(textBox_Teacher_ConfirmNewPassword.Text) || textBox_Teacher_NewPassword.Text != textBox_Teacher_ConfirmNewPassword.Text || PasswordEncryptor.MD5Hash(textBox_Teacher_Password.Text) != pass)
            {
                MessageBox.Show("Hatalı Şifre!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Teacher_Password.Clear();
                textBox_Teacher_NewPassword.Clear();
                textBox_Teacher_ConfirmNewPassword.Clear();
            }

            else
            {
                connectionString.Open();


                SqlCommand write = new SqlCommand("UPDATE teacher SET Password=@Password WHERE IdentificationNumber like '" + id + "' ", connectionString);



                write.Parameters.AddWithValue("@Password", PasswordEncryptor.MD5Hash(textBox_Teacher_NewPassword.Text));

                write.ExecuteNonQuery();
                connectionString.Close();


                MessageBox.Show("Şifre Değiştirme başarılı", "Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                Application.Restart();
                Environment.Exit(0);


            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox_Teacher_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Teacher_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminScreen_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Restart();
            Environment.Exit(0);
        }
    }
}
