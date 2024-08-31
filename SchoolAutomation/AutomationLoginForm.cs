using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolAutomation
{
    public partial class AutomationLoginForm : Form
    {
        



        public AutomationLoginForm()
        {
            InitializeComponent();
        }

        private void AutomationLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Student_Login_Click(object sender, EventArgs e)
        {

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
            textBox_Teacher_Password.PasswordChar = '*';
            var password =  textBox_Student_Password.Text;

        }

        private void textBox_Teacher_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Teacher_Password.PasswordChar = '*';
        }
    }
}
