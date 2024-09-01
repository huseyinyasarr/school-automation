using System;
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
            SqlCommand command = new SqlCommand("select *from student", connectionString);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader["IdentificationNumber"].ToString() == textBox_Student_ID.Text && reader["Password"].ToString() == textBox_Student_Password.Text )
                {
                    new StudentScreen().ShowDialog();
                    break;
                }

                else
                {
                    MessageBox.Show("Hata!", "Hata!");
                    break;
                }

            }
            connectionString.Close();

        }


        private void button_Teacher_Login_Click(object sender, EventArgs e)
        {

            





            new AdminScreen().ShowDialog();

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
    }
}
