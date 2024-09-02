using System;
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


            Application.Exit();
            new AutomationLoginForm().ShowDialog();
        }

        protected void StudentScreen_Load(object sender, EventArgs e)
        {
            
            connectionString.Open();
            SqlCommand cmd = new SqlCommand("select *from student WHERE IdentificationNumber like '" + id + "' ", connectionString);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                label1.Text = reader["Firstname"].ToString();
                textBox_Student_ID.Text = id;
                textBox_Student_Address.Text = reader["Address"].ToString();
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
            
            if (string.IsNullOrEmpty(textBox_Student_Password.Text) || string.IsNullOrEmpty(textBox_Student_NewPassword.Text) || string.IsNullOrEmpty(textBox_Student_ConfirmNewPassword.Text) || textBox_Student_Password.Text != pass)
            {
                MessageBox.Show("Hatalı Şifre!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                connectionString.Open();


                SqlCommand write = new SqlCommand("UPDATE student SET Password=@Password WHERE IdentificationNumber like '" + id + "' ", connectionString);



                write.Parameters.AddWithValue("@Password", textBox_Student_NewPassword.Text);

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
    }
}
